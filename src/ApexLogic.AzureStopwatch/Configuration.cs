using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ApexLogic.AzureStopwatch
{
    public class Configuration
    {
        public const string DEFAULT_FILE = "config.xml";

        public bool AuthenticateWithPAT { get; set; } = true;
        public string Username { get; set; } = "";
        public string Password { get; set; } = "";
        public string PersonalAccessToken { get; set; } = "";
        public string Host { get; set; } = "";
        public string Project { get; set; } = "";
        public string IterationPath { get; set; } = "";
        public string SpentTimeField { get; set; } = "";
        public bool StopTrackingInAfterHours { get; set; } = true;
        public bool AutoSendOnAfterHours { get; set; } = false;

        [XmlIgnore]
        public TimeOnly AfterHoursStart { get; set; } = new TimeOnly(17, 0);
        public string AfterHours
        {
            get
            {
                return AfterHoursStart.ToString("HH:mm");
            }
            set
            {
                AfterHoursStart = TimeOnly.Parse(value);
            }
        }

        public static Tuple<bool, Configuration> Load(string file)
        {
            bool needsSettings = false;
            Configuration result = null;

            if(!File.Exists(file))
            {
                new Configuration().Save(file);
                needsSettings = true;
            }

            XmlSerializer ser = new XmlSerializer(typeof(Configuration));
            using(StreamReader sr = new StreamReader(file))
            {
                result = ser.Deserialize(sr) as Configuration;
            }

            return new Tuple<bool, Configuration>(needsSettings, result);
        }

        public void Save(string file)
        {
            XmlSerializer ser = new XmlSerializer(typeof(Configuration));
            using (StreamWriter sw = new StreamWriter(file))
            {
                ser.Serialize(sw, this);
            }
        }
    }
}
