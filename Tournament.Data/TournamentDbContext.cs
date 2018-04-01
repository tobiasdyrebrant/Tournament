using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tournament.Data.Entities;

namespace Tournament.Data
{
    public class TournamentDbContext : DbContext
    {
        public TournamentDbContext(DbContextOptions<TournamentDbContext> options): base(options)
        {
               
        }

        public DbSet<User> Users { get; set; }
        public DbSet<SteamUserInfo> SteamUserInfos { get; set; }
    }
}
