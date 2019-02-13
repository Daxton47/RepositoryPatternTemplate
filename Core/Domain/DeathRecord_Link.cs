using System.ComponentModel.DataAnnotations;

namespace RoyCityCemetery.Core.Domain
{
    public class DeathRecord_Link
    {
        [Key] public int Id { get; set; }
        public string LinkUrl { get; set; }
        public DeathRecord DeathRecord { get; set; }
    }
}