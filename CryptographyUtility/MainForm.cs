using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptographyUtility
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(txtSecurityKey.Text) || string.IsNullOrEmpty(txtInput.Text))
                {
                    MessageBox.Show("You must input Security Key and Input String!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    CryptorEngine.key = txtSecurityKey.Text;
                    txtOutput.Text = CryptorEngine.Decrypt(txtInput.Text, true);
                }                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtSecurityKey.Text) || string.IsNullOrEmpty(txtInput.Text))
                {
                    MessageBox.Show("You must input Security Key and Input String!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    CryptorEngine.key = txtSecurityKey.Text;
                    txtOutput.Text = CryptorEngine.Encrypt(txtInput.Text, true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
