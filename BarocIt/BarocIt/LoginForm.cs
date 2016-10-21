using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarocIt
{

    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
            DBHandler.Init();
        }
        

        private bool UsernameEmpty()
        {
            if (tb_username.Text.Trim().Length == 0)
            {
                errorProvider.SetError(tb_username, "Field cannot be empty!");
                return true;
            }
            return false;
        }
        private bool PasswordEmpty()
        {
            if (tb_password.Text.Trim().Length == 0)
            {
                errorProvider.SetError(tb_password, "Field cannot be empty!");
                return true;
            }
            return false;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (!UsernameEmpty() && !PasswordEmpty())
            {
                MainForm mainForm = null;

                if (DBHandler.CheckLoginData(tb_username.Text, tb_password.Text, ref mainForm))
                {
                    this.Hide();

                    mainForm.ShowDialog();

                    this.Close();
                }

            }
        }

       
        ////Hash to compare values with database password
        //public static String GetMD5Hash(String TextToHash)
        //{
        //    //Check wether data was passed
        //    if ((TextToHash == null) || (TextToHash.Length == 0))
        //    {
        //        return String.Empty;
        //    }

        //    //Calculate MD5 hash. This requires that the string is splitted into a byte[].
        //    MD5 md5 = new MD5CryptoServiceProvider();
        //    byte[] textToHash = Encoding.Default.GetBytes(TextToHash);
        //    byte[] result = md5.ComputeHash(textToHash);

        //    //Convert result back to string.
        //    return System.BitConverter.ToString(result);
        //}

    }
}
