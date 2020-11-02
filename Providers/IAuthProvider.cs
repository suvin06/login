
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuditAuthorizationService.Providers
{
    public interface IAuthProvider
    {
        public string GenerateJSONWebTokenFromRepo();


    }
}
