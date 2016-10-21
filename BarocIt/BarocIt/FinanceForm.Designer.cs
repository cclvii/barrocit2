namespace BarocIt
{
    partial class FinanceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tblclientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsFinanceClient = new BarocIt.dsFinanceClient();
            this.tbl_clientsTableAdapter = new BarocIt.dsFinanceClientTableAdapters.tbl_clientsTableAdapter();
            this.btn_bkr = new System.Windows.Forms.Button();
            this.gb_bill = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dg_payments = new System.Windows.Forms.DataGridView();
            this.papaymentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.papaidDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.padeadlineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.papriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.papaidDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblpaymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPayments = new BarocIt.dsPayments();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.gb_projects = new System.Windows.Forms.GroupBox();
            this.dg_projects = new System.Windows.Forms.DataGridView();
            this.pprojectIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pprojectNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblsalesProjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsFinanceProjects = new BarocIt.dsFinanceProjects();
            this.gb_creditor = new System.Windows.Forms.GroupBox();
            this.label27 = new System.Windows.Forms.Label();
            this.tb_c_email = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_c_taxCode = new System.Windows.Forms.TextBox();
            this.tb_c_limit = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_c_initials = new System.Windows.Forms.TextBox();
            this.tb_c_contactPerson = new System.Windows.Forms.TextBox();
            this.tb_c_city2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_c_companyName = new System.Windows.Forms.TextBox();
            this.tb_c_zipcode1 = new System.Windows.Forms.TextBox();
            this.tb_c_zipcode2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_c_city1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_c_adress1 = new System.Windows.Forms.TextBox();
            this.tb_c_adress2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_c_phoneNumber = new System.Windows.Forms.TextBox();
            this.tb_c_fax = new System.Windows.Forms.TextBox();
            this.tb_c_creditBalance = new System.Windows.Forms.TextBox();
            this.tb_c_ledgerAccountNumber = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tb_c_numberOfInvoices = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tb_c_bankAccountNumber = new System.Windows.Forms.TextBox();
            this.tb_c_grossRevenue = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.gb_debtor = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_d_ledgerAccountNumber = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_d_limit = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_d_grossRevenue = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_d_numberOfInvoices = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_d_creditBalance = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_d_bankAccountNumber = new System.Windows.Forms.TextBox();
            this.gb_clients = new System.Windows.Forms.GroupBox();
            this.dg_clients = new System.Windows.Forms.DataGridView();
            this.cclientIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccompanyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadress1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.czipcode1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccity1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadress2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.czipcode2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccity2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccontactPersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinitialsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cphoneNumber1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cfaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barocItDbDataSet1 = new BarocIt.BarocItDbDataSet();
            this.tbl_paymentsTableAdapter = new BarocIt.dsPaymentsTableAdapters.tbl_paymentsTableAdapter();
            this.tbl_salesProjectsTableAdapter = new BarocIt.dsFinanceProjectsTableAdapters.tbl_salesProjectsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblclientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFinanceClient)).BeginInit();
            this.gb_bill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_payments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpaymentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPayments)).BeginInit();
            this.gb_projects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_projects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsalesProjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFinanceProjects)).BeginInit();
            this.gb_creditor.SuspendLayout();
            this.gb_debtor.SuspendLayout();
            this.gb_clients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_clients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barocItDbDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tblclientsBindingSource
            // 
            this.tblclientsBindingSource.DataMember = "tbl_clients";
            this.tblclientsBindingSource.DataSource = this.dsFinanceClient;
            // 
            // dsFinanceClient
            // 
            this.dsFinanceClient.DataSetName = "dsFinanceClient";
            this.dsFinanceClient.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_clientsTableAdapter
            // 
            this.tbl_clientsTableAdapter.ClearBeforeFill = true;
            // 
            // btn_bkr
            // 
            this.btn_bkr.Location = new System.Drawing.Point(1383, 223);
            this.btn_bkr.Name = "btn_bkr";
            this.btn_bkr.Size = new System.Drawing.Size(75, 23);
            this.btn_bkr.TabIndex = 4;
            this.btn_bkr.Text = "Check BKR";
            this.btn_bkr.UseVisualStyleBackColor = true;
            // 
            // gb_bill
            // 
            this.gb_bill.Controls.Add(this.textBox3);
            this.gb_bill.Controls.Add(this.textBox4);
            this.gb_bill.Controls.Add(this.textBox1);
            this.gb_bill.Controls.Add(this.dg_payments);
            this.gb_bill.Controls.Add(this.label31);
            this.gb_bill.Controls.Add(this.label30);
            this.gb_bill.Controls.Add(this.label29);
            this.gb_bill.Controls.Add(this.label28);
            this.gb_bill.Location = new System.Drawing.Point(1047, 259);
            this.gb_bill.Name = "gb_bill";
            this.gb_bill.Size = new System.Drawing.Size(304, 264);
            this.gb_bill.TabIndex = 5;
            this.gb_bill.TabStop = false;
            this.gb_bill.Text = "Bill";
            this.gb_bill.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(144, 65);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(110, 20);
            this.textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(144, 39);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(110, 20);
            this.textBox4.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 20);
            this.textBox1.TabIndex = 8;
            // 
            // dg_payments
            // 
            this.dg_payments.AutoGenerateColumns = false;
            this.dg_payments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_payments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.papaymentIdDataGridViewTextBoxColumn,
            this.papaidDataGridViewCheckBoxColumn,
            this.padeadlineDataGridViewTextBoxColumn,
            this.papriceDataGridViewTextBoxColumn,
            this.papaidDateDataGridViewTextBoxColumn});
            this.dg_payments.DataSource = this.tblpaymentsBindingSource;
            this.dg_payments.Location = new System.Drawing.Point(6, 144);
            this.dg_payments.Name = "dg_payments";
            this.dg_payments.Size = new System.Drawing.Size(278, 86);
            this.dg_payments.TabIndex = 7;
            // 
            // papaymentIdDataGridViewTextBoxColumn
            // 
            this.papaymentIdDataGridViewTextBoxColumn.DataPropertyName = "pa_paymentId";
            this.papaymentIdDataGridViewTextBoxColumn.HeaderText = "pa_paymentId";
            this.papaymentIdDataGridViewTextBoxColumn.Name = "papaymentIdDataGridViewTextBoxColumn";
            // 
            // papaidDataGridViewCheckBoxColumn
            // 
            this.papaidDataGridViewCheckBoxColumn.DataPropertyName = "pa_paid";
            this.papaidDataGridViewCheckBoxColumn.HeaderText = "pa_paid";
            this.papaidDataGridViewCheckBoxColumn.Name = "papaidDataGridViewCheckBoxColumn";
            // 
            // padeadlineDataGridViewTextBoxColumn
            // 
            this.padeadlineDataGridViewTextBoxColumn.DataPropertyName = "pa_deadline";
            this.padeadlineDataGridViewTextBoxColumn.HeaderText = "pa_deadline";
            this.padeadlineDataGridViewTextBoxColumn.Name = "padeadlineDataGridViewTextBoxColumn";
            // 
            // papriceDataGridViewTextBoxColumn
            // 
            this.papriceDataGridViewTextBoxColumn.DataPropertyName = "pa_price";
            this.papriceDataGridViewTextBoxColumn.HeaderText = "pa_price";
            this.papriceDataGridViewTextBoxColumn.Name = "papriceDataGridViewTextBoxColumn";
            // 
            // papaidDateDataGridViewTextBoxColumn
            // 
            this.papaidDateDataGridViewTextBoxColumn.DataPropertyName = "pa_paidDate";
            this.papaidDateDataGridViewTextBoxColumn.HeaderText = "pa_paidDate";
            this.papaidDateDataGridViewTextBoxColumn.Name = "papaidDateDataGridViewTextBoxColumn";
            // 
            // tblpaymentsBindingSource
            // 
            this.tblpaymentsBindingSource.DataMember = "tbl_payments";
            this.tblpaymentsBindingSource.DataSource = this.dsPayments;
            // 
            // dsPayments
            // 
            this.dsPayments.DataSetName = "dsPayments";
            this.dsPayments.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(45, 90);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(93, 13);
            this.label31.TabIndex = 6;
            this.label31.Text = "payment(s) price : ";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(25, 68);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(113, 13);
            this.label30.TabIndex = 5;
            this.label30.Text = "Number of payments : ";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(78, 42);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(60, 13);
            this.label29.TabIndex = 4;
            this.label29.Text = "Total cost :";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(63, 17);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(75, 13);
            this.label28.TabIndex = 3;
            this.label28.Text = "Invoice date : ";
            // 
            // gb_projects
            // 
            this.gb_projects.Controls.Add(this.dg_projects);
            this.gb_projects.Location = new System.Drawing.Point(785, 259);
            this.gb_projects.Name = "gb_projects";
            this.gb_projects.Size = new System.Drawing.Size(270, 229);
            this.gb_projects.TabIndex = 3;
            this.gb_projects.TabStop = false;
            this.gb_projects.Text = "Projects";
            // 
            // dg_projects
            // 
            this.dg_projects.AutoGenerateColumns = false;
            this.dg_projects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_projects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pprojectIdDataGridViewTextBoxColumn,
            this.pprojectNameDataGridViewTextBoxColumn});
            this.dg_projects.DataSource = this.tblsalesProjectsBindingSource;
            this.dg_projects.Location = new System.Drawing.Point(6, 16);
            this.dg_projects.Name = "dg_projects";
            this.dg_projects.Size = new System.Drawing.Size(244, 193);
            this.dg_projects.TabIndex = 0;
            this.dg_projects.Visible = false;
            this.dg_projects.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dg_projects_RowStateChanged);
            // 
            // pprojectIdDataGridViewTextBoxColumn
            // 
            this.pprojectIdDataGridViewTextBoxColumn.DataPropertyName = "p_projectId";
            this.pprojectIdDataGridViewTextBoxColumn.HeaderText = "p_projectId";
            this.pprojectIdDataGridViewTextBoxColumn.Name = "pprojectIdDataGridViewTextBoxColumn";
            this.pprojectIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pprojectNameDataGridViewTextBoxColumn
            // 
            this.pprojectNameDataGridViewTextBoxColumn.DataPropertyName = "p_projectName";
            this.pprojectNameDataGridViewTextBoxColumn.HeaderText = "p_projectName";
            this.pprojectNameDataGridViewTextBoxColumn.Name = "pprojectNameDataGridViewTextBoxColumn";
            // 
            // tblsalesProjectsBindingSource
            // 
            this.tblsalesProjectsBindingSource.DataMember = "tbl_salesProjects";
            this.tblsalesProjectsBindingSource.DataSource = this.dsFinanceProjects;
            // 
            // dsFinanceProjects
            // 
            this.dsFinanceProjects.DataSetName = "dsFinanceProjects";
            this.dsFinanceProjects.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gb_creditor
            // 
            this.gb_creditor.Controls.Add(this.label27);
            this.gb_creditor.Controls.Add(this.tb_c_email);
            this.gb_creditor.Controls.Add(this.label15);
            this.gb_creditor.Controls.Add(this.tb_c_taxCode);
            this.gb_creditor.Controls.Add(this.tb_c_limit);
            this.gb_creditor.Controls.Add(this.label26);
            this.gb_creditor.Controls.Add(this.label25);
            this.gb_creditor.Controls.Add(this.label24);
            this.gb_creditor.Controls.Add(this.label23);
            this.gb_creditor.Controls.Add(this.label16);
            this.gb_creditor.Controls.Add(this.tb_c_initials);
            this.gb_creditor.Controls.Add(this.tb_c_contactPerson);
            this.gb_creditor.Controls.Add(this.tb_c_city2);
            this.gb_creditor.Controls.Add(this.label3);
            this.gb_creditor.Controls.Add(this.tb_c_companyName);
            this.gb_creditor.Controls.Add(this.tb_c_zipcode1);
            this.gb_creditor.Controls.Add(this.tb_c_zipcode2);
            this.gb_creditor.Controls.Add(this.label4);
            this.gb_creditor.Controls.Add(this.label5);
            this.gb_creditor.Controls.Add(this.label6);
            this.gb_creditor.Controls.Add(this.tb_c_city1);
            this.gb_creditor.Controls.Add(this.label7);
            this.gb_creditor.Controls.Add(this.tb_c_adress1);
            this.gb_creditor.Controls.Add(this.tb_c_adress2);
            this.gb_creditor.Controls.Add(this.label14);
            this.gb_creditor.Controls.Add(this.label1);
            this.gb_creditor.Controls.Add(this.tb_c_phoneNumber);
            this.gb_creditor.Controls.Add(this.tb_c_fax);
            this.gb_creditor.Controls.Add(this.tb_c_creditBalance);
            this.gb_creditor.Controls.Add(this.tb_c_ledgerAccountNumber);
            this.gb_creditor.Controls.Add(this.label19);
            this.gb_creditor.Controls.Add(this.label20);
            this.gb_creditor.Controls.Add(this.label17);
            this.gb_creditor.Controls.Add(this.tb_c_numberOfInvoices);
            this.gb_creditor.Controls.Add(this.label22);
            this.gb_creditor.Controls.Add(this.tb_c_bankAccountNumber);
            this.gb_creditor.Controls.Add(this.tb_c_grossRevenue);
            this.gb_creditor.Controls.Add(this.label18);
            this.gb_creditor.Controls.Add(this.label21);
            this.gb_creditor.Location = new System.Drawing.Point(275, 254);
            this.gb_creditor.Name = "gb_creditor";
            this.gb_creditor.Size = new System.Drawing.Size(504, 220);
            this.gb_creditor.TabIndex = 2;
            this.gb_creditor.TabStop = false;
            this.gb_creditor.Text = "Creditor details";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(296, 44);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(32, 13);
            this.label27.TabIndex = 63;
            this.label27.Text = "Email";
            // 
            // tb_c_email
            // 
            this.tb_c_email.Location = new System.Drawing.Point(334, 41);
            this.tb_c_email.Name = "tb_c_email";
            this.tb_c_email.Size = new System.Drawing.Size(105, 20);
            this.tb_c_email.TabIndex = 62;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(287, 149);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 13);
            this.label15.TabIndex = 25;
            this.label15.Text = "Limit";
            // 
            // tb_c_taxCode
            // 
            this.tb_c_taxCode.Location = new System.Drawing.Point(334, 183);
            this.tb_c_taxCode.Name = "tb_c_taxCode";
            this.tb_c_taxCode.Size = new System.Drawing.Size(105, 20);
            this.tb_c_taxCode.TabIndex = 61;
            // 
            // tb_c_limit
            // 
            this.tb_c_limit.Location = new System.Drawing.Point(334, 145);
            this.tb_c_limit.Name = "tb_c_limit";
            this.tb_c_limit.Size = new System.Drawing.Size(105, 20);
            this.tb_c_limit.TabIndex = 24;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(55, 135);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(33, 13);
            this.label26.TabIndex = 59;
            this.label26.Text = "City 2";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(8, 154);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(80, 13);
            this.label25.TabIndex = 58;
            this.label25.Text = "Contact Person";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(52, 173);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(36, 13);
            this.label24.TabIndex = 57;
            this.label24.Text = "Initials";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(10, 192);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(78, 13);
            this.label23.TabIndex = 56;
            this.label23.Text = "Phone Number";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(304, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(24, 13);
            this.label16.TabIndex = 55;
            this.label16.Text = "Fax";
            // 
            // tb_c_initials
            // 
            this.tb_c_initials.Location = new System.Drawing.Point(94, 170);
            this.tb_c_initials.Name = "tb_c_initials";
            this.tb_c_initials.Size = new System.Drawing.Size(105, 20);
            this.tb_c_initials.TabIndex = 54;
            // 
            // tb_c_contactPerson
            // 
            this.tb_c_contactPerson.Location = new System.Drawing.Point(94, 151);
            this.tb_c_contactPerson.Name = "tb_c_contactPerson";
            this.tb_c_contactPerson.Size = new System.Drawing.Size(105, 20);
            this.tb_c_contactPerson.TabIndex = 53;
            // 
            // tb_c_city2
            // 
            this.tb_c_city2.Location = new System.Drawing.Point(94, 132);
            this.tb_c_city2.Name = "tb_c_city2";
            this.tb_c_city2.Size = new System.Drawing.Size(105, 20);
            this.tb_c_city2.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Zipcode 2";
            // 
            // tb_c_companyName
            // 
            this.tb_c_companyName.Location = new System.Drawing.Point(94, 18);
            this.tb_c_companyName.Name = "tb_c_companyName";
            this.tb_c_companyName.Size = new System.Drawing.Size(105, 20);
            this.tb_c_companyName.TabIndex = 38;
            // 
            // tb_c_zipcode1
            // 
            this.tb_c_zipcode1.Location = new System.Drawing.Point(94, 56);
            this.tb_c_zipcode1.Name = "tb_c_zipcode1";
            this.tb_c_zipcode1.Size = new System.Drawing.Size(105, 20);
            this.tb_c_zipcode1.TabIndex = 44;
            // 
            // tb_c_zipcode2
            // 
            this.tb_c_zipcode2.Location = new System.Drawing.Point(94, 113);
            this.tb_c_zipcode2.Name = "tb_c_zipcode2";
            this.tb_c_zipcode2.Size = new System.Drawing.Size(105, 20);
            this.tb_c_zipcode2.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Zipcode 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Adress 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Adress 2";
            // 
            // tb_c_city1
            // 
            this.tb_c_city1.Location = new System.Drawing.Point(94, 75);
            this.tb_c_city1.Name = "tb_c_city1";
            this.tb_c_city1.Size = new System.Drawing.Size(105, 20);
            this.tb_c_city1.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Company Name";
            // 
            // tb_c_adress1
            // 
            this.tb_c_adress1.Location = new System.Drawing.Point(94, 37);
            this.tb_c_adress1.Name = "tb_c_adress1";
            this.tb_c_adress1.Size = new System.Drawing.Size(105, 20);
            this.tb_c_adress1.TabIndex = 42;
            // 
            // tb_c_adress2
            // 
            this.tb_c_adress2.Location = new System.Drawing.Point(94, 94);
            this.tb_c_adress2.Name = "tb_c_adress2";
            this.tb_c_adress2.Size = new System.Drawing.Size(105, 20);
            this.tb_c_adress2.TabIndex = 48;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(60, 82);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 13);
            this.label14.TabIndex = 47;
            this.label14.Text = "City 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Tax Code";
            // 
            // tb_c_phoneNumber
            // 
            this.tb_c_phoneNumber.Location = new System.Drawing.Point(94, 189);
            this.tb_c_phoneNumber.Name = "tb_c_phoneNumber";
            this.tb_c_phoneNumber.Size = new System.Drawing.Size(105, 20);
            this.tb_c_phoneNumber.TabIndex = 24;
            // 
            // tb_c_fax
            // 
            this.tb_c_fax.Location = new System.Drawing.Point(334, 22);
            this.tb_c_fax.Name = "tb_c_fax";
            this.tb_c_fax.Size = new System.Drawing.Size(105, 20);
            this.tb_c_fax.TabIndex = 26;
            // 
            // tb_c_creditBalance
            // 
            this.tb_c_creditBalance.Location = new System.Drawing.Point(334, 88);
            this.tb_c_creditBalance.Name = "tb_c_creditBalance";
            this.tb_c_creditBalance.Size = new System.Drawing.Size(105, 20);
            this.tb_c_creditBalance.TabIndex = 30;
            // 
            // tb_c_ledgerAccountNumber
            // 
            this.tb_c_ledgerAccountNumber.Location = new System.Drawing.Point(334, 164);
            this.tb_c_ledgerAccountNumber.Name = "tb_c_ledgerAccountNumber";
            this.tb_c_ledgerAccountNumber.Size = new System.Drawing.Size(105, 20);
            this.tb_c_ledgerAccountNumber.TabIndex = 36;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(247, 129);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(81, 13);
            this.label19.TabIndex = 31;
            this.label19.Text = "Gross Revenue";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(229, 110);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(99, 13);
            this.label20.TabIndex = 29;
            this.label20.Text = "Number of Invoices";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(203, 168);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(129, 13);
            this.label17.TabIndex = 35;
            this.label17.Text = "Ledeger Account Number";
            // 
            // tb_c_numberOfInvoices
            // 
            this.tb_c_numberOfInvoices.Location = new System.Drawing.Point(334, 107);
            this.tb_c_numberOfInvoices.Name = "tb_c_numberOfInvoices";
            this.tb_c_numberOfInvoices.Size = new System.Drawing.Size(105, 20);
            this.tb_c_numberOfInvoices.TabIndex = 32;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(216, 72);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(112, 13);
            this.label22.TabIndex = 25;
            this.label22.Text = "Bank AccountNumber";
            // 
            // tb_c_bankAccountNumber
            // 
            this.tb_c_bankAccountNumber.Location = new System.Drawing.Point(334, 69);
            this.tb_c_bankAccountNumber.Name = "tb_c_bankAccountNumber";
            this.tb_c_bankAccountNumber.Size = new System.Drawing.Size(105, 20);
            this.tb_c_bankAccountNumber.TabIndex = 28;
            // 
            // tb_c_grossRevenue
            // 
            this.tb_c_grossRevenue.Location = new System.Drawing.Point(334, 126);
            this.tb_c_grossRevenue.Name = "tb_c_grossRevenue";
            this.tb_c_grossRevenue.Size = new System.Drawing.Size(105, 20);
            this.tb_c_grossRevenue.TabIndex = 34;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(300, 170);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(28, 13);
            this.label18.TabIndex = 33;
            this.label18.Text = "Limit";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(252, 91);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(76, 13);
            this.label21.TabIndex = 27;
            this.label21.Text = "Credit Balance";
            // 
            // gb_debtor
            // 
            this.gb_debtor.Controls.Add(this.label2);
            this.gb_debtor.Controls.Add(this.textBox7);
            this.gb_debtor.Controls.Add(this.label13);
            this.gb_debtor.Controls.Add(this.tb_d_ledgerAccountNumber);
            this.gb_debtor.Controls.Add(this.label12);
            this.gb_debtor.Controls.Add(this.tb_d_limit);
            this.gb_debtor.Controls.Add(this.label11);
            this.gb_debtor.Controls.Add(this.tb_d_grossRevenue);
            this.gb_debtor.Controls.Add(this.label10);
            this.gb_debtor.Controls.Add(this.tb_d_numberOfInvoices);
            this.gb_debtor.Controls.Add(this.label9);
            this.gb_debtor.Controls.Add(this.tb_d_creditBalance);
            this.gb_debtor.Controls.Add(this.label8);
            this.gb_debtor.Controls.Add(this.tb_d_bankAccountNumber);
            this.gb_debtor.Location = new System.Drawing.Point(12, 254);
            this.gb_debtor.Name = "gb_debtor";
            this.gb_debtor.Size = new System.Drawing.Size(257, 220);
            this.gb_debtor.TabIndex = 1;
            this.gb_debtor.TabStop = false;
            this.gb_debtor.Text = "Debtor Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tax Code";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(142, 148);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(105, 20);
            this.textBox7.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 132);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Ledger Account Number";
            // 
            // tb_d_ledgerAccountNumber
            // 
            this.tb_d_ledgerAccountNumber.Location = new System.Drawing.Point(142, 129);
            this.tb_d_ledgerAccountNumber.Name = "tb_d_ledgerAccountNumber";
            this.tb_d_ledgerAccountNumber.Size = new System.Drawing.Size(105, 20);
            this.tb_d_ledgerAccountNumber.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(108, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Limit";
            // 
            // tb_d_limit
            // 
            this.tb_d_limit.Location = new System.Drawing.Point(142, 110);
            this.tb_d_limit.Name = "tb_d_limit";
            this.tb_d_limit.Size = new System.Drawing.Size(105, 20);
            this.tb_d_limit.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(55, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Gross Revenue";
            // 
            // tb_d_grossRevenue
            // 
            this.tb_d_grossRevenue.Location = new System.Drawing.Point(142, 91);
            this.tb_d_grossRevenue.Name = "tb_d_grossRevenue";
            this.tb_d_grossRevenue.Size = new System.Drawing.Size(105, 20);
            this.tb_d_grossRevenue.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Number of Invoices";
            // 
            // tb_d_numberOfInvoices
            // 
            this.tb_d_numberOfInvoices.Location = new System.Drawing.Point(142, 72);
            this.tb_d_numberOfInvoices.Name = "tb_d_numberOfInvoices";
            this.tb_d_numberOfInvoices.Size = new System.Drawing.Size(105, 20);
            this.tb_d_numberOfInvoices.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(60, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Credit Balance";
            // 
            // tb_d_creditBalance
            // 
            this.tb_d_creditBalance.Location = new System.Drawing.Point(142, 53);
            this.tb_d_creditBalance.Name = "tb_d_creditBalance";
            this.tb_d_creditBalance.Size = new System.Drawing.Size(105, 20);
            this.tb_d_creditBalance.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Bank AccountNumber";
            // 
            // tb_d_bankAccountNumber
            // 
            this.tb_d_bankAccountNumber.Location = new System.Drawing.Point(142, 34);
            this.tb_d_bankAccountNumber.Name = "tb_d_bankAccountNumber";
            this.tb_d_bankAccountNumber.Size = new System.Drawing.Size(105, 20);
            this.tb_d_bankAccountNumber.TabIndex = 6;
            // 
            // gb_clients
            // 
            this.gb_clients.Controls.Add(this.dg_clients);
            this.gb_clients.Location = new System.Drawing.Point(12, 12);
            this.gb_clients.Name = "gb_clients";
            this.gb_clients.Size = new System.Drawing.Size(1365, 241);
            this.gb_clients.TabIndex = 0;
            this.gb_clients.TabStop = false;
            this.gb_clients.Text = "Clients";
            // 
            // dg_clients
            // 
            this.dg_clients.AutoGenerateColumns = false;
            this.dg_clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_clients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cclientIdDataGridViewTextBoxColumn,
            this.ccompanyNameDataGridViewTextBoxColumn,
            this.cadress1DataGridViewTextBoxColumn,
            this.czipcode1DataGridViewTextBoxColumn,
            this.ccity1DataGridViewTextBoxColumn,
            this.cadress2DataGridViewTextBoxColumn,
            this.czipcode2DataGridViewTextBoxColumn,
            this.ccity2DataGridViewTextBoxColumn,
            this.ccontactPersonDataGridViewTextBoxColumn,
            this.cinitialsDataGridViewTextBoxColumn,
            this.cphoneNumber1DataGridViewTextBoxColumn,
            this.cfaxDataGridViewTextBoxColumn,
            this.cemailDataGridViewTextBoxColumn});
            this.dg_clients.DataSource = this.tblclientsBindingSource;
            this.dg_clients.Location = new System.Drawing.Point(6, 20);
            this.dg_clients.Name = "dg_clients";
            this.dg_clients.Size = new System.Drawing.Size(1347, 214);
            this.dg_clients.TabIndex = 0;
            this.dg_clients.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dg_clients_RowStateChanged);
            // 
            // cclientIdDataGridViewTextBoxColumn
            // 
            this.cclientIdDataGridViewTextBoxColumn.DataPropertyName = "c_clientId";
            this.cclientIdDataGridViewTextBoxColumn.HeaderText = "c_clientId";
            this.cclientIdDataGridViewTextBoxColumn.Name = "cclientIdDataGridViewTextBoxColumn";
            this.cclientIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ccompanyNameDataGridViewTextBoxColumn
            // 
            this.ccompanyNameDataGridViewTextBoxColumn.DataPropertyName = "c_companyName";
            this.ccompanyNameDataGridViewTextBoxColumn.HeaderText = "c_companyName";
            this.ccompanyNameDataGridViewTextBoxColumn.Name = "ccompanyNameDataGridViewTextBoxColumn";
            // 
            // cadress1DataGridViewTextBoxColumn
            // 
            this.cadress1DataGridViewTextBoxColumn.DataPropertyName = "c_adress1";
            this.cadress1DataGridViewTextBoxColumn.HeaderText = "c_adress1";
            this.cadress1DataGridViewTextBoxColumn.Name = "cadress1DataGridViewTextBoxColumn";
            // 
            // czipcode1DataGridViewTextBoxColumn
            // 
            this.czipcode1DataGridViewTextBoxColumn.DataPropertyName = "c_zipcode1";
            this.czipcode1DataGridViewTextBoxColumn.HeaderText = "c_zipcode1";
            this.czipcode1DataGridViewTextBoxColumn.Name = "czipcode1DataGridViewTextBoxColumn";
            // 
            // ccity1DataGridViewTextBoxColumn
            // 
            this.ccity1DataGridViewTextBoxColumn.DataPropertyName = "c_city1";
            this.ccity1DataGridViewTextBoxColumn.HeaderText = "c_city1";
            this.ccity1DataGridViewTextBoxColumn.Name = "ccity1DataGridViewTextBoxColumn";
            // 
            // cadress2DataGridViewTextBoxColumn
            // 
            this.cadress2DataGridViewTextBoxColumn.DataPropertyName = "c_adress2";
            this.cadress2DataGridViewTextBoxColumn.HeaderText = "c_adress2";
            this.cadress2DataGridViewTextBoxColumn.Name = "cadress2DataGridViewTextBoxColumn";
            // 
            // czipcode2DataGridViewTextBoxColumn
            // 
            this.czipcode2DataGridViewTextBoxColumn.DataPropertyName = "c_zipcode2";
            this.czipcode2DataGridViewTextBoxColumn.HeaderText = "c_zipcode2";
            this.czipcode2DataGridViewTextBoxColumn.Name = "czipcode2DataGridViewTextBoxColumn";
            // 
            // ccity2DataGridViewTextBoxColumn
            // 
            this.ccity2DataGridViewTextBoxColumn.DataPropertyName = "c_city2";
            this.ccity2DataGridViewTextBoxColumn.HeaderText = "c_city2";
            this.ccity2DataGridViewTextBoxColumn.Name = "ccity2DataGridViewTextBoxColumn";
            // 
            // ccontactPersonDataGridViewTextBoxColumn
            // 
            this.ccontactPersonDataGridViewTextBoxColumn.DataPropertyName = "c_contactPerson";
            this.ccontactPersonDataGridViewTextBoxColumn.HeaderText = "c_contactPerson";
            this.ccontactPersonDataGridViewTextBoxColumn.Name = "ccontactPersonDataGridViewTextBoxColumn";
            // 
            // cinitialsDataGridViewTextBoxColumn
            // 
            this.cinitialsDataGridViewTextBoxColumn.DataPropertyName = "c_initials";
            this.cinitialsDataGridViewTextBoxColumn.HeaderText = "c_initials";
            this.cinitialsDataGridViewTextBoxColumn.Name = "cinitialsDataGridViewTextBoxColumn";
            // 
            // cphoneNumber1DataGridViewTextBoxColumn
            // 
            this.cphoneNumber1DataGridViewTextBoxColumn.DataPropertyName = "c_phoneNumber1";
            this.cphoneNumber1DataGridViewTextBoxColumn.HeaderText = "c_phoneNumber1";
            this.cphoneNumber1DataGridViewTextBoxColumn.Name = "cphoneNumber1DataGridViewTextBoxColumn";
            // 
            // cfaxDataGridViewTextBoxColumn
            // 
            this.cfaxDataGridViewTextBoxColumn.DataPropertyName = "c_fax";
            this.cfaxDataGridViewTextBoxColumn.HeaderText = "c_fax";
            this.cfaxDataGridViewTextBoxColumn.Name = "cfaxDataGridViewTextBoxColumn";
            // 
            // cemailDataGridViewTextBoxColumn
            // 
            this.cemailDataGridViewTextBoxColumn.DataPropertyName = "c_email";
            this.cemailDataGridViewTextBoxColumn.HeaderText = "c_email";
            this.cemailDataGridViewTextBoxColumn.Name = "cemailDataGridViewTextBoxColumn";
            // 
            // barocItDbDataSet1
            // 
            this.barocItDbDataSet1.DataSetName = "BarocItDbDataSet";
            this.barocItDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_paymentsTableAdapter
            // 
            this.tbl_paymentsTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_salesProjectsTableAdapter
            // 
            this.tbl_salesProjectsTableAdapter.ClearBeforeFill = true;
            // 
            // FinanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1458, 643);
            this.Controls.Add(this.btn_bkr);
            this.Controls.Add(this.gb_bill);
            this.Controls.Add(this.gb_projects);
            this.Controls.Add(this.gb_creditor);
            this.Controls.Add(this.gb_debtor);
            this.Controls.Add(this.gb_clients);
            this.Name = "FinanceForm";
            this.Text = "BarrocIt Finance";
            this.Load += new System.EventHandler(this.FinanceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblclientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFinanceClient)).EndInit();
            this.gb_bill.ResumeLayout(false);
            this.gb_bill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_payments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpaymentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPayments)).EndInit();
            this.gb_projects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_projects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsalesProjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFinanceProjects)).EndInit();
            this.gb_creditor.ResumeLayout(false);
            this.gb_creditor.PerformLayout();
            this.gb_debtor.ResumeLayout(false);
            this.gb_debtor.PerformLayout();
            this.gb_clients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_clients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barocItDbDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_clients;
        private System.Windows.Forms.DataGridView dg_clients;
        private dsFinanceClient dsFinanceClient;
        private System.Windows.Forms.BindingSource tblclientsBindingSource;
        private dsFinanceClientTableAdapters.tbl_clientsTableAdapter tbl_clientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cclientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccompanyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadress1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn czipcode1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccity1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadress2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn czipcode2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccity2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccontactPersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinitialsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cphoneNumber1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cfaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox gb_debtor;
        private System.Windows.Forms.GroupBox gb_creditor;
        private System.Windows.Forms.GroupBox gb_projects;
        private System.Windows.Forms.Button btn_bkr;
        private System.Windows.Forms.GroupBox gb_bill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_d_ledgerAccountNumber;
        private System.Windows.Forms.TextBox tb_d_limit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_d_grossRevenue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_d_numberOfInvoices;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_d_creditBalance;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_d_bankAccountNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_c_companyName;
        private System.Windows.Forms.TextBox tb_c_zipcode1;
        private System.Windows.Forms.TextBox tb_c_zipcode2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_c_city1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_c_adress1;
        private System.Windows.Forms.TextBox tb_c_adress2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_c_phoneNumber;
        private System.Windows.Forms.TextBox tb_c_fax;
        private System.Windows.Forms.TextBox tb_c_creditBalance;
        private System.Windows.Forms.TextBox tb_c_ledgerAccountNumber;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tb_c_numberOfInvoices;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tb_c_bankAccountNumber;
        private System.Windows.Forms.TextBox tb_c_grossRevenue;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tb_c_taxCode;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tb_c_initials;
        private System.Windows.Forms.TextBox tb_c_contactPerson;
        private System.Windows.Forms.TextBox tb_c_city2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tb_c_limit;
        private System.Windows.Forms.Label label12;
        private BarocItDbDataSet barocItDbDataSet1;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox tb_c_email;
        private System.Windows.Forms.DataGridView dg_projects;
        private dsFinanceProjects dsFinanceProjects;
        private System.Windows.Forms.BindingSource tblsalesProjectsBindingSource;
        private dsFinanceProjectsTableAdapters.tbl_salesProjectsTableAdapter tbl_salesProjectsTableAdapter;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.DataGridViewTextBoxColumn pprojectIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pprojectNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dg_payments;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox1;
        private dsPayments dsPayments;
        private System.Windows.Forms.BindingSource tblpaymentsBindingSource;
        private dsPaymentsTableAdapters.tbl_paymentsTableAdapter tbl_paymentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn papaymentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn papaidDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn padeadlineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn papriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn papaidDateDataGridViewTextBoxColumn;
    }
}