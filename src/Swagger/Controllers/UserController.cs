using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swagger.Model;

namespace swagger.Controllers
{
    /// <summary>
    /// User Controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    [ApiExplorerSettings(GroupName ="v1")]
    public class UserController : ControllerBase
    {
        /// <summary>
        /// Get User
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        public UserModel GetUser(int userId)
        {
            return new UserModel
            {
                UserId = userId,
                UserName = "Test"
            };
        }
    }
}
