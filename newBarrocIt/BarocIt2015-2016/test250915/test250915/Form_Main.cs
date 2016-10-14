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
    public partial class Form_Main : Form
    {
        private Form_Add formAdd;
        private Form_Edit formEdit;
        private int selectedCustomerRow;
        private bool firstTimeSelectClient;

        public Form_Main(Role role)
        {
            firstTimeSelectClient = true;
            InitializeComponent();
            DatabaseManager.Connect();
            ShowCustomersTable();
        }

        private void ShowCustomersTable()
        {
            foreach(var v in DatabaseManager.customersTable.rows)
            {
                dataGridView_Customers.Rows.Add(v.datas);
            }

        }

        private void ShowProjectsTable()
        {
            foreach(var v in DatabaseManager.projectsTable.rows)
            {
                if(int.Parse(v.datas[2].ToString()) == selectedCustomerRow)
                {
                    dataGridView_Projects.Rows.Add(v.datas);
                }
            }
        }

        //private void InitAddButton()
        //{
        //    this.button_addCustomers.Location = new Point(300, 300);
        //    this.button_addCustomers.Name = "button_addCustomer";
        //    this.button_addCustomers.Size = new Size(75, 23);
        //    this.button_addCustomers.Text = "Add";
        //    this.button_addCustomers.UseVisualStyleBackColor = true;
        //    this.button_addCustomers.Click += this.button_addCustomer_Click;
        //}

        private void button_addCustomer_Click(object sender, EventArgs e)
        {
            formAdd = new Form_Add(DatabaseManager.customersTable, this);
            formAdd.Show();
        }

        private void button_addProject_Click(object sender, EventArgs e)
        {
            formAdd = new Form_Add(DatabaseManager.projectsTable, this);
            formAdd.Show();
        }

        private void button_EditCustomer_Click(object sender, EventArgs e)
        {
            formEdit = new Form_Edit(DatabaseManager.customersTable, this, selectedCustomerRow);
            formEdit.Show();
        }

        public void RefreshCustomersTable()
        {
            MessageBox.Show("Refreshing customers table...");

            dataGridView_Customers.Rows.Clear();
            dataGridView_Customers.Refresh();
            DatabaseManager.FillTableCustomers();

            ShowCustomersTable();
        }

        public void RefreshProjectsTable()
        {
            MessageBox.Show("Refreshing projects table...");

            dataGridView_Projects.Rows.Clear();
            dataGridView_Projects.Refresh();
            DatabaseManager.FillTableProjects();

            ShowProjectsTable();
        }

        public void RefreshAllTable()
        {
            RefreshCustomersTable();
            RefreshProjectsTable();
        }

        public void AddRow(Table table, Row row)
        {
            if(DatabaseManager.InsertRow(table, row))
            {
                formAdd.Hide();
                formAdd = null;
                RefreshAllTable();
            }
        }

        //private void dataGridView_Customers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    //selectedRow = e.RowIndex + 1;
        //}


        private void dataGridView_Customers_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedCustomerRow = e.RowIndex + 1;
            RefreshProjectsTable();

            if (firstTimeSelectClient)
            {
                dataGridView_Projects.Show();
                button_addProject.Enabled = true;
                firstTimeSelectClient = false;
                button_EditCustomers.Enabled = true;
            }    
        }

    }
}
