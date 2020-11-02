using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuditAuthorizationService.Repository
{
    public interface IAuthRepo
    {
        public string GenerateJSONWebToken(IConfiguration _config);
    }
}
