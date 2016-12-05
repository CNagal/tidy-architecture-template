﻿using Microsoft.AspNet.Identity;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace $safeprojectname$.Domain.Identity
{
    public class User : IUser<int>
    {
        public User()
        {
            Roles = new Collection<UserRole>();
        }

        public int Id { get; set; }

        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }

        public virtual ICollection<UserRole> Roles { get; set; }
    }
}
