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
        private int selectedProjectId;
        private Label[] clientLabels;
        private DateTimePicker dtPicker;

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
            // TODO: This line of code loads data into the 'dsDevelopmentProjects11.tbl_projects' table. You can move, or remove it, as needed.
            this.tbl_projectsTableAdapter.Fill(this.dsDevelopmentProjects11.tbl_projects);
            dtp_meeting.CustomFormat = "dd/MM/yy HH:mm";

            // TODO: This line of code loads data into the 'dsDevelopmentProjects2.tbl_developmentProjects' table. You can move, or remove it, as needed.
            this.tbl_developmentProjectsTableAdapter1.Fill(this.dsDevelopmentProjects2.tbl_developmentProjects);
            // TODO: This line of code loads data into the 'dsApplications.tbl_applications' table. You can move, or remove it, as needed.
            //this.tbl_applicationsTableAdapter.Fill(this.dsApplications.tbl_applications);
            // TODO: This line of code loads data into the 'barocItDbDataSet4.tbl_meetings' table. You can move, or remove it, as needed.
            //this.tbl_meetingsTableAdapter1.Fill(this.barocItDbDataSet4.tbl_meetings);
            // TODO: This line of code loads data into the 'dsDevelopmentProjects1.tbl_developmentProjects' table. You can move, or remove it, as needed.
            this.tbl_developmentProjectsTableAdapter3.Fill(this.dsDevelopmentProjects1.tbl_developmentProjects);
            // TODO: This line of code loads data into the 'barocItDbDataSet3.tbl_developmentProjects' table. You can move, or remove it, as needed.
            //this.tbl_applicationsTableAdapter.Fill(this.dsApplications.tbl_applications);
            //this.tbl_meetingsTableAdapter.Fill(this.DsMeetings.tbl_meetings);
            //this.tbl_developmentProjectsTableAdapter.Fill(this.DsDevelopmentProjects.tbl_developmentProjects);

            barocItDbDataSet4.EnforceConstraints = false;

            InitClientList();
            selectedClientId = 0;

            dtPicker = new DateTimePicker();
            dtPicker.Format = DateTimePickerFormat.Custom;
            dtPicker.CustomFormat = "dd/MM/yy HH:mm";
            dtPicker.Visible = false;
            
            dg_meetings.Controls.Add(dtPicker);

            
        }

        private void btn_newMeeting_Click(object sender, EventArgs e)
        {
            btn_newMeeting.Hide(); //hide newMeeting btn
            gb_newMeeting.Show(); //show newMeeting groupbox
            btn_cancelNewMeeting.Show();
        }

        private void btn_addMeeting_Click(object sender, EventArgs e)
        {
            if(CheckNewMeetingDatas(dtp_meeting.Value.Year, tb_meetingSubject.Text.Length) && DBHandler.AddMeeting(selectedProjectId, dtp_meeting.Value, tb_meetingSubject.Text))
            {
                tbl_meetingsTableAdapter1.FillBy3(barocItDbDataSet4.tbl_meetings, selectedProjectId);
                errorProvider.Clear();
                errorProvider1.Clear();
                HideNewMeeting();
            }
            
        }

        private bool CheckNewMeetingDatas(int year, int subjLength)
        {
            errorProvider.Clear();
            errorProvider1.Clear();
            bool good = true; //good datas

            if(year < DateTime.Now.Year - 1)
            {
                DialogResult dResult = MessageBox.Show("Is this year correct : " + year + " ?", "title", MessageBoxButtons.YesNo);

                if (dResult == System.Windows.Forms.DialogResult.No)
                {
                    errorProvider.SetError(dtp_meeting, "wrong year");
                    good = false;
                }
            }

            if (subjLength >= 50)//TODO: check text max lenght with database
            {
                errorProvider1.SetError(tb_meetingSubject, "to long text (max : 50) (actual lenght : " + subjLength + ")");
                good = false;
            }

            if (good)
                return true;
            return false;
        }
                
        private void btn_newApplication_Click(object sender, EventArgs e)
        {
            btn_newApplication.Hide();
            gb_newApplication.Show();
            btn_cancelNewApplication.Show();
            btn_cancelNewApplication.Show();
        }

        private void btn_addApplication_Click(object sender, EventArgs e)
        {
            if(CheckNewApplication(tb_applicationName.Text.Length, tb_applicationVersion.Text.Length) && DBHandler.AddApplication(selectedProjectId, tb_applicationName.Text, tb_applicationVersion.Text))
            {
                this.tbl_applicationsTableAdapter.FillBy(dsApplications.tbl_applications, selectedProjectId);
                errorProvider2.Clear();
                errorProvider3.Clear();
                HideNewApplication();
            }
        }

        private bool CheckNewApplication(int nLength, int vLength)//name & version
        {
            errorProvider2.Clear();
            errorProvider3.Clear();
            bool good = true;

            if (nLength >= 50)//TODO: check text max lenght with database
            {
                errorProvider2.SetError(tb_applicationName, "to long text (max : 50) (actual lenght : " + nLength + ")");
                good = false;
            }
            if (vLength >= 50)//TODO: check text max lenght with database
            {
                errorProvider3.SetError(tb_applicationVersion, "to long text (max : 50) (actual lenght : " + vLength + ")");
                good = false;
            }

            if (good)
                return true;
            return false;
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
            dtp_meeting.ResetText();
            tb_meetingSubject.ResetText();
        }
        private void HideNewApplication()
        {
            btn_newApplication.Visible = true;
            gb_newApplication.Visible = false;
            btn_cancelNewApplication.Visible = false;
            tb_applicationName.ResetText();
            tb_applicationVersion.ResetText();
        }
        private void ShowClientInfo()
        {
            InitClientList();
            string[] datas = DBHandler.ClientDatasToArray(selectedClientId);
            
            for(int i = 0; i < 13; i++ )
            {
                clientLabels[i].Text += datas[i];
                clientLabels[i].Show();
            }

        }
        private void ShowMeetings()
        {
            if(!dg_meetings.Visible)
            {
                dg_meetings.Show();
                btn_newMeeting.Show();
            }
            tbl_meetingsTableAdapter1.FillBy3(barocItDbDataSet4.tbl_meetings, selectedProjectId);
        }
        private void ShowApplications()
        {
            if(!dg_applications.Visible)
            {
                dg_applications.Show();
                btn_newApplication.Show();
            }
            tbl_applicationsTableAdapter.FillBy(dsApplications.tbl_applications, selectedProjectId);            
        }

        private void dg_projects_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged == DataGridViewElementStates.Selected) //&& e.Row.Index < 
            {
                selectedClientId = int.Parse((e.Row).Cells[1].Value.ToString().Trim());//p_id column
                selectedProjectId = int.Parse(e.Row.Cells[0].Value.ToString().Trim());

                ShowClientInfo();
                ShowMeetings();
                ShowApplications();
            }
        }

        private void tb_searchInProjects_KeyUp(object sender, KeyEventArgs e)
        {
            
            if(tb_searchInProjects.Text == "")
            {
                ((BindingSource)dg_projects.DataSource).RemoveFilter();
                btn_deleteSearch.Hide();
            }
            else
            {
                ((BindingSource)dg_projects.DataSource).Filter = String.Format("p_internalContactPerson like '*{0}*'", tb_searchInProjects.Text);
                btn_deleteSearch.Show();
            }
        }

        private void btn_deleteSearch_Click(object sender, EventArgs e)
        {
            tb_searchInProjects.Text = "";
            ((BindingSource)dg_projects.DataSource).RemoveFilter();
        }

        private void dg_projects_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = dg_projects.Columns[e.ColumnIndex].DataPropertyName;
            object value = dg_projects.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

            //if()
            DBHandler.UpdateSingleValue("tbl_projects", columnName, e.RowIndex, "p_id", value);
        }

        private void dg_meetings_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dg_meetings.Columns[e.ColumnIndex].Name == "m_date")
            {
                dtPicker.Location = dg_meetings.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Location;
                dtPicker.Width = dg_meetings.CurrentCell.GetContentBounds(e.RowIndex).Width;
                dtPicker.Visible = true;

                if(dg_meetings.CurrentCell.Value != DBNull.Value)
                {
                    dtPicker.Value = Convert.ToDateTime(dg_meetings.CurrentCell.Value);
                }
            }
        }

        private void dg_meetings_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = dg_meetings.Columns[e.ColumnIndex].DataPropertyName;
            object value = dg_meetings.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

            DBHandler.UpdateSingleValue("tbl_meetings", columnName, e.RowIndex, "m_meetingsId", value);
        }

        private void dg_applications_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = dg_applications.Columns[e.ColumnIndex].DataPropertyName;
            object value = dg_applications.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

            DBHandler.UpdateSingleValue("tbl_applications", columnName, e.RowIndex, "a_applicationId", value);
        }


    }
}
