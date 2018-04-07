using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Tournament.Data;
using Tournament.Business;
using Tournament.API.Models;
using Microsoft.AspNetCore.Cors;

namespace Tournament.API.Controllers
{
    [Route("api/user")]
    public class UserController : ApiController
    {
        private readonly UserService _userService;
        public UserController(TournamentDbContext dbContext,
            UserService userService) : base(dbContext)
        {
            _userService = userService;
        }


        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody]UserCreateModel model)
        {
            // TODO: validate model

            var user = model.Map();

            user = _userService.AddUser(user);
            await CommitAsync();

            //return CreatedAtAction(nameof(GetAsync), new { id = encryptedId }, default);

            //TODO
            //return encrypted id
            return Ok(user.UserId);
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync([FromBody]UserCreateModel model)
        {            
            return Ok("Id");
        }

        [Route("test")]
        [HttpGet]
        public async Task<IActionResult> GetTestAsync([FromBody]UserCreateModel model)
        {
            return Ok("Id");
        }


    }
}
