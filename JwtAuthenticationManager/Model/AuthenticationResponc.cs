using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JwtAuthenticationManager.Model
{
    class AuthenticationResponse
    {
        public string Role { get; set; }
        public string token { get; set; }

       public int Expirein { get; set; }
    }
}
