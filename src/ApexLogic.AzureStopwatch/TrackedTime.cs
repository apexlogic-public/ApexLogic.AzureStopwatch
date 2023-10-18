using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApexLogic.AzureStopwatch
{
    internal class TrackedTime
    {
        [Browsable(false)]
        public WorkItem WorkItem { get; set; }

        [Browsable(false)]
        public TimeSpan Time { get; set; }

        [DisplayName("Task")]
        public string Title { get { return $"[{this.WorkItem.Id}] {this.WorkItem.Title}"; } }
        
        [DisplayName("Tracked time")]
        public string SpentTime { get { return this.Time.ToString("g"); } }
        
        [DisplayName("Spent time [hours]")]
        public uint SpentTimeCorrected { get; set; }

        [DisplayName("Upload?")]
        public bool ToUpload { get; set; } = true;

        [DisplayName("Status")]
        public string StatusChar { get; set; } = "F";

        public void CalculateSpentTimeCorrected()
        {
            if (this.Time.TotalHours == 0)
            {
                this.SpentTimeCorrected = 0;
                this.ToUpload = false;
            }
            else if(this.Time.TotalHours < 1)
            {
                this.SpentTimeCorrected = 1;
            }
            else
            {
                this.SpentTimeCorrected = (uint)Math.Ceiling(this.Time.TotalHours);
            }
        }
    }
}
