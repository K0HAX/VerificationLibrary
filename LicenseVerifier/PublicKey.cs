using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LicenseVerifier
{
    class PublicKey
    {
        private static string Modulus = "vbgLIk39Gmwb0sGr/hRHPQUyH3FLzH/bkKKujX61AhScyWdO29JbnfIgn99+/GXNMYUzhqw5yqTy6MpUxOXu3sb0ii6UNFnOHrXK1QA8pm3UkmR6EEkvd9leEf4KcOxEcBer9QuVLwFY8gPhem73V75Eu8hCgM9KWyL12rm5sVE=";
        private static string Exponent = "AQAB";

        public static RSAParameters GetParams()
        {
            RSAParameters parameters = new RSAParameters();
            parameters.Modulus = Convert.FromBase64String(Modulus);
            parameters.Exponent = Convert.FromBase64String(Exponent);
            return parameters;
        }
    }
}
