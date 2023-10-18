using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ApexLogic.AzureStopwatch
{
    internal class DevopsApi
    {
        public DevopsApi(string pat)
        {
            Configure(pat);
        }

        public void Configure(string pat)
        {
        }

        public List<WorkItem> GetActiveTasks()
        {
            List<WorkItem> result = new List<WorkItem>();

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.ASCII.GetBytes(string.Format("{0}:{1}", "", Globals.Configuration.PersonalAccessToken))));

                string host = $"{Globals.Configuration.Host}/_apis/wit/wiql?api-version=7.1-preview.2";
                string query = "SELECT [System.Title] " +
                                "FROM WorkItems " +
                                "WHERE" +
                               $"   [System.IterationPath] = @currentIteration('{Globals.Configuration.IterationPath.Replace("\\", "\\\\")}') AND " +
                                "   [System.AssignedTo] = @Me AND " +
                                "   [System.State] NOT IN ('Done')";

                using (HttpResponseMessage response = client.PostAsync(host, new StringContent($"{{\"query\": \"{query}\" }}", Encoding.UTF8, "application/json")).Result)
                {
                    response.EnsureSuccessStatusCode();
                    string responseBody = response.Content.ReadAsStringAsync().Result;
                    Regex r = new Regex("\"id\":(\\d+),");
                    MatchCollection m = r.Matches(responseBody);

                    Parallel.ForEach(m, (match) =>
                    {
                        int id = int.Parse(match.Groups[1].Value);
                        string rawData = GetWorkitemRawData(id);
                        string title = Regex.Match(rawData, "\"System.Title\":\"(.+?)\",").Groups[1].Value;
                        float timeSpent = float.Parse(Regex.Match(rawData, $"\"{Globals.Configuration.SpentTimeField}\":([\\d\\.]+),").Groups[1].Value, NumberStyles.Any, CultureInfo.InvariantCulture);
                        result.Add(new WorkItem()
                        {
                            Id = id,
                            BaseSpentTime = TimeSpan.FromHours(timeSpent),
                            Title = title
                        });
                    });
                }
            }

            return result.OrderBy(wi => wi.Id).ToList();
        }

        public string GetWorkitemRawData(int id)
        {
            string result = string.Empty;

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.ASCII.GetBytes(string.Format("{0}:{1}", "", Globals.Configuration.PersonalAccessToken))));

                string host = $"{Globals.Configuration.Host}/{Globals.Configuration.Project}/_apis/wit/workitems/{id}?api-version=7.1-preview.3";

                using (HttpResponseMessage response = client.GetAsync(host).Result)
                {
                    response.EnsureSuccessStatusCode();
                    result = response.Content.ReadAsStringAsync().Result;
                }
            }

            return result;
        }

        public void UpdateSpentTime(TrackedTime time)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.ASCII.GetBytes(string.Format("{0}:{1}", "", Globals.Configuration.PersonalAccessToken))));

                string host = $"{Globals.Configuration.Host}/_apis/wit/wiql/workitems/{time.WorkItem.Id}?api-version=7.1-preview.2";
                string query = "[" +
                                "{" +
                                    "\"op\": \"add\"," +
                                   $"\"path\": \"/fields/{Globals.Configuration.SpentTimeField}\"," +
                                   $"\"value\": {time.WorkItem.BaseSpentTime.TotalHours + time.SpentTimeCorrected}" +
                                "}" +
                               "]";

                using (HttpResponseMessage response = client.PatchAsync(host, new StringContent(query, Encoding.UTF8, "application/json")).Result)
                {
                    response.EnsureSuccessStatusCode();
                    string responseBody = response.Content.ReadAsStringAsync().Result;
                }
            }
        }

    }
}
