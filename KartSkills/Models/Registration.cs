﻿using System;
using System.Collections.Generic;

#nullable disable

namespace KartSkills.Models
{
    public partial class Registration
    {
        public Registration()
        {
            Results = new HashSet<Result>();
        }

        public int IdRegistration { get; set; }
        public int IdRacer { get; set; }
        public DateTime RegistrationDate { get; set; }
        public int IdRegistrationStatus { get; set; }
        public decimal Cost { get; set; }
        public int IdCharity { get; set; }
        public decimal SponsorshipTarget { get; set; }

        public virtual Charity IdCharityNavigation { get; set; }
        public virtual Racer IdRacerNavigation { get; set; }
        public virtual ICollection<Result> Results { get; set; }
    }
}
