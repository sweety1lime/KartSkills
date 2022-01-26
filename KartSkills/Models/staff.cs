using System;
using System.Collections.Generic;

#nullable disable

namespace KartSkills.Models
{
    public partial class staff
    {
        public staff()
        {
            Timesheets = new HashSet<Timesheet>();
        }

        public int Staffid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public int Positionid { get; set; }
        public string Email { get; set; }
        public string Comments { get; set; }

        public virtual Position Position { get; set; }
        public virtual ICollection<Timesheet> Timesheets { get; set; }
    }
}
