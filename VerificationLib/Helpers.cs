using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace VerificationLib
{
    public static class Helpers
    {
        public static Stream ToStream(this string @this)
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(@this);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }


        public static T ParseXML<T>(this string @this) where T : class
        {
            try
            {
                var reader = XmlReader.Create(@this.Trim().ToStream(), new XmlReaderSettings() { ConformanceLevel = ConformanceLevel.Document });
                return new XmlSerializer(typeof(T)).Deserialize(reader) as T;
            }
            catch
            {
                return null;
            }
            
        }

        public static bool VerifyKeys(string Serial, string LicenseString, RSAParameters Parameters)
        {
            VerificationLib.LicenseKey license = VerificationLib.Helpers.ParseXML<VerificationLib.LicenseKey>(LicenseString);
            try
            {
                if (VerificationLib.RSAlib.VerifyData(Serial, license.Signature, Parameters))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
            
        }

        public static bool VerifyKeys(string Serial, StreamReader LicenseStream, RSAParameters Parameters)
        {
            VerificationLib.LicenseKey license = LicenseKey.deserialize(LicenseStream);
            try
            {
                if (VerificationLib.RSAlib.VerifyData(Serial, license.Signature, Parameters))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }

        }
    }
}
