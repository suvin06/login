using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuditAuthorizationService.Providers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace AuditAuthorizationService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        
        private readonly IAuthProvider objProvider;
        public AuthenticationController(IAuthProvider _objProvider)
        {
            
            this.objProvider = _objProvider;
        }
        [HttpPost]
        public IActionResult tokenFromProvider()
        {
            string tokenByProvider = "";

            try
            {
                tokenByProvider = objProvider.GenerateJSONWebTokenFromRepo();
                return Ok(tokenByProvider);
            }
            catch (Exception e)
            {
                
                return StatusCode(500);
            }

        }
    }
}
