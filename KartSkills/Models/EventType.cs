using System;
using System.Collections.Generic;

#nullable disable

namespace KartSkills.Models
{
    public partial class EventType
    {
        public EventType()
        {
            Events = new HashSet<Event>();
        }

        public string IdEventType { get; set; }
        public string EventTypeName { get; set; }

        public virtual ICollection<Event> Events { get; set; }
    }
}
