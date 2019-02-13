using System.ComponentModel.DataAnnotations;

namespace RoyCityCemetery.Core.Domain
{
    public class DeathRecord_Note
    {
        [Key] public int Id { get; set; }
        public string Note { get; set; }
        public DeathRecord DeathRecord { get; set; }
    }
}