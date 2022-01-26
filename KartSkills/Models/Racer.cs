using System;
using System.Collections.Generic;

#nullable disable

namespace KartSkills.Models
{
    public partial class Racer
    {
        public Racer()
        {
            Registrations = new HashSet<Registration>();
        }

        public int IdRacer { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string IdCountry { get; set; }

        public virtual Gender GenderNavigation { get; set; }
        public virtual Country IdCountryNavigation { get; set; }
        public virtual ICollection<Registration> Registrations { get; set; }
    }
}
