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
using System.Xml.Serialization;

namespace LicenseVerifier
{
    public partial class uxLicenseVerifier : Form
    {
        public uxLicenseVerifier()
        {
            InitializeComponent();
        }

        private void uxVerifyBtn_Click(object sender, EventArgs e)
        {
            string serial = Fingerprint.Value();
            string licenseString = uxLicenseBox.Text;
            bool isValid;
            StreamReader LicenseStream = new StreamReader("license.xml");

            isValid = VerificationLib.Helpers.VerifyKeys(serial, LicenseStream, PublicKey.GetParams());

            if (isValid == true)
            {
                MessageBox.Show("Valid!");
            }
            else
            {
                MessageBox.Show("Invalid!");
            }
        }

        private void uxLicenseVerifier_Load(object sender, EventArgs e)
        {
            uxIdBox.Text = Fingerprint.Value();
        }
    }
}
