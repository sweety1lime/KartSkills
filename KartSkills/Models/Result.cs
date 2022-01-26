using System;
using System.Collections.Generic;

#nullable disable

namespace KartSkills.Models
{
    public partial class Result
    {
        public int IdResult { get; set; }
        public int IdRegistration { get; set; }
        public int IdEvent { get; set; }
        public short BidNumber { get; set; }
        public TimeSpan RaceTime { get; set; }

        public virtual Event IdEventNavigation { get; set; }
        public virtual Registration IdRegistrationNavigation { get; set; }
    }
}
