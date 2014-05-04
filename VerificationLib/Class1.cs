using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace VerificationLib
{
    public class RSAlib
    {
        public static string SignData(string originalMessage, RSAParameters Parameters)
        {
            string success = "";
            var encoder = new UTF8Encoding();
            byte[] bytesToSign = encoder.GetBytes(originalMessage);

            RSAParameters parameters = Parameters;

            using (var rsa = new RSACryptoServiceProvider())
            {
                try
                {
                    rsa.ImportParameters(parameters);
                    SHA256Managed Hash = new SHA256Managed();
                    
                    byte[] hashedData = Hash.ComputeHash(bytesToSign);
                    success = Convert.ToBase64String(rsa.SignData(hashedData, CryptoConfig.MapNameToOID("SHA256")));
                }
                catch (CryptographicException e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    rsa.PersistKeyInCsp = false;
                }
            }
            return success;
        }

        public static bool VerifyData(string originalMessage, string signedMessage, RSAParameters Parameters)
        {
            bool success = false;
            var encoder = new UTF8Encoding();
            byte[] bytesToVerify = encoder.GetBytes(originalMessage);
            byte[] signedBytes = Convert.FromBase64String(signedMessage);

            RSAParameters parameters = Parameters;

            using (var rsa = new RSACryptoServiceProvider())
            {
                try
                {
                    rsa.ImportParameters(parameters);
                    SHA256Managed Hash = new SHA256Managed();

                    byte[] hashedData = Hash.ComputeHash(bytesToVerify);
                    success = rsa.VerifyData(hashedData, CryptoConfig.MapNameToOID("SHA256"), signedBytes);
                }
                catch (CryptographicException e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    rsa.PersistKeyInCsp = false;
                }
            }
            return success;
        }
    }
}
