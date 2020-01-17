using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SargeStoreDomain.Entities.Identity
{
    public class User : IdentityUser
    {
        public string Description { get; set; }
    }

    public class Role : IdentityRole
    {
        public string Description { get; set; }
    }
}
