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
    public partial class SalesForm : MainForm
    {
        private int selectedClientId = 0;

        public SalesForm()
        {
            InitializeComponent();
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsSalesProjects.tbl_salesProjects' table. You can move, or remove it, as needed.
            this.tbl_salesProjectsTableAdapter1.Fill(this.dsSalesProjects.tbl_salesProjects);
            // TODO: This line of code loads data into the 'ds_salesProjects.tbl_salesProjects' table. You can move, or remove it, as needed.
            //this.tbl_salesProjectsTableAdapter.Fill(this.ds_salesProjects.tbl_salesProjects);
            // TODO: This line of code loads data into the 'barocItDbDataSet5.tbl_clients' table. You can move, or remove it, as needed.
            this.tbl_clientsTableAdapter1.Fill(this.barocItDbDataSet5.tbl_clients);
            // TODO: This line of code loads data into the 'ds_notPaidClients.tbl_clients' table. You can move, or remove it, as needed.
            this.tbl_clientsTableAdapter.Fill(this.ds_notPaidClients.tbl_clients);
        }

        private void ShowNewClient()
        {
            btn_newClient.Hide();
            dg_allClients.Height = 230;
            gb_allClients.Height = 255;
            gb_newClient.Show();
        }
        private void HideNewClient()
        {
            gb_newClient.Hide();
            gb_allClients.Height = 341;
            dg_allClients.Height = 316;
            btn_newClient.Show();
        }
        private void ShowNewProject()
        {
            btn_newProject.Hide();
            gb_newProject.Show();
        }
        private void HideNewProject()
        {
            gb_newProject.Hide();
            btn_newProject.Show();
        }

        private void btn_newClient_Click(object sender, EventArgs e)
        {
            ShowNewClient();
        }

        private void btn_addNewClient_Click(object sender, EventArgs e)
        {
            object[] cD = new object[13] {tb_companyName.Text, tb_adress1.Text, tb_zipcode1.Text, tb_city1.Text, tb_adress2.Text, tb_zipcode2.Text, tb_city2.Text, tb_contactPerson.Text, tb_initials.Text, tb_phoneNumber1.Text, tb_phoneNumber2.Text, tb_fax.Text, tb_email.Text};

            if(DBHandler.AddClient(cD))
            {
                this.tbl_clientsTableAdapter1.Fill(this.barocItDbDataSet5.tbl_clients);
                HideNewClient();
            }
        }

        private void btn_cancelNewClient_Click(object sender, EventArgs e)
        {
            HideNewClient();
        }

        private void btn_newProject_Click(object sender, EventArgs e)
        {
            ShowNewProject();
        }

        private void btn_addNewProject_Click(object sender, EventArgs e)
        {
            if (DBHandler.AddProject(selectedClientId, 0, dtp_lastAppointment.Value, tb_lastAction.Text, dtp_nextAppointment.Value, tb_nextAction.Text))
            {
                this.tbl_clientsTableAdapter.Fill(this.ds_notPaidClients.tbl_clients); HideNewProject();
            }
        }


        

        

    }
}
