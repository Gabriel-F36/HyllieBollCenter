using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace HyllieBollCenter.Models
{
	public class AppUser : IdentityUser
	{
        public int? pace { get; set; }
        public int? Milage { get; set; }
        public ICollection<Tennis> Tenniss { get; set; }
    }
}
