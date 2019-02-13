using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RoyCityCemetery.Core.Domain
{
    public class DeathRecord
    {
        [Key] public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Nickname { get; set; }
        public string Sex { get; set; }
        public DateTime Birthdate { get; set; }
        public DateTime MarriageDate { get; set; }
        public DateTime DeathDate { get; set; }
        public string CauseOfDeath { get; set; }

        public virtual ICollection<DeathRecord_Link> DeathRecord_Links { get; set; }
        public virtual ICollection<DeathRecord_Note> DeathRecord_Notes { get; set; }

    }
}