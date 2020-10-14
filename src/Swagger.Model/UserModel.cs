using Swashbuckle.AspNetCore.Annotations;
using System;

namespace Swagger.Model
{
    /// <summary>
    /// User Model
    /// </summary>
    public class UserModel
    {
        /// <summary>
        /// user Id
        /// </summary>
        [SwaggerSchema("User Id", ReadOnly = true)]
        public int UserId { get; set; }
        /// <summary>
        /// User Name
        /// </summary>
        [SwaggerSchema("User Name", ReadOnly = true)]
        public string UserName { get; set; }
    }
}
