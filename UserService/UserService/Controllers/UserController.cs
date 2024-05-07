using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserService.Models;

namespace UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        public static List<User> users = new List<User>();

        [HttpGet]
        public  IActionResult GetAllUser()
        {
            return Ok( 
               users
            );
        }


        [HttpPost]
        public IActionResult CreateUser( User model)
        {
            var user = new User { 
            Name = model.Name  ,
            Phone = model.Phone,
            Password=model.Password,
            IsDelete = model.IsDelete
           
            };
            users.Add(user);
            return Ok(new
            {
                Success= true,
                Data=user
                
            });
        }
    }
}
