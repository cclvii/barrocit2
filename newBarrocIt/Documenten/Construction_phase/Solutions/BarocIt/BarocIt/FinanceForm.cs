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
    public partial class FinanceForm : MainForm
    {
        private int selectedClientId;

        public FinanceForm()
        {
            InitializeComponent();
        }

        private void FinanceForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsFinanceProjects.tbl_salesProjects' table. You can move, or remove it, as needed.
            this.tbl_salesProjectsTableAdapter.Fill(this.dsFinanceProjects.tbl_salesProjects);
            // TODO: This line of code loads data into the 'dsFinanceClient.tbl_clients' table. You can move, or remove it, as needed.
            this.tbl_clientsTableAdapter.Fill(this.dsFinanceClient.tbl_clients);

            ShowCreditor();
        }
        private void InitDebtor()
        {

        }

        private void ShowDebtor(int clientId)
        {
            TextBox[] debtorBoxs = new TextBox[7]{tb_d_bankAccountNumber, tb_d_creditBalance, tb_d_numberOfInvoices, tb_d_grossRevenue, tb_d_limit, tb_d_ledgerAccountNumber, textBox7};
            object[] datas = DBHandler.DebtorDatasToStringArray(clientId);

            if (datas != null)
            {
                for (int i = 0; i < datas.Count(); i++)
                {
                    if (datas[i] != null)
                        debtorBoxs[i].Text = datas[i].ToString();
                }
            }
            else
            {
                for (int i = 0; i < debtorBoxs.Count(); i++)
                    debtorBoxs[i].ResetText();
            }
        }

        private void ShowCreditor()
        {
            TextBox[] creditorBoxs = new TextBox[19] { tb_c_companyName, tb_c_adress1, tb_c_zipcode1, tb_c_city1, tb_c_adress2, tb_c_zipcode2, tb_c_city2, tb_c_contactPerson, tb_c_initials, tb_c_phoneNumber, tb_c_fax, tb_c_email, tb_c_bankAccountNumber, tb_c_creditBalance, tb_c_numberOfInvoices, tb_c_grossRevenue, tb_c_limit, tb_c_ledgerAccountNumber, tb_c_taxCode };
            object[] datas = DBHandler.CreditorDatasToArray();

            if (datas != null)
            {
                for (int i = 0; i < datas.Count(); i++)
                {
                    if (datas[i] != null)
                        creditorBoxs[i].Text = datas[i].ToString();
                }
            }
            else
            {
                for (int i = 0; i < creditorBoxs.Count(); i++)
                    creditorBoxs[i].ResetText();
            }
        }

        private void dg_clients_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged == DataGridViewElementStates.Selected) //&& e.Row.Index < 
            {
                selectedClientId = int.Parse((e.Row).Cells[0].Value.ToString().Trim());


                ShowDebtor(selectedClientId);

            }
        }

    }
}
