using System;
using System.Collections.Generic;

#nullable disable

namespace KartSkills.Models
{
    public partial class Event
    {
        public Event()
        {
            Results = new HashSet<Result>();
        }

        public int IdEvent { get; set; }
        public string EventName { get; set; }
        public string IdEventType { get; set; }
        public int IdRace { get; set; }
        public DateTime StartDateTime { get; set; }
        public decimal Cost { get; set; }
        public short MaxParticipants { get; set; }

        public virtual EventType IdEventTypeNavigation { get; set; }
        public virtual Race IdRaceNavigation { get; set; }
        public virtual ICollection<Result> Results { get; set; }
    }
}
