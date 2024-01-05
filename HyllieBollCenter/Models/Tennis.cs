using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyllieBollCenter.Models
{
	public class Tennis
	{
        [Key]
        public int Id { get; set; }
        public string? AppUserId { get; set; }
        public AppUser? AppUser { get; set; }
        public string Day { get; set; }
        public string? NineToElevenId { get; set; }
        public string? ElevenToThirteenId { get; set; }
        public string? ThirteenToFifteenId { get; set; }
        public string? FifteenToSeventeenId { get; set; }
        public string? SeventeenToNineteenId { get; set; }
    }
}
