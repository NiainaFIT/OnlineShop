using Microsoft.AspNetCore.Identity;

namespace OnlineShop.Server.Models
{
    public class User : IdentityUser<int>
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
}