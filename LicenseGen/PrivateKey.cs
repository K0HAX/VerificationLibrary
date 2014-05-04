using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LicenseGen
{
    class PrivateKey
    {
        private static string Modulus = "vbgLIk39Gmwb0sGr/hRHPQUyH3FLzH/bkKKujX61AhScyWdO29JbnfIgn99+/GXNMYUzhqw5yqTy6MpUxOXu3sb0ii6UNFnOHrXK1QA8pm3UkmR6EEkvd9leEf4KcOxEcBer9QuVLwFY8gPhem73V75Eu8hCgM9KWyL12rm5sVE=";
        private static string Exponent = "AQAB";
        private static string P = "9UlPGHLn84IgInbYu0uCNjmPL+VO1k6DvDI+Tic6D16ZtxOchxtx6R9T0ReWHctjOHITN6sx6ObA/Azl0suadQ==";
        private static string Q = "xgFm+2Xkm26VyYBFjymoY66rwpluavsO5LUJLI3kpdE5NAn1zSmmVHkYIeNVLQMM+SLd9XyCdbEVeJIleKiH7Q==";
        private static string DP = "EmFm8u8RYJb8r3h2bzqOTF/t0en+CWMizgR51MNtv18YZ7apgRpWY+C8GCwLTLpD+iPaOs6yU8CO75RL2Ir3TQ==";
        private static string DQ = "eKbWF44I9OU3hGcS+59IqiT/KD7R14JPmvDtPCbiEmAg2SLQkkk0vvhiyhN6DUl0mEK0uSc7X3eeO6/iAVnAKQ==";
        private static string InverseQ = "gUkipQKZx/0btBz57L0MsNozuR4rXrah4qtQOUfHVhC6wRXQu9q42G797bL4Dk7fr4aZPzsObnXm/4isN9DQmg==";
        private static string D = "aUbKruOWEuZw3hfoqBp6mYrbkIUfKcC9h1ovAIeSTDBB/KUeJm9ptZDZt72eytJ29gbTW+UQQLodrT4xof1x+ilxuSiIXAU/rdlpaVcf9j/YQ4IVk7KrSPJ3QNN2MiQshTdnX7IXeDpyCDMyrbXEGRGBry04xr+24FeaBotLgBE=";

        public static RSAParameters GetParams()
        {
            RSAParameters parameters = new RSAParameters();
            parameters.Modulus = Convert.FromBase64String(Modulus);
            parameters.Exponent = Convert.FromBase64String(Exponent);
            parameters.P = Convert.FromBase64String(P);
            parameters.Q = Convert.FromBase64String(Q);
            parameters.DP = Convert.FromBase64String(DP);
            parameters.DQ = Convert.FromBase64String(DQ);
            parameters.InverseQ = Convert.FromBase64String(InverseQ);
            parameters.D = Convert.FromBase64String(D);

            return parameters;
        }
    }
}
