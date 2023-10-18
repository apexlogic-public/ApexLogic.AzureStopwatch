using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApexLogic.AzureStopwatch
{
    internal class WorkItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public TimeSpan BaseSpentTime { get; set; }
    }
}
