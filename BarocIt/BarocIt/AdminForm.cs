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
    public partial class AdminForm : MainForm
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            string[,] datas = DBHandler.LoginDatasToArray();

            lbl_d_username.Text = "Username : " + datas[0, 0];
            lbl_d_password.Text = "Password : " + datas[0, 1];
            lbl_s_username.Text = "Username : " + datas[1, 0];
            lbl_s_password.Text = "Password : " + datas[1, 1];
            lbl_f_username.Text = "Username : " + datas[2, 0];
            lbl_f_password.Text = "Password : " + datas[2, 1];
            lbl_a_username.Text = "Username : " + datas[3, 0];
            lbl_a_password.Text = "Password : " + datas[3, 1];

        }

        


        private void btn_edit_d_user_Click(object sender, EventArgs e)
        {
            tb_d_user.Show();
        }
        private void btn_edit_d_pass_Click(object sender, EventArgs e)
        {
            tb_d_pass.Show();
        }
        private void btn_edit_s_user_Click(object sender, EventArgs e)
        {
            tb_s_user.Show();
        }
        private void btn_edit_s_pass_Click(object sender, EventArgs e)
        {
            tb_s_pass.Show();
        }
        private void btn_edit_f_user_Click(object sender, EventArgs e)
        {
            tb_f_user.Show();
        }
        private void btn_edit_f_pass_Click(object sender, EventArgs e)
        {
            tb_f_pass.Show();
        }
        private void btn_edit_a_user_Click(object sender, EventArgs e)
        {
            tb_a_user.Show();
        }
        private void btn_edit_a_pass_Click(object sender, EventArgs e)
        {
            tb_a_pass.Show();
        }

    }
}
