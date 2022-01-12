using Microsoft.AspNetCore.Identity;
using System;

namespace eCommercePizza.Entities
{ 
    public class Role : IdentityRole<int>
    {
        // TO DO:
        public string Description { get; set; }
    }
}
