using Microsoft.EntityFrameworkCore;
using System;
using Tournament.Data;
using Tournament.Data.Entities;

namespace Tournament.Business
{
    public sealed class UserService
    {
        private readonly TournamentDbContext _dbContext;
        private readonly DbSet<User> _userSet;


        public UserService(TournamentDbContext dbContext)
        {
            _dbContext = dbContext;
            _userSet = _dbContext.Set<User>();
        }

        public User AddUser(User user)
        {
            user.UserId = 0; //Ensure new id

            _userSet.Add(user);

            return user;
        }

    }
}
