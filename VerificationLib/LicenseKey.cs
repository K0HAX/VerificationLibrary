using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace VerificationLib
{
    [Serializable()]
    public class LicenseKey
    {
        public string License { get; set; }
        public string Signature { get; set; }

        public static LicenseKey deserialize(string License)
        {
            XmlSerializer ser = new XmlSerializer(typeof(LicenseKey));
            LicenseKey li = null;
            MemoryStream memStream = new MemoryStream();
            StreamReader reader = new StreamReader(memStream);
            StreamWriter writer = new StreamWriter(memStream);
            writer.Write(License);
            memStream.Position = 0;

            li = (LicenseKey)ser.Deserialize(reader);
            return li;
        }

        public static LicenseKey deserialize(StreamReader License)
        {
            XmlSerializer ser = new XmlSerializer(typeof(LicenseKey));
            LicenseKey li = null;

            li = (LicenseKey)ser.Deserialize(License);
            return li;
        }
    }
}
