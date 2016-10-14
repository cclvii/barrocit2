using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test250915
{
    public enum Role { Finance, Sales, Development, Admin }
    public enum Tabs { Client, Project, Finance}
    public enum Acces { Add, Edit, Save, Invisible}


    public partial class Form1 : Form
    {
        private Role role;

        public Form1()
        {
            InitializeComponent();
            DatabaseManager.Init();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            DatabaseManager.Connect();

            if (DatabaseManager.CheckLoginData(textBox_username.Text, textBox_password.Text))
            {
                this.Hide();

                Form_Main form2 = new Form_Main(role);
                form2.ShowDialog();

                this.Close();
            }
            textBox_password.Clear();
        }

    }
}
