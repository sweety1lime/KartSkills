using System;
using System.Collections.Generic;

#nullable disable

namespace KartSkills.Models
{
    public partial class Charity
    {
        public Charity()
        {
            Registrations = new HashSet<Registration>();
        }

        public int IdСharity { get; set; }
        public string CharityName { get; set; }
        public string CharityDescription { get; set; }
        public string CharityLogo { get; set; }

        public virtual ICollection<Registration> Registrations { get; set; }
    }
}
