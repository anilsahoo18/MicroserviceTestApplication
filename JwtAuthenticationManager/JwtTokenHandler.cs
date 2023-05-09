using JwtAuthenticationManager.Model;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JwtAuthenticationManager
{
   public class JwtTokenHandler
    {
        public const string JWT_SECURITY_KEY = "0c557f6974ab75ea179240fa8aa4a6734aa433d1dcb8fd747ae65a43e501b5b3";
        private const int JWT_TOKEN_VALIDATE_MINT = 20;
        private readonly List<UserAccount> _useraccountList;

        public JwtTokenHandler()
        {
            _useraccountList = new List<UserAccount> {
                new UserAccount { username="Raju" , password="Pass@1" , role="Admini"} ,
                new UserAccount {username="Deba" , password="Pass@2" , role="Admini"},
                new UserAccount {username="Biswa" , password="Pass@3" , role="User"}
            };
        }

        public AuthenticationResponse GenerateJwtToken(AthenticationRequest request)
        {
            if(string.IsNullOrWhiteSpace(request.username) || string.IsNullOrWhiteSpace(request.password))
            {
                return null;
            }

            var userAccount = _useraccountList.Where(k => k.username == request.username && k.password == request.password).FirstOrDefault();
            if(userAccount == null)
            {
                return null;
            }
            
            var tokenExpiryTime = DateTime.Now.AddMinutes(JWT_TOKEN_VALIDATE_MINT);
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JWT_SECURITY_KEY));


        }


    }
}
