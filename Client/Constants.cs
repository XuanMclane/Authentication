using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Client
{
    public static class Constants
    {
        public const string Issuer = Audience;
        public const string Audience = "https://localhost:44344/";
        public const string Secret = "not_too_short_secret_otherwise_it_might_error";
    }
}
