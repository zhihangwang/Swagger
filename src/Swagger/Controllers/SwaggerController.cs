using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace swagger.Controllers
{
    /// <summary>
    /// Swagger Controller
    /// </summary>
    [Route("api/v1/[controller]")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "v1")]
    public class SwaggerController : ControllerBase
    {
        /// <summary>
        /// get swagger by id.
        /// </summary>
        /// <param name="id">swagger id</param>
        /// <returns></returns>
        [HttpGet("Get")]
        public async Task<Swagger> Get(int id)
        {
            return await Task.FromResult<Swagger>(new Swagger { Id = id, Name = "hhh" });
        }

        /// <summary>
        /// Create Swagger
        /// </summary>
        /// <param name="createSwaggerModel"></param>
        /// <returns></returns>
        /// <response code="200">Create success</response>
        [ProducesResponseType(typeof(Swagger), 200)]
        [ProducesResponseType(typeof(Expression), 500)]
        [HttpPost("Create")]
        public async Task<Swagger> Create(CreateSwaggerModel createSwaggerModel)
        {
            return await Task.FromResult<Swagger>(new Swagger { Id = 1, Name = createSwaggerModel.Name });
        }

        /// <summary>
        /// Create swagger Model
        /// </summary>
        public class CreateSwaggerModel
        {
            /// <summary>
            /// New swagger name
            /// </summary>
            public string Name { get; set; }
        }

        /// <summary>
        /// Swagger entity
        /// </summary>        
        public class Swagger
        {
            /// <summary>
            /// swagger id
            /// </summary>
            public int Id { get; set; }
            /// <summary>
            /// swagger name
            /// </summary>
            /// <example>Test</example> 
            public string Name { get; set; }
        }
    }
}
