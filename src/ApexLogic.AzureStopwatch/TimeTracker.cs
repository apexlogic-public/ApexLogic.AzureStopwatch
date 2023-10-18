using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ApexLogic.AzureStopwatch
{
    internal class TimeTracker
    {
        public int AfterHours { get; set; } = 24;

        public TrackedTime CurrentTracking { get; set; }
        public List<TrackedTime> UncommitedTracks { get; set; } = new List<TrackedTime>();

        public bool IsEnabled { get; set; } = true;
        public bool IsTracking { get; set; }

        public event EventHandler TimeChanged;
        public event EventHandler AfterHoursHit;

        private Thread m_Thread;

        public TimeTracker()
        {
            this.m_Thread = new Thread(new ThreadStart(Runner))
            {
                IsBackground = true,
                Name = "TimeTracker thread"
            };
            this.m_Thread.Start();
        }

        private void Runner()
        {
            while(this.IsEnabled)
            {
                if(this.IsTracking && (!Globals.Configuration.StopTrackingInAfterHours || TimeOnly.FromDateTime(DateTime.Now) < Globals.Configuration.AfterHoursStart))
                {
                    this.CurrentTracking.Time = this.CurrentTracking.Time.Add(TimeSpan.FromSeconds(1));
                    this.TimeChanged?.Invoke(this, EventArgs.Empty);
                }
                else if(TimeOnly.FromDateTime(DateTime.Now) == Globals.Configuration.AfterHoursStart)
                {
                    if (Globals.Configuration.StopTrackingInAfterHours)
                    {
                        this.IsTracking = false;
                    }
                    this.AfterHoursHit?.Invoke(this, EventArgs.Empty);
                }
                else if(TimeOnly.FromDateTime(DateTime.Now) == new TimeOnly(0, 0, 0))
                {
                    this.IsTracking = false;
                }

                Thread.Sleep(1000);
            }
        }

        public void ChangeToWorkitem(WorkItem workitem)
        {
            bool isTracking = this.IsTracking;
            this.IsTracking = false;

            this.CurrentTracking = new TrackedTime()
            {
                WorkItem = workitem,
                Time = new TimeSpan()
            };
            this.UncommitedTracks.Add(this.CurrentTracking);

            this.IsTracking = isTracking;
        }

        public void CombineTrackData()
        {
            List<TrackedTime> newTrackList = new List<TrackedTime>();

            foreach(TrackedTime tracking in this.UncommitedTracks)
            {
                if(tracking == this.CurrentTracking)
                {
                    newTrackList.Add(tracking);
                }
                else
                {
                    TrackedTime existing = newTrackList.FirstOrDefault(t => t.WorkItem.Id == tracking.WorkItem.Id);
                    if(existing != null)
                    {
                        existing.Time = existing.Time.Add(tracking.Time);
                        if(existing.Time.TotalSeconds > 0)
                        {
                            existing.ToUpload = true;
                        }
                    }
                    else
                    {
                        newTrackList.Add(tracking);
                    }
                }
            }

            this.UncommitedTracks = newTrackList;
        }
    }
}
