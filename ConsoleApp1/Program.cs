using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text;
using Tournament.Data;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TournamentDbContext>();
            optionsBuilder.UseSqlServer("Server=./MSSQLSERVER2017; Database=Tournament_Local; Trusted_Connection=True");

            using (var ctx = new TournamentDbContext(optionsBuilder.Options))
            {
                ctx.SaveChanges();
            }
        }

    }
}
