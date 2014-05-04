using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyGen
{
    public partial class uxKeyGen : Form
    {
        public uxKeyGen()
        {
            InitializeComponent();
        }

        private void uxGenBtn_Click(object sender, EventArgs e)
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            RSAParameters RSAKeyInfo = RSA.ExportParameters(true);
            RSA.PersistKeyInCsp = false;
            uxKeyText.Text = RSA.ToXmlString(true);
        }
    }
}
