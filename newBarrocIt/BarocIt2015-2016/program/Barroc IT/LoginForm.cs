using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Barroc_IT
{
    public enum Role { Finance, Sales, Development}
    public partial class LoginForm : Form
    {
        private Role role;
        private DBHandler dbHandler;
        public LoginForm()
        {
            dbHandler = new DBHandler();
            InitializeComponent();
            dbHandler.Init();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
                if (dbHandler.CheckLoginData(tbx_ussername.Text, tbx_password.Text, ref role))
                {
                    this.Hide();

                    MainForm form2 = new MainForm(role);
                    form2.ShowDialog();

                    this.Close();
                }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
