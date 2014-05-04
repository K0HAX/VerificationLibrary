using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace LicenseGen
{
    public partial class uxLicenseGenForm : Form
    {
        public uxLicenseGenForm()
        {
            InitializeComponent();
        }

        private void uxGoBtn_Click(object sender, EventArgs e)
        {
            string licenseText = uxLicenseTxt.Text;
            string signature;
            signature = VerificationLib.RSAlib.SignData(licenseText, PrivateKey.GetParams());

            VerificationLib.LicenseKey key = new VerificationLib.LicenseKey();
            key.License = licenseText;
            key.Signature = signature;

            StreamWriter writer = new StreamWriter("license.xml");
            

            new XmlSerializer(typeof(VerificationLib.LicenseKey)).Serialize(writer, key);
            writer.Close();

            XmlDocument doc = new XmlDocument();

            StreamReader reader = new StreamReader("license.xml");
            doc.Load(reader);

            uxLicenseTxt.Text = doc.OuterXml;
            reader.Close();
        }
    }
}
