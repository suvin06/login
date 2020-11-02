
using AuditAuthorizationService.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AuditAuthorizationService.Providers
{

    public class AuthProvider : IAuthProvider
    {
        private readonly IAuthRepo objRepository;
        private IConfiguration config;
        public AuthProvider(IAuthRepo _objRepository, IConfiguration config)
        {
            this.config = config;

            objRepository = _objRepository;
        }

        public string GenerateJSONWebTokenFromRepo()
        {
            string tokenFromRepo="";
            try 
            {
                tokenFromRepo = objRepository.GenerateJSONWebToken(config);
                return tokenFromRepo;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
