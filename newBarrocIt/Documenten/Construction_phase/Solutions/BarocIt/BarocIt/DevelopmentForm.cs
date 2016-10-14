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
    public partial class DevelopmentForm : MainForm
    {
        private int selectedClientId;
        private Label[] clientLabels;

        public DevelopmentForm()
        {
            InitializeComponent();
        }

        private void DevelopmentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ExitForm exitForm = new ExitForm();
            //while(exitForm.Focused
        }

        private void InitClientList()
        {
            clientLabels = new Label[13] { lbl_clientId, lbl_companyName, lbl_adress1, lbl_zipcode1, lbl_city1, lbl_adress2, lbl_zipcode2, lbl_city2, lbl_contactPerson, lbl_initials, lbl_phoneNumber1, lbl_fax, lbl_email };
            clientLabels[0].Text = "id : ";
            clientLabels[1].Text = "Company Name : ";
            clientLabels[2].Text = "Adress 1 : ";
            clientLabels[3].Text = "Zipcode 1 : ";
            clientLabels[4].Text = "City 1 : ";
            clientLabels[5].Text = "Adress 2 : ";
            clientLabels[6].Text = "Zipcode 2 : ";
            clientLabels[7].Text = "City 2 : ";
            clientLabels[8].Text = "Contact Person : ";
            clientLabels[9].Text = "Initials : ";
            clientLabels[10].Text = "Phone Number : ";
            clientLabels[11].Text = "Fax : ";
            clientLabels[12].Text = "Email : ";
        }
        private void HideClientList() { }

        private void DevelopmentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'barocItDbDataSet4.tbl_meetings' table. You can move, or remove it, as needed.
            this.tbl_meetingsTableAdapter1.Fill(this.barocItDbDataSet4.tbl_meetings);
            // TODO: This line of code loads data into the 'dsDevelopmentProjects1.tbl_developmentProjects' table. You can move, or remove it, as needed.
            this.tbl_developmentProjectsTableAdapter3.Fill(this.dsDevelopmentProjects1.tbl_developmentProjects);
            // TODO: This line of code loads data into the 'barocItDbDataSet3.tbl_developmentProjects' table. You can move, or remove it, as needed.
            this.tbl_developmentProjectsTableAdapter2.Fill(this.barocItDbDataSet3.tbl_developmentProjects);
            // TODO: This line of code loads data into the 'barocItDbDataSet2.tbl_developmentProjects' table. You can move, or remove it, as needed.
            this.tbl_developmentProjectsTableAdapter1.Fill(this.barocItDbDataSet2.tbl_developmentProjects);
            this.tbl_applicationsTableAdapter.Fill(this.dsApplications.tbl_applications);
            this.tbl_meetingsTableAdapter.Fill(this.DsMeetings.tbl_meetings);
            this.tbl_developmentProjectsTableAdapter.Fill(this.DsDevelopmentProjects.tbl_developmentProjects);

            InitClientList();
            selectedClientId = 0;
        }

        private void btn_newMeeting_Click(object sender, EventArgs e)
        {
            btn_newMeeting.Hide(); //hide newMeeting btn
            gb_newMeeting.Show(); //show newMeeting groupbox
            //btn_cancelNewApplication.Show(); //show cancel btn
            btn_cancelNewMeeting.Show();
        }

        private void btn_newApplication_Click(object sender, EventArgs e)
        {
            btn_newApplication.Hide();
            gb_newApplication.Show();
            btn_cancelNewApplication.Show();
            btn_cancelNewApplication.Show();
        }

        private void btn_addMeeting_Click(object sender, EventArgs e)
        {
            DBHandler.AddMeeting(dtp_meeting.Value, tb_meetingSubject.Text);
            tbl_meetingsTableAdapter1.Fill(barocItDbDataSet4.tbl_meetings);
            HideNewMeeting();
        }

        private void btn_addApplication_Click(object sender, EventArgs e)
        {
            DBHandler.AddApplication(tb_applicationName.Text, tb_applicationVersion.Text);
            tbl_applicationsTableAdapter.Fill(dsApplications.tbl_applications);
            HideNewApplication();
        }

        private void btn_cancelNewMeeting_Click(object sender, EventArgs e)
        {
            HideNewMeeting();
        }

        private void btn_cancelNewApplication_Click(object sender, EventArgs e)
        {
            HideNewApplication();
        }

        private void HideNewMeeting()
        {
            btn_newMeeting.Visible = true;
            gb_newMeeting.Visible = false;
            btn_cancelNewMeeting.Visible = false;
            //dtp_meeting.ResetText();
            //tb_meetingSubject.ResetText();
        }
        private void HideNewApplication()
        {
            btn_newApplication.Visible = true;
            gb_newApplication.Visible = false;
            btn_cancelNewApplication.Visible = false;
            //tb_applicationName.ResetText();
            //tb_applicationVersion.ResetText();
        }

        private void ShowClientInfo()
        {
            InitClientList();
            string[] datas = DBHandler.ClientDatasToStringArray(selectedClientId);
            
            for(int i = 0; i < 13; i++ )
            {
                clientLabels[i].Text += datas[i];
                clientLabels[i].Show();
            }

        }

        private void ShowMeetings(int projectId)
        {
            dg_meetings.Show();
            tbl_meetingsTableAdapter1.FillBy3(barocItDbDataSet4.tbl_meetings, projectId);
            btn_newMeeting.Show();
        }
        
        private void ShowApplications(int projectId)
        {
            dg_applications.Show();
            btn_newApplication.Show();
        }

        private void dg_projects_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged == DataGridViewElementStates.Selected) //&& e.Row.Index < 
            {
                selectedClientId = int.Parse((e.Row).Cells[1].Value.ToString().Trim());
                int selectedProject = int.Parse(e.Row.Cells[0].Value.ToString().Trim());

                ShowClientInfo();
                ShowMeetings(selectedProject);
                ShowApplications(selectedProject);
            }
        }



    }
}
