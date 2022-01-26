using System;
using System.Collections.Generic;

#nullable disable

namespace KartSkills.Models
{
    public partial class Race
    {
        public Race()
        {
            Events = new HashSet<Event>();
        }

        public int IdRace { get; set; }
        public string RaceName { get; set; }
        public string Sity { get; set; }
        public string IdCountry { get; set; }
        public short YearHeld { get; set; }

        public virtual Country IdCountryNavigation { get; set; }
        public virtual ICollection<Event> Events { get; set; }
    }
}
