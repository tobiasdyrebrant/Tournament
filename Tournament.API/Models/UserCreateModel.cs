using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tournament.Data.Entities;

namespace Tournament.API.Models
{
    public sealed class UserCreateModel
    {
        public string UserName { get; set; }

        public User Map()
        {
            var user = new User()
            {
                UserName = UserName
            };


            return user;
        }
    }
}
