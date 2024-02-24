using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsondecoder.Models
{
    public class AccessTokenResponse
    {
        public string Access_Token { get; set; }
        public string Token_Type { get; set; }
        public int Expires_In { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public DateTime Issued { get; set; }
        public DateTime Expires { get; set; }
    }
}
