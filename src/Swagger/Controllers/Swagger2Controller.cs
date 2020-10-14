using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace swagger.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/v2/[controller]")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "v2")]
    public class Swagger2Controller : ControllerBase
    {
        /// <summary>
        /// Test Id
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public int GetId()
        {
            return 1;
        }
    }
}
