using System;
using System.Collections.Generic;

#nullable disable

namespace KartSkills.Models
{
    public partial class Country
    {
        public Country()
        {
            Racers = new HashSet<Racer>();
            Races = new HashSet<Race>();
            Volunteers = new HashSet<Volunteer>();
        }

        public string IdCountry { get; set; }
        public string CountryName { get; set; }
        public string CountryFlag { get; set; }

        public virtual ICollection<Racer> Racers { get; set; }
        public virtual ICollection<Race> Races { get; set; }
        public virtual ICollection<Volunteer> Volunteers { get; set; }
    }
}
