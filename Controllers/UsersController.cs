using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserApi.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            var currentUser = GetCurrentUser();
            if (currentUser != null)
            {
                return Ok(currentUser);
            }
            return Unauthorized("You are not logged in");
        }

        [HttpGet("{id}")]
        public string GetById(int id)
        {
            return "" + id;
        }

        private User GetCurrentUser()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            if (identity != null && identity.Claims.Count() > 0)
            {
                return new User(
                    Guid.NewGuid(),
                    "Johan",
                    "Solbakken",
                    "johsol@stud.ntnu.no",
                    "password",
                    "ja",
                    "username",
                    "admin",
                    DateTime.Now,
                    DateTime.Now
                );
            }
            return null;
        }
    }
}

