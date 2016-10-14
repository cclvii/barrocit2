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
    public partial class MainForm : Form
    {
        private Role role;
        DateTimePicker oDateTimePicker = new DateTimePicker();
        public MainForm(Role role)
        {
            InitializeComponent();
            this.role = role;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Fill Datagrids
            //this.tbl_meetingsTableAdapter.Fill(this.barroc_IT_FinalDataSetMeetings.tbl_meetings);
            //this.tbl_projectsTableAdapter.Fill(this.barroc_IT_FinalDataSetProjectData.tbl_projects);
            //this.tbl_invoicesTableAdapter.Fill(this.barroc_IT_FinalDataSetFinancialData.tbl_invoices);
            //this.tbl_clientDataTableAdapterClientData.Fill(this.barroc_IT_FinalDataSetClientData.tbl_clientData);
            //this.tbl_clientDataTableAdapterClientData.Fill(this.barroc_IT_FinalDataSetClientData.tbl_clientData);

            //DisableDeleteButtons();
            //lbl_Time.Text = "Logged in at: " + DateTime.Now.ToString();
        }
        private void btn_loggout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void SaveClientData_Click(object sender, EventArgs e)
        {
            //ClientTable
            Validate();
            this.tblclientDataBindingSourceClientData.EndEdit();
            this.tbl_clientDataTableAdapterClientData.Update(barroc_IT_FinalDataSetClientData);
            bindingNavigatorAddNewItem.Enabled = true;
        }
        private void btn_saveProjectData_Click(object sender, EventArgs e)
        {
            //ProjectTable 
            Validate();
            this.tblprojectsBindingSource.EndEdit();
            this.tbl_projectsTableAdapter.Update(barroc_IT_FinalDataSetProjectData);
            bindingNavigatorAddNewItem2.Enabled = true;
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //FinanceTable + Tab Update.
            Validate();
            this.tblinvoicesBindingSource.EndEdit();
            this.tbl_invoicesTableAdapter.Update(barroc_IT_FinalDataSetFinancialData);
            bindingNavigatorAddNewItem1.Enabled = true;
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            //Meetings + Tab Update.

            Validate();
            this.tblmeetingsBindingSource.EndEdit();
            this.tbl_meetingsTableAdapter.Update(barroc_IT_FinalDataSetMeetings);
            bindingNavigatorAddNewItem3.Enabled = true;
        }
        public void RefreshCompanyNames()
        {
            DataGridViewCompanyName.Update();
            DataGridViewCompanyName.Refresh();
        }

        private void btn_RefreshList_Click(object sender, EventArgs e)
        {
            RefreshCompanyNames();
        }
        private void dataGridViewMeetings_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //colums datetime
            if (e.ColumnIndex == 4 || e.ColumnIndex == 3 || e.ColumnIndex == 2)
            {
                dataGridViewMeetings.Controls.Add(oDateTimePicker);
                oDateTimePicker.Format = DateTimePickerFormat.Custom;
                //draw rectangle for location and size of datetime
                Rectangle oRectangle = dataGridViewMeetings.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                oDateTimePicker.Size = new Size(oRectangle.Width, oRectangle.Height);
                oDateTimePicker.Location = new Point(oRectangle.X, oRectangle.Y);
                //Close on click to other cel, Take datetime to string and insert in to cell
                oDateTimePicker.CloseUp += new EventHandler(oDateTimePicker_CloseUp);
                oDateTimePicker.TextChanged += new EventHandler(dateTimePicker_OnTextChange);
                //make datetimepicker visible
                oDateTimePicker.Visible = true;
            }
            else
            {
                oDateTimePicker.Visible = false;
            }
        }
        void oDateTimePicker_CloseUp(object sender, EventArgs e)
        {
            // Hiding the control after use   

            oDateTimePicker.Visible = false;
        }
        private void dateTimePicker_OnTextChange(object sender, EventArgs e)
        {
            dataGridViewMeetings.CurrentCell.Value = oDateTimePicker.Text.ToString();
        }
        
        public void DisableDeleteButtons()
        { 
            //Not to be used feature, So disabeling it.
            bindingNavigatorDeleteItem.Enabled = false;
            bindingNavigatorDeleteItem1.Enabled = false;
            bindingNavigatorDeleteItem2.Enabled = false;
            bindingNavigatorDeleteItem3.Enabled = false;
        }
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (cnameDataGridViewTextBoxColumn1 != null)
            {
                bindingNavigatorAddNewItem.Enabled = false;
            }
        }
        private void bindingNavigatorAddNewItem1_Click(object sender, EventArgs e)
        {
            if (pprojectIDDataGridViewTextBoxColumn != null)
            {
                bindingNavigatorAddNewItem1.Enabled = false;
            }
        }

        private void bindingNavigatorAddNewItem2_Click(object sender, EventArgs e)
        {
            if (pnameDataGridViewTextBoxColumn != null)
            {
                bindingNavigatorAddNewItem2.Enabled = false;
            }
        }

        private void bindingNavigatorAddNewItem3_Click(object sender, EventArgs e)
        {
            if (pprojectIDDataGridViewTextBoxColumn2 != null)
            {
                bindingNavigatorAddNewItem3.Enabled = false;
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            string searchValue = tbx_SearchClientName.Text;

            if (tbx_SearchClientName.Text != null)
            {
                dataGridViewClientData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                tblclientDataBindingSourceClientData.Filter = string.Format("{0} = '{1}'", "c_name", searchValue);
            }
            if (tbx_SearchClientName.Text.Length == 0)
            {
                tblclientDataBindingSourceClientData.RemoveFilter();
                tblclientDataBindingSourceCompanyName.Filter = null;
            }

        }
    }
}

