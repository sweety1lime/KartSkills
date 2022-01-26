using System;
using System.Collections.Generic;

#nullable disable

namespace KartSkills.Models
{
    public partial class Gender
    {
        public Gender()
        {
            Racers = new HashSet<Racer>();
            Volunteers = new HashSet<Volunteer>();
        }

        public string IdGender { get; set; }
        public string GenderName { get; set; }

        public virtual ICollection<Racer> Racers { get; set; }
        public virtual ICollection<Volunteer> Volunteers { get; set; }
    }
}
