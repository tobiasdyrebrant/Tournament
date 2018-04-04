using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tournament.Data;

namespace Tournament.API.Controllers
{
    public abstract class ApiController : Controller
    {
        private readonly TournamentDbContext _dbContext;

        public ApiController(TournamentDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [NonAction]
        public Task CommitAsync() => _dbContext.SaveChangesAsync();
    }
}
