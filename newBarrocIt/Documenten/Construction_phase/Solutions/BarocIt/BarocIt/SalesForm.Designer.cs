namespace BarocIt
{
    partial class SalesForm
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
            this.ds_notPaidClients = new BarocIt.ds_notPaidClients();
            this.tbl_clientsTableAdapter = new BarocIt.ds_notPaidClientsTableAdapters.tbl_clientsTableAdapter();
            this.gb_notPaidClients = new System.Windows.Forms.GroupBox();
            this.dg_notPaidClients = new System.Windows.Forms.DataGridView();
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
            this.tblclientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.barocItDbDataSet5 = new BarocIt.BarocItDbDataSet5();
            this.gb_allClients = new System.Windows.Forms.GroupBox();
            this.dg_allClients = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_clientInfos = new System.Windows.Forms.GroupBox();
            this.lbl_clientDetailsInactive = new System.Windows.Forms.Label();
            this.tbl_clientsTableAdapter1 = new BarocIt.BarocItDbDataSet5TableAdapters.tbl_clientsTableAdapter();
            this.btn_newClient = new System.Windows.Forms.Button();
            this.gb_projects = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cclientIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pprojectIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pquotationIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plastAppointmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plastActionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_nextAppointment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnextActionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblsalesProjectsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsSalesProjects = new BarocIt.dsSalesProjects();
            this.label1 = new System.Windows.Forms.Label();
            this.tblsalesProjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_salesProjects = new BarocIt.ds_salesProjects();
            this.tbl_salesProjectsTableAdapter = new BarocIt.ds_salesProjectsTableAdapters.tbl_salesProjectsTableAdapter();
            this.tb_companyName = new System.Windows.Forms.TextBox();
            this.tb_adress1 = new System.Windows.Forms.TextBox();
            this.tb_zipcode1 = new System.Windows.Forms.TextBox();
            this.tb_city1 = new System.Windows.Forms.TextBox();
            this.tb_adress2 = new System.Windows.Forms.TextBox();
            this.tb_zipcode2 = new System.Windows.Forms.TextBox();
            this.tb_city2 = new System.Windows.Forms.TextBox();
            this.tb_contactPerson = new System.Windows.Forms.TextBox();
            this.tb_initials = new System.Windows.Forms.TextBox();
            this.tb_phoneNumber1 = new System.Windows.Forms.TextBox();
            this.tb_fax = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.lbl_companyName = new System.Windows.Forms.Label();
            this.lbl_newAdress1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.gb_newClient = new System.Windows.Forms.GroupBox();
            this.tb_phoneNumber2 = new System.Windows.Forms.TextBox();
            this.btn_cancelNewClient = new System.Windows.Forms.Button();
            this.btn_addNewClient = new System.Windows.Forms.Button();
            this.gb_newProject = new System.Windows.Forms.GroupBox();
            this.dtp_nextAppointment = new System.Windows.Forms.DateTimePicker();
            this.dtp_lastAppointment = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_quotationId = new System.Windows.Forms.Label();
            this.tb_nextAction = new System.Windows.Forms.TextBox();
            this.tb_newQuotationId = new System.Windows.Forms.TextBox();
            this.tb_lastAction = new System.Windows.Forms.TextBox();
            this.btn_cancelNewProject = new System.Windows.Forms.Button();
            this.btn_addNewProject = new System.Windows.Forms.Button();
            this.btn_newProject = new System.Windows.Forms.Button();
            this.tbl_salesProjectsTableAdapter1 = new BarocIt.dsSalesProjectsTableAdapters.tbl_salesProjectsTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblclientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_notPaidClients)).BeginInit();
            this.gb_notPaidClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_notPaidClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblclientsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barocItDbDataSet5)).BeginInit();
            this.gb_allClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_allClients)).BeginInit();
            this.gb_clientInfos.SuspendLayout();
            this.gb_projects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsalesProjectsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSalesProjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsalesProjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_salesProjects)).BeginInit();
            this.gb_newClient.SuspendLayout();
            this.gb_newProject.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblclientsBindingSource
            // 
            this.tblclientsBindingSource.DataMember = "tbl_clients";
            this.tblclientsBindingSource.DataSource = this.ds_notPaidClients;
            // 
            // ds_notPaidClients
            // 
            this.ds_notPaidClients.DataSetName = "ds_notPaidClients";
            this.ds_notPaidClients.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_clientsTableAdapter
            // 
            this.tbl_clientsTableAdapter.ClearBeforeFill = true;
            // 
            // gb_notPaidClients
            // 
            this.gb_notPaidClients.Controls.Add(this.dg_notPaidClients);
            this.gb_notPaidClients.Location = new System.Drawing.Point(12, 12);
            this.gb_notPaidClients.Name = "gb_notPaidClients";
            this.gb_notPaidClients.Size = new System.Drawing.Size(1363, 152);
            this.gb_notPaidClients.TabIndex = 0;
            this.gb_notPaidClients.TabStop = false;
            this.gb_notPaidClients.Text = "Not Paid Clients";
            // 
            // dg_notPaidClients
            // 
            this.dg_notPaidClients.AutoGenerateColumns = false;
            this.dg_notPaidClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_notPaidClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dg_notPaidClients.DataSource = this.tblclientsBindingSource1;
            this.dg_notPaidClients.Location = new System.Drawing.Point(6, 19);
            this.dg_notPaidClients.Name = "dg_notPaidClients";
            this.dg_notPaidClients.Size = new System.Drawing.Size(1346, 127);
            this.dg_notPaidClients.TabIndex = 1;
            // 
            // cclientIdDataGridViewTextBoxColumn
            // 
            this.cclientIdDataGridViewTextBoxColumn.DataPropertyName = "c_clientId";
            this.cclientIdDataGridViewTextBoxColumn.HeaderText = "c_clientId";
            this.cclientIdDataGridViewTextBoxColumn.Name = "cclientIdDataGridViewTextBoxColumn";
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
            // tblclientsBindingSource1
            // 
            this.tblclientsBindingSource1.DataMember = "tbl_clients";
            this.tblclientsBindingSource1.DataSource = this.barocItDbDataSet5;
            // 
            // barocItDbDataSet5
            // 
            this.barocItDbDataSet5.DataSetName = "BarocItDbDataSet5";
            this.barocItDbDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gb_allClients
            // 
            this.gb_allClients.Controls.Add(this.dg_allClients);
            this.gb_allClients.Location = new System.Drawing.Point(12, 170);
            this.gb_allClients.Name = "gb_allClients";
            this.gb_allClients.Size = new System.Drawing.Size(1363, 341);
            this.gb_allClients.TabIndex = 2;
            this.gb_allClients.TabStop = false;
            this.gb_allClients.Text = "All Clients";
            // 
            // dg_allClients
            // 
            this.dg_allClients.AutoGenerateColumns = false;
            this.dg_allClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_allClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.dg_allClients.DataSource = this.tblclientsBindingSource1;
            this.dg_allClients.Location = new System.Drawing.Point(11, 19);
            this.dg_allClients.Name = "dg_allClients";
            this.dg_allClients.Size = new System.Drawing.Size(1346, 316);
            this.dg_allClients.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "c_clientId";
            this.dataGridViewTextBoxColumn1.HeaderText = "c_clientId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "c_companyName";
            this.dataGridViewTextBoxColumn2.HeaderText = "c_companyName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "c_adress1";
            this.dataGridViewTextBoxColumn3.HeaderText = "c_adress1";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "c_zipcode1";
            this.dataGridViewTextBoxColumn4.HeaderText = "c_zipcode1";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "c_city1";
            this.dataGridViewTextBoxColumn5.HeaderText = "c_city1";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "c_adress2";
            this.dataGridViewTextBoxColumn6.HeaderText = "c_adress2";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "c_zipcode2";
            this.dataGridViewTextBoxColumn7.HeaderText = "c_zipcode2";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "c_city2";
            this.dataGridViewTextBoxColumn8.HeaderText = "c_city2";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "c_contactPerson";
            this.dataGridViewTextBoxColumn9.HeaderText = "c_contactPerson";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "c_initials";
            this.dataGridViewTextBoxColumn10.HeaderText = "c_initials";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "c_phoneNumber1";
            this.dataGridViewTextBoxColumn11.HeaderText = "c_phoneNumber1";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "c_fax";
            this.dataGridViewTextBoxColumn13.HeaderText = "c_fax";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "c_email";
            this.dataGridViewTextBoxColumn14.HeaderText = "c_email";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // gb_clientInfos
            // 
            this.gb_clientInfos.Controls.Add(this.label2);
            this.gb_clientInfos.Controls.Add(this.lbl_clientDetailsInactive);
            this.gb_clientInfos.Location = new System.Drawing.Point(12, 540);
            this.gb_clientInfos.Name = "gb_clientInfos";
            this.gb_clientInfos.Size = new System.Drawing.Size(210, 176);
            this.gb_clientInfos.TabIndex = 3;
            this.gb_clientInfos.TabStop = false;
            this.gb_clientInfos.Text = "Client details";
            // 
            // lbl_clientDetailsInactive
            // 
            this.lbl_clientDetailsInactive.AutoSize = true;
            this.lbl_clientDetailsInactive.Location = new System.Drawing.Point(23, 83);
            this.lbl_clientDetailsInactive.Name = "lbl_clientDetailsInactive";
            this.lbl_clientDetailsInactive.Size = new System.Drawing.Size(155, 13);
            this.lbl_clientDetailsInactive.TabIndex = 0;
            this.lbl_clientDetailsInactive.Text = "Select a client to see his details";
            // 
            // tbl_clientsTableAdapter1
            // 
            this.tbl_clientsTableAdapter1.ClearBeforeFill = true;
            // 
            // btn_newClient
            // 
            this.btn_newClient.Location = new System.Drawing.Point(1282, 517);
            this.btn_newClient.Name = "btn_newClient";
            this.btn_newClient.Size = new System.Drawing.Size(93, 23);
            this.btn_newClient.TabIndex = 4;
            this.btn_newClient.Text = "Add New Client";
            this.btn_newClient.UseVisualStyleBackColor = true;
            this.btn_newClient.Click += new System.EventHandler(this.btn_newClient_Click);
            // 
            // gb_projects
            // 
            this.gb_projects.Controls.Add(this.dataGridView1);
            this.gb_projects.Controls.Add(this.label1);
            this.gb_projects.Location = new System.Drawing.Point(228, 540);
            this.gb_projects.Name = "gb_projects";
            this.gb_projects.Size = new System.Drawing.Size(840, 176);
            this.gb_projects.TabIndex = 4;
            this.gb_projects.TabStop = false;
            this.gb_projects.Text = "Projects";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cclientIDDataGridViewTextBoxColumn1,
            this.pprojectIdDataGridViewTextBoxColumn,
            this.pquotationIdDataGridViewTextBoxColumn,
            this.plastAppointmentDataGridViewTextBoxColumn,
            this.plastActionDataGridViewTextBoxColumn,
            this.p_nextAppointment,
            this.pnextActionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblsalesProjectsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(828, 148);
            this.dataGridView1.TabIndex = 1;
            // 
            // cclientIDDataGridViewTextBoxColumn1
            // 
            this.cclientIDDataGridViewTextBoxColumn1.DataPropertyName = "c_clientID";
            this.cclientIDDataGridViewTextBoxColumn1.HeaderText = "c_clientID";
            this.cclientIDDataGridViewTextBoxColumn1.Name = "cclientIDDataGridViewTextBoxColumn1";
            // 
            // pprojectIdDataGridViewTextBoxColumn
            // 
            this.pprojectIdDataGridViewTextBoxColumn.DataPropertyName = "p_projectId";
            this.pprojectIdDataGridViewTextBoxColumn.HeaderText = "p_projectId";
            this.pprojectIdDataGridViewTextBoxColumn.Name = "pprojectIdDataGridViewTextBoxColumn";
            this.pprojectIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pquotationIdDataGridViewTextBoxColumn
            // 
            this.pquotationIdDataGridViewTextBoxColumn.DataPropertyName = "p_quotationId";
            this.pquotationIdDataGridViewTextBoxColumn.HeaderText = "p_quotationId";
            this.pquotationIdDataGridViewTextBoxColumn.Name = "pquotationIdDataGridViewTextBoxColumn";
            // 
            // plastAppointmentDataGridViewTextBoxColumn
            // 
            this.plastAppointmentDataGridViewTextBoxColumn.DataPropertyName = "p_lastAppointment";
            this.plastAppointmentDataGridViewTextBoxColumn.HeaderText = "p_lastAppointment";
            this.plastAppointmentDataGridViewTextBoxColumn.Name = "plastAppointmentDataGridViewTextBoxColumn";
            // 
            // plastActionDataGridViewTextBoxColumn
            // 
            this.plastActionDataGridViewTextBoxColumn.DataPropertyName = "p_lastAction";
            this.plastActionDataGridViewTextBoxColumn.HeaderText = "p_lastAction";
            this.plastActionDataGridViewTextBoxColumn.Name = "plastActionDataGridViewTextBoxColumn";
            // 
            // p_nextAppointment
            // 
            this.p_nextAppointment.DataPropertyName = "p_nextAppointment";
            this.p_nextAppointment.HeaderText = "p_nextAppointment";
            this.p_nextAppointment.Name = "p_nextAppointment";
            // 
            // pnextActionDataGridViewTextBoxColumn
            // 
            this.pnextActionDataGridViewTextBoxColumn.DataPropertyName = "p_nextAction";
            this.pnextActionDataGridViewTextBoxColumn.HeaderText = "p_nextAction";
            this.pnextActionDataGridViewTextBoxColumn.Name = "pnextActionDataGridViewTextBoxColumn";
            // 
            // tblsalesProjectsBindingSource1
            // 
            this.tblsalesProjectsBindingSource1.DataMember = "tbl_salesProjects";
            this.tblsalesProjectsBindingSource1.DataSource = this.dsSalesProjects;
            // 
            // dsSalesProjects
            // 
            this.dsSalesProjects.DataSetName = "dsSalesProjects";
            this.dsSalesProjects.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a client to see his projects";
            // 
            // tblsalesProjectsBindingSource
            // 
            this.tblsalesProjectsBindingSource.DataMember = "tbl_salesProjects";
            this.tblsalesProjectsBindingSource.DataSource = this.ds_salesProjects;
            // 
            // ds_salesProjects
            // 
            this.ds_salesProjects.DataSetName = "ds_salesProjects";
            this.ds_salesProjects.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_salesProjectsTableAdapter
            // 
            this.tbl_salesProjectsTableAdapter.ClearBeforeFill = true;
            // 
            // tb_companyName
            // 
            this.tb_companyName.Location = new System.Drawing.Point(4, 28);
            this.tb_companyName.Name = "tb_companyName";
            this.tb_companyName.Size = new System.Drawing.Size(100, 20);
            this.tb_companyName.TabIndex = 5;
            // 
            // tb_adress1
            // 
            this.tb_adress1.Location = new System.Drawing.Point(110, 28);
            this.tb_adress1.Name = "tb_adress1";
            this.tb_adress1.Size = new System.Drawing.Size(100, 20);
            this.tb_adress1.TabIndex = 6;
            // 
            // tb_zipcode1
            // 
            this.tb_zipcode1.Location = new System.Drawing.Point(216, 28);
            this.tb_zipcode1.Name = "tb_zipcode1";
            this.tb_zipcode1.Size = new System.Drawing.Size(100, 20);
            this.tb_zipcode1.TabIndex = 7;
            // 
            // tb_city1
            // 
            this.tb_city1.Location = new System.Drawing.Point(322, 28);
            this.tb_city1.Name = "tb_city1";
            this.tb_city1.Size = new System.Drawing.Size(100, 20);
            this.tb_city1.TabIndex = 8;
            // 
            // tb_adress2
            // 
            this.tb_adress2.Location = new System.Drawing.Point(428, 28);
            this.tb_adress2.Name = "tb_adress2";
            this.tb_adress2.Size = new System.Drawing.Size(100, 20);
            this.tb_adress2.TabIndex = 9;
            // 
            // tb_zipcode2
            // 
            this.tb_zipcode2.Location = new System.Drawing.Point(534, 28);
            this.tb_zipcode2.Name = "tb_zipcode2";
            this.tb_zipcode2.Size = new System.Drawing.Size(100, 20);
            this.tb_zipcode2.TabIndex = 10;
            // 
            // tb_city2
            // 
            this.tb_city2.Location = new System.Drawing.Point(640, 28);
            this.tb_city2.Name = "tb_city2";
            this.tb_city2.Size = new System.Drawing.Size(100, 20);
            this.tb_city2.TabIndex = 11;
            // 
            // tb_contactPerson
            // 
            this.tb_contactPerson.Location = new System.Drawing.Point(746, 28);
            this.tb_contactPerson.Name = "tb_contactPerson";
            this.tb_contactPerson.Size = new System.Drawing.Size(100, 20);
            this.tb_contactPerson.TabIndex = 12;
            // 
            // tb_initials
            // 
            this.tb_initials.Location = new System.Drawing.Point(852, 28);
            this.tb_initials.Name = "tb_initials";
            this.tb_initials.Size = new System.Drawing.Size(100, 20);
            this.tb_initials.TabIndex = 13;
            // 
            // tb_phoneNumber1
            // 
            this.tb_phoneNumber1.Location = new System.Drawing.Point(958, 28);
            this.tb_phoneNumber1.Name = "tb_phoneNumber1";
            this.tb_phoneNumber1.Size = new System.Drawing.Size(100, 20);
            this.tb_phoneNumber1.TabIndex = 14;
            // 
            // tb_fax
            // 
            this.tb_fax.Location = new System.Drawing.Point(1064, 28);
            this.tb_fax.Name = "tb_fax";
            this.tb_fax.Size = new System.Drawing.Size(100, 20);
            this.tb_fax.TabIndex = 15;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(1170, 28);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(100, 20);
            this.tb_email.TabIndex = 16;
            // 
            // lbl_companyName
            // 
            this.lbl_companyName.AutoSize = true;
            this.lbl_companyName.Location = new System.Drawing.Point(4, 12);
            this.lbl_companyName.Name = "lbl_companyName";
            this.lbl_companyName.Size = new System.Drawing.Size(82, 13);
            this.lbl_companyName.TabIndex = 17;
            this.lbl_companyName.Text = "Company Name";
            // 
            // lbl_newAdress1
            // 
            this.lbl_newAdress1.AutoSize = true;
            this.lbl_newAdress1.Location = new System.Drawing.Point(107, 12);
            this.lbl_newAdress1.Name = "lbl_newAdress1";
            this.lbl_newAdress1.Size = new System.Drawing.Size(48, 13);
            this.lbl_newAdress1.TabIndex = 18;
            this.lbl_newAdress1.Text = "Adress 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Zipcode 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "City 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(425, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Adress 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(531, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Zipcode 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(637, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "City 2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(743, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Contact Person";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(849, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Initials";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(955, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Phone Numbers";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1061, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Fax";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1167, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Email";
            // 
            // gb_newClient
            // 
            this.gb_newClient.Controls.Add(this.tb_phoneNumber2);
            this.gb_newClient.Controls.Add(this.btn_cancelNewClient);
            this.gb_newClient.Controls.Add(this.btn_addNewClient);
            this.gb_newClient.Controls.Add(this.tb_fax);
            this.gb_newClient.Controls.Add(this.label12);
            this.gb_newClient.Controls.Add(this.tb_companyName);
            this.gb_newClient.Controls.Add(this.label11);
            this.gb_newClient.Controls.Add(this.tb_adress1);
            this.gb_newClient.Controls.Add(this.label10);
            this.gb_newClient.Controls.Add(this.tb_zipcode1);
            this.gb_newClient.Controls.Add(this.label9);
            this.gb_newClient.Controls.Add(this.tb_city1);
            this.gb_newClient.Controls.Add(this.label8);
            this.gb_newClient.Controls.Add(this.tb_adress2);
            this.gb_newClient.Controls.Add(this.label7);
            this.gb_newClient.Controls.Add(this.tb_zipcode2);
            this.gb_newClient.Controls.Add(this.label6);
            this.gb_newClient.Controls.Add(this.tb_city2);
            this.gb_newClient.Controls.Add(this.label5);
            this.gb_newClient.Controls.Add(this.tb_contactPerson);
            this.gb_newClient.Controls.Add(this.label4);
            this.gb_newClient.Controls.Add(this.tb_initials);
            this.gb_newClient.Controls.Add(this.label3);
            this.gb_newClient.Controls.Add(this.tb_phoneNumber1);
            this.gb_newClient.Controls.Add(this.lbl_newAdress1);
            this.gb_newClient.Controls.Add(this.tb_email);
            this.gb_newClient.Controls.Add(this.lbl_companyName);
            this.gb_newClient.Location = new System.Drawing.Point(12, 431);
            this.gb_newClient.Name = "gb_newClient";
            this.gb_newClient.Size = new System.Drawing.Size(1343, 80);
            this.gb_newClient.TabIndex = 29;
            this.gb_newClient.TabStop = false;
            this.gb_newClient.Visible = false;
            // 
            // tb_phoneNumber2
            // 
            this.tb_phoneNumber2.Location = new System.Drawing.Point(958, 54);
            this.tb_phoneNumber2.Name = "tb_phoneNumber2";
            this.tb_phoneNumber2.Size = new System.Drawing.Size(100, 20);
            this.tb_phoneNumber2.TabIndex = 31;
            // 
            // btn_cancelNewClient
            // 
            this.btn_cancelNewClient.Location = new System.Drawing.Point(1286, 51);
            this.btn_cancelNewClient.Name = "btn_cancelNewClient";
            this.btn_cancelNewClient.Size = new System.Drawing.Size(50, 23);
            this.btn_cancelNewClient.TabIndex = 30;
            this.btn_cancelNewClient.Text = "Cancel";
            this.btn_cancelNewClient.UseVisualStyleBackColor = true;
            this.btn_cancelNewClient.Click += new System.EventHandler(this.btn_cancelNewClient_Click);
            // 
            // btn_addNewClient
            // 
            this.btn_addNewClient.Location = new System.Drawing.Point(1200, 51);
            this.btn_addNewClient.Name = "btn_addNewClient";
            this.btn_addNewClient.Size = new System.Drawing.Size(70, 23);
            this.btn_addNewClient.TabIndex = 29;
            this.btn_addNewClient.Text = "Add";
            this.btn_addNewClient.UseVisualStyleBackColor = true;
            this.btn_addNewClient.Click += new System.EventHandler(this.btn_addNewClient_Click);
            // 
            // gb_newProject
            // 
            this.gb_newProject.Controls.Add(this.dtp_nextAppointment);
            this.gb_newProject.Controls.Add(this.dtp_lastAppointment);
            this.gb_newProject.Controls.Add(this.label16);
            this.gb_newProject.Controls.Add(this.label15);
            this.gb_newProject.Controls.Add(this.label14);
            this.gb_newProject.Controls.Add(this.label13);
            this.gb_newProject.Controls.Add(this.lbl_quotationId);
            this.gb_newProject.Controls.Add(this.tb_nextAction);
            this.gb_newProject.Controls.Add(this.tb_newQuotationId);
            this.gb_newProject.Controls.Add(this.tb_lastAction);
            this.gb_newProject.Controls.Add(this.btn_cancelNewProject);
            this.gb_newProject.Controls.Add(this.btn_addNewProject);
            this.gb_newProject.Location = new System.Drawing.Point(1074, 540);
            this.gb_newProject.Name = "gb_newProject";
            this.gb_newProject.Size = new System.Drawing.Size(301, 176);
            this.gb_newProject.TabIndex = 30;
            this.gb_newProject.TabStop = false;
            this.gb_newProject.Visible = false;
            // 
            // dtp_nextAppointment
            // 
            this.dtp_nextAppointment.Location = new System.Drawing.Point(103, 95);
            this.dtp_nextAppointment.Name = "dtp_nextAppointment";
            this.dtp_nextAppointment.Size = new System.Drawing.Size(184, 20);
            this.dtp_nextAppointment.TabIndex = 13;
            // 
            // dtp_lastAppointment
            // 
            this.dtp_lastAppointment.Location = new System.Drawing.Point(103, 45);
            this.dtp_lastAppointment.Name = "dtp_lastAppointment";
            this.dtp_lastAppointment.Size = new System.Drawing.Size(184, 20);
            this.dtp_lastAppointment.TabIndex = 12;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 122);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 13);
            this.label16.TabIndex = 11;
            this.label16.Text = "NextAction";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 97);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "Next Appoitment";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Last Action";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Last Appointment";
            // 
            // lbl_quotationId
            // 
            this.lbl_quotationId.AutoSize = true;
            this.lbl_quotationId.Location = new System.Drawing.Point(6, 19);
            this.lbl_quotationId.Name = "lbl_quotationId";
            this.lbl_quotationId.Size = new System.Drawing.Size(65, 13);
            this.lbl_quotationId.TabIndex = 7;
            this.lbl_quotationId.Text = "Quotation Id";
            // 
            // tb_nextAction
            // 
            this.tb_nextAction.Location = new System.Drawing.Point(138, 118);
            this.tb_nextAction.Name = "tb_nextAction";
            this.tb_nextAction.Size = new System.Drawing.Size(100, 20);
            this.tb_nextAction.TabIndex = 5;
            // 
            // tb_newQuotationId
            // 
            this.tb_newQuotationId.Location = new System.Drawing.Point(138, 19);
            this.tb_newQuotationId.Name = "tb_newQuotationId";
            this.tb_newQuotationId.Size = new System.Drawing.Size(100, 20);
            this.tb_newQuotationId.TabIndex = 3;
            // 
            // tb_lastAction
            // 
            this.tb_lastAction.Location = new System.Drawing.Point(138, 71);
            this.tb_lastAction.Name = "tb_lastAction";
            this.tb_lastAction.Size = new System.Drawing.Size(100, 20);
            this.tb_lastAction.TabIndex = 2;
            // 
            // btn_cancelNewProject
            // 
            this.btn_cancelNewProject.Location = new System.Drawing.Point(6, 147);
            this.btn_cancelNewProject.Name = "btn_cancelNewProject";
            this.btn_cancelNewProject.Size = new System.Drawing.Size(50, 23);
            this.btn_cancelNewProject.TabIndex = 1;
            this.btn_cancelNewProject.Text = "Cancel";
            this.btn_cancelNewProject.UseVisualStyleBackColor = true;
            // 
            // btn_addNewProject
            // 
            this.btn_addNewProject.Location = new System.Drawing.Point(138, 144);
            this.btn_addNewProject.Name = "btn_addNewProject";
            this.btn_addNewProject.Size = new System.Drawing.Size(149, 23);
            this.btn_addNewProject.TabIndex = 0;
            this.btn_addNewProject.Text = "Add";
            this.btn_addNewProject.UseVisualStyleBackColor = true;
            this.btn_addNewProject.Click += new System.EventHandler(this.btn_addNewProject_Click);
            // 
            // btn_newProject
            // 
            this.btn_newProject.Location = new System.Drawing.Point(1009, 713);
            this.btn_newProject.Name = "btn_newProject";
            this.btn_newProject.Size = new System.Drawing.Size(98, 23);
            this.btn_newProject.TabIndex = 31;
            this.btn_newProject.Text = "Add New Project";
            this.btn_newProject.UseVisualStyleBackColor = true;
            this.btn_newProject.Click += new System.EventHandler(this.btn_newProject_Click);
            // 
            // tbl_salesProjectsTableAdapter1
            // 
            this.tbl_salesProjectsTableAdapter1.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "BKR";
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 734);
            this.Controls.Add(this.btn_newProject);
            this.Controls.Add(this.gb_newProject);
            this.Controls.Add(this.gb_projects);
            this.Controls.Add(this.btn_newClient);
            this.Controls.Add(this.gb_clientInfos);
            this.Controls.Add(this.gb_notPaidClients);
            this.Controls.Add(this.gb_newClient);
            this.Controls.Add(this.gb_allClients);
            this.Name = "SalesForm";
            this.Text = "BarrocIt Sales ";
            this.Load += new System.EventHandler(this.SalesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblclientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_notPaidClients)).EndInit();
            this.gb_notPaidClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_notPaidClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblclientsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barocItDbDataSet5)).EndInit();
            this.gb_allClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_allClients)).EndInit();
            this.gb_clientInfos.ResumeLayout(false);
            this.gb_clientInfos.PerformLayout();
            this.gb_projects.ResumeLayout(false);
            this.gb_projects.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsalesProjectsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSalesProjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsalesProjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_salesProjects)).EndInit();
            this.gb_newClient.ResumeLayout(false);
            this.gb_newClient.PerformLayout();
            this.gb_newProject.ResumeLayout(false);
            this.gb_newProject.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_notPaidClients;
        private System.Windows.Forms.DataGridView dg_notPaidClients;
        private ds_notPaidClients ds_notPaidClients;
        private System.Windows.Forms.BindingSource tblclientsBindingSource;
        private ds_notPaidClientsTableAdapters.tbl_clientsTableAdapter tbl_clientsTableAdapter;
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
        private System.Windows.Forms.GroupBox gb_allClients;
        private System.Windows.Forms.DataGridView dg_allClients;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.GroupBox gb_clientInfos;
        private System.Windows.Forms.Label lbl_clientDetailsInactive;
        private BarocItDbDataSet5 barocItDbDataSet5;
        private System.Windows.Forms.BindingSource tblclientsBindingSource1;
        private BarocItDbDataSet5TableAdapters.tbl_clientsTableAdapter tbl_clientsTableAdapter1;
        private System.Windows.Forms.Button btn_newClient;
        private System.Windows.Forms.GroupBox gb_projects;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private ds_salesProjects ds_salesProjects;
        private System.Windows.Forms.BindingSource tblsalesProjectsBindingSource;
        private ds_salesProjectsTableAdapters.tbl_salesProjectsTableAdapter tbl_salesProjectsTableAdapter;
        private System.Windows.Forms.TextBox tb_companyName;
        private System.Windows.Forms.TextBox tb_adress1;
        private System.Windows.Forms.TextBox tb_zipcode1;
        private System.Windows.Forms.TextBox tb_city1;
        private System.Windows.Forms.TextBox tb_adress2;
        private System.Windows.Forms.TextBox tb_zipcode2;
        private System.Windows.Forms.TextBox tb_city2;
        private System.Windows.Forms.TextBox tb_contactPerson;
        private System.Windows.Forms.TextBox tb_initials;
        private System.Windows.Forms.TextBox tb_phoneNumber1;
        private System.Windows.Forms.TextBox tb_fax;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label lbl_companyName;
        private System.Windows.Forms.Label lbl_newAdress1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox gb_newClient;
        private System.Windows.Forms.Button btn_cancelNewClient;
        private System.Windows.Forms.Button btn_addNewClient;
        private System.Windows.Forms.TextBox tb_phoneNumber2;
        private System.Windows.Forms.GroupBox gb_newProject;
        private System.Windows.Forms.Button btn_newProject;
        private System.Windows.Forms.DateTimePicker dtp_nextAppointment;
        private System.Windows.Forms.DateTimePicker dtp_lastAppointment;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbl_quotationId;
        private System.Windows.Forms.TextBox tb_nextAction;
        private System.Windows.Forms.TextBox tb_newQuotationId;
        private System.Windows.Forms.TextBox tb_lastAction;
        private System.Windows.Forms.Button btn_cancelNewProject;
        private System.Windows.Forms.Button btn_addNewProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn pnextAppointementDataGridViewTextBoxColumn;
        private dsSalesProjects dsSalesProjects;
        private System.Windows.Forms.BindingSource tblsalesProjectsBindingSource1;
        private dsSalesProjectsTableAdapters.tbl_salesProjectsTableAdapter tbl_salesProjectsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cclientIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pprojectIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pquotationIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plastAppointmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plastActionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_nextAppointment;
        private System.Windows.Forms.DataGridViewTextBoxColumn pnextActionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
    }
}