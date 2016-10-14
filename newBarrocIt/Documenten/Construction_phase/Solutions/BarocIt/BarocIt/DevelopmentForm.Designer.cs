namespace BarocIt
{
    partial class DevelopmentForm
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
            this.dg_projects = new System.Windows.Forms.DataGridView();
            this.pprojectIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_clientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pmaintenanceContractDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phardwareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poperatingSystemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pinternalContactPersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbldevelopmentProjectsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dsDevelopmentProjects1 = new BarocIt.dsDevelopmentProjects();
            this.tbldevelopmentProjectsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.barocItDbDataSet3 = new BarocIt.BarocItDbDataSet3();
            this.tbldevelopmentProjectsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.barocItDbDataSet2 = new BarocIt.BarocItDbDataSet2();
            this.tbldevelopmentProjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DsDevelopmentProjects = new BarocIt.BarocItDbDataSet();
            this.tbl_developmentProjectsTableAdapter = new BarocIt.BarocItDbDataSetTableAdapters.tbl_developmentProjectsTableAdapter();
            this.tblclientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_clientsTableAdapter = new BarocIt.DsDevelopmentClientsTableAdapters.tbl_clientsTableAdapter();
            this.tblmeetingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DsMeetings = new BarocIt.BarocItDbDataSet1();
            this.tbl_meetingsTableAdapter = new BarocIt.BarocItDbDataSet1TableAdapters.tbl_meetingsTableAdapter();
            this.dg_applications = new System.Windows.Forms.DataGridView();
            this.aapplicationIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aversionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblapplicationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsApplications = new BarocIt.DsApplications();
            this.tbl_applicationsTableAdapter = new BarocIt.DsApplicationsTableAdapters.tbl_applicationsTableAdapter();
            this.btn_newMeeting = new System.Windows.Forms.Button();
            this.btn_newApplication = new System.Windows.Forms.Button();
            this.lbl_clientId = new System.Windows.Forms.Label();
            this.lbl_companyName = new System.Windows.Forms.Label();
            this.lbl_adress2 = new System.Windows.Forms.Label();
            this.lbl_zipcode1 = new System.Windows.Forms.Label();
            this.lbl_city1 = new System.Windows.Forms.Label();
            this.lbl_adress1 = new System.Windows.Forms.Label();
            this.lbl_contactPerson = new System.Windows.Forms.Label();
            this.lbl_city2 = new System.Windows.Forms.Label();
            this.lbl_zipcode2 = new System.Windows.Forms.Label();
            this.lbl_phoneNumber1 = new System.Windows.Forms.Label();
            this.lbl_fax = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_initials = new System.Windows.Forms.Label();
            this.gb_meetingsDatas = new System.Windows.Forms.GroupBox();
            this.btn_cancelNewMeeting = new System.Windows.Forms.Button();
            this.dg_meetings = new System.Windows.Forms.DataGridView();
            this.p_projectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mmeetingsIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msubjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblmeetingsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.barocItDbDataSet4 = new BarocIt.BarocItDbDataSet4();
            this.gb_newMeeting = new System.Windows.Forms.GroupBox();
            this.lbl_meetingSubject = new System.Windows.Forms.Label();
            this.lbl_meetingDate = new System.Windows.Forms.Label();
            this.btn_addMeeting = new System.Windows.Forms.Button();
            this.dtp_meeting = new System.Windows.Forms.DateTimePicker();
            this.tb_meetingSubject = new System.Windows.Forms.TextBox();
            this.gb_applications = new System.Windows.Forms.GroupBox();
            this.btn_cancelNewApplication = new System.Windows.Forms.Button();
            this.gb_newApplication = new System.Windows.Forms.GroupBox();
            this.tb_applicationName = new System.Windows.Forms.TextBox();
            this.lbl_newAppVersion = new System.Windows.Forms.Label();
            this.lbl_newAppName = new System.Windows.Forms.Label();
            this.btn_addApplication = new System.Windows.Forms.Button();
            this.tb_applicationVersion = new System.Windows.Forms.TextBox();
            this.gb_clientDetails = new System.Windows.Forms.GroupBox();
            this.tbl_developmentProjectsTableAdapter1 = new BarocIt.BarocItDbDataSet2TableAdapters.tbl_developmentProjectsTableAdapter();
            this.tbl_developmentProjectsTableAdapter2 = new BarocIt.BarocItDbDataSet3TableAdapters.tbl_developmentProjectsTableAdapter();
            this.tbl_developmentProjectsTableAdapter3 = new BarocIt.dsDevelopmentProjectsTableAdapters.tbl_developmentProjectsTableAdapter();
            this.tbl_meetingsTableAdapter1 = new BarocIt.BarocItDbDataSet4TableAdapters.tbl_meetingsTableAdapter();
            this.gb_projects = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_projects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbldevelopmentProjectsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDevelopmentProjects1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbldevelopmentProjectsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barocItDbDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbldevelopmentProjectsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barocItDbDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbldevelopmentProjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsDevelopmentProjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblclientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmeetingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsMeetings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_applications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblapplicationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsApplications)).BeginInit();
            this.gb_meetingsDatas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_meetings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmeetingsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barocItDbDataSet4)).BeginInit();
            this.gb_newMeeting.SuspendLayout();
            this.gb_applications.SuspendLayout();
            this.gb_newApplication.SuspendLayout();
            this.gb_clientDetails.SuspendLayout();
            this.gb_projects.SuspendLayout();
            this.SuspendLayout();
            // 
            // dg_projects
            // 
            this.dg_projects.AutoGenerateColumns = false;
            this.dg_projects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pprojectIdDataGridViewTextBoxColumn,
            this.c_clientId,
            this.pmaintenanceContractDataGridViewTextBoxColumn,
            this.phardwareDataGridViewTextBoxColumn,
            this.poperatingSystemDataGridViewTextBoxColumn,
            this.pinternalContactPersonDataGridViewTextBoxColumn});
            this.dg_projects.DataSource = this.tbldevelopmentProjectsBindingSource3;
            this.dg_projects.Location = new System.Drawing.Point(6, 19);
            this.dg_projects.Name = "dg_projects";
            this.dg_projects.Size = new System.Drawing.Size(720, 644);
            this.dg_projects.TabIndex = 0;
            this.dg_projects.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dg_projects_RowStateChanged);
            // 
            // pprojectIdDataGridViewTextBoxColumn
            // 
            this.pprojectIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.pprojectIdDataGridViewTextBoxColumn.DataPropertyName = "p_projectId";
            this.pprojectIdDataGridViewTextBoxColumn.HeaderText = "p_projectId";
            this.pprojectIdDataGridViewTextBoxColumn.Name = "pprojectIdDataGridViewTextBoxColumn";
            this.pprojectIdDataGridViewTextBoxColumn.Width = 85;
            // 
            // c_clientId
            // 
            this.c_clientId.DataPropertyName = "c_clientId";
            this.c_clientId.HeaderText = "c_clientId";
            this.c_clientId.Name = "c_clientId";
            // 
            // pmaintenanceContractDataGridViewTextBoxColumn
            // 
            this.pmaintenanceContractDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.pmaintenanceContractDataGridViewTextBoxColumn.DataPropertyName = "p_maintenanceContract";
            this.pmaintenanceContractDataGridViewTextBoxColumn.HeaderText = "p_maintenanceContract";
            this.pmaintenanceContractDataGridViewTextBoxColumn.Name = "pmaintenanceContractDataGridViewTextBoxColumn";
            this.pmaintenanceContractDataGridViewTextBoxColumn.Width = 145;
            // 
            // phardwareDataGridViewTextBoxColumn
            // 
            this.phardwareDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.phardwareDataGridViewTextBoxColumn.DataPropertyName = "p_hardware";
            this.phardwareDataGridViewTextBoxColumn.HeaderText = "p_hardware";
            this.phardwareDataGridViewTextBoxColumn.Name = "phardwareDataGridViewTextBoxColumn";
            this.phardwareDataGridViewTextBoxColumn.Width = 88;
            // 
            // poperatingSystemDataGridViewTextBoxColumn
            // 
            this.poperatingSystemDataGridViewTextBoxColumn.DataPropertyName = "p_operatingSystem";
            this.poperatingSystemDataGridViewTextBoxColumn.HeaderText = "p_operatingSystem";
            this.poperatingSystemDataGridViewTextBoxColumn.Name = "poperatingSystemDataGridViewTextBoxColumn";
            // 
            // pinternalContactPersonDataGridViewTextBoxColumn
            // 
            this.pinternalContactPersonDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pinternalContactPersonDataGridViewTextBoxColumn.DataPropertyName = "p_internalContactPerson";
            this.pinternalContactPersonDataGridViewTextBoxColumn.HeaderText = "p_internalContactPerson";
            this.pinternalContactPersonDataGridViewTextBoxColumn.Name = "pinternalContactPersonDataGridViewTextBoxColumn";
            this.pinternalContactPersonDataGridViewTextBoxColumn.Width = 148;
            // 
            // tbldevelopmentProjectsBindingSource3
            // 
            this.tbldevelopmentProjectsBindingSource3.DataMember = "tbl_developmentProjects";
            this.tbldevelopmentProjectsBindingSource3.DataSource = this.dsDevelopmentProjects1;
            // 
            // dsDevelopmentProjects1
            // 
            this.dsDevelopmentProjects1.DataSetName = "dsDevelopmentProjects";
            this.dsDevelopmentProjects1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbldevelopmentProjectsBindingSource2
            // 
            this.tbldevelopmentProjectsBindingSource2.DataMember = "tbl_developmentProjects";
            this.tbldevelopmentProjectsBindingSource2.DataSource = this.barocItDbDataSet3;
            // 
            // barocItDbDataSet3
            // 
            this.barocItDbDataSet3.DataSetName = "BarocItDbDataSet3";
            this.barocItDbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbldevelopmentProjectsBindingSource1
            // 
            this.tbldevelopmentProjectsBindingSource1.DataMember = "tbl_developmentProjects";
            this.tbldevelopmentProjectsBindingSource1.DataSource = this.barocItDbDataSet2;
            // 
            // barocItDbDataSet2
            // 
            this.barocItDbDataSet2.DataSetName = "BarocItDbDataSet2";
            this.barocItDbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbldevelopmentProjectsBindingSource
            // 
            this.tbldevelopmentProjectsBindingSource.DataMember = "tbl_developmentProjects";
            this.tbldevelopmentProjectsBindingSource.DataSource = this.DsDevelopmentProjects;
            // 
            // DsDevelopmentProjects
            // 
            this.DsDevelopmentProjects.DataSetName = "BarocItDbDataSet";
            this.DsDevelopmentProjects.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_developmentProjectsTableAdapter
            // 
            this.tbl_developmentProjectsTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_clientsTableAdapter
            // 
            this.tbl_clientsTableAdapter.ClearBeforeFill = true;
            // 
            // tblmeetingsBindingSource
            // 
            this.tblmeetingsBindingSource.DataMember = "tbl_meetings";
            this.tblmeetingsBindingSource.DataSource = this.DsMeetings;
            // 
            // DsMeetings
            // 
            this.DsMeetings.DataSetName = "BarocItDbDataSet1";
            this.DsMeetings.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_meetingsTableAdapter
            // 
            this.tbl_meetingsTableAdapter.ClearBeforeFill = true;
            // 
            // dg_applications
            // 
            this.dg_applications.AutoGenerateColumns = false;
            this.dg_applications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_applications.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aapplicationIdDataGridViewTextBoxColumn,
            this.anameDataGridViewTextBoxColumn,
            this.aversionDataGridViewTextBoxColumn});
            this.dg_applications.DataSource = this.tblapplicationsBindingSource;
            this.dg_applications.Location = new System.Drawing.Point(6, 19);
            this.dg_applications.Name = "dg_applications";
            this.dg_applications.Size = new System.Drawing.Size(451, 91);
            this.dg_applications.TabIndex = 2;
            this.dg_applications.Visible = false;
            // 
            // aapplicationIdDataGridViewTextBoxColumn
            // 
            this.aapplicationIdDataGridViewTextBoxColumn.DataPropertyName = "a_applicationId";
            this.aapplicationIdDataGridViewTextBoxColumn.HeaderText = "a_applicationId";
            this.aapplicationIdDataGridViewTextBoxColumn.Name = "aapplicationIdDataGridViewTextBoxColumn";
            // 
            // anameDataGridViewTextBoxColumn
            // 
            this.anameDataGridViewTextBoxColumn.DataPropertyName = "a_name";
            this.anameDataGridViewTextBoxColumn.HeaderText = "a_name";
            this.anameDataGridViewTextBoxColumn.Name = "anameDataGridViewTextBoxColumn";
            // 
            // aversionDataGridViewTextBoxColumn
            // 
            this.aversionDataGridViewTextBoxColumn.DataPropertyName = "a_version";
            this.aversionDataGridViewTextBoxColumn.HeaderText = "a_version";
            this.aversionDataGridViewTextBoxColumn.Name = "aversionDataGridViewTextBoxColumn";
            // 
            // tblapplicationsBindingSource
            // 
            this.tblapplicationsBindingSource.DataMember = "tbl_applications";
            this.tblapplicationsBindingSource.DataSource = this.dsApplications;
            // 
            // dsApplications
            // 
            this.dsApplications.DataSetName = "DsApplications";
            this.dsApplications.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_applicationsTableAdapter
            // 
            this.tbl_applicationsTableAdapter.ClearBeforeFill = true;
            // 
            // btn_newMeeting
            // 
            this.btn_newMeeting.Location = new System.Drawing.Point(338, 160);
            this.btn_newMeeting.Name = "btn_newMeeting";
            this.btn_newMeeting.Size = new System.Drawing.Size(111, 23);
            this.btn_newMeeting.TabIndex = 11;
            this.btn_newMeeting.Text = "Add new Meeting";
            this.btn_newMeeting.UseVisualStyleBackColor = true;
            this.btn_newMeeting.Visible = false;
            this.btn_newMeeting.Click += new System.EventHandler(this.btn_newMeeting_Click);
            // 
            // btn_newApplication
            // 
            this.btn_newApplication.Location = new System.Drawing.Point(340, 116);
            this.btn_newApplication.Name = "btn_newApplication";
            this.btn_newApplication.Size = new System.Drawing.Size(117, 23);
            this.btn_newApplication.TabIndex = 12;
            this.btn_newApplication.Text = "Add new Application";
            this.btn_newApplication.UseVisualStyleBackColor = true;
            this.btn_newApplication.Visible = false;
            this.btn_newApplication.Click += new System.EventHandler(this.btn_newApplication_Click);
            // 
            // lbl_clientId
            // 
            this.lbl_clientId.AutoSize = true;
            this.lbl_clientId.Location = new System.Drawing.Point(6, 32);
            this.lbl_clientId.Name = "lbl_clientId";
            this.lbl_clientId.Size = new System.Drawing.Size(35, 13);
            this.lbl_clientId.TabIndex = 17;
            this.lbl_clientId.Text = "label5";
            this.lbl_clientId.Visible = false;
            // 
            // lbl_companyName
            // 
            this.lbl_companyName.AutoSize = true;
            this.lbl_companyName.Location = new System.Drawing.Point(6, 55);
            this.lbl_companyName.Name = "lbl_companyName";
            this.lbl_companyName.Size = new System.Drawing.Size(35, 13);
            this.lbl_companyName.TabIndex = 18;
            this.lbl_companyName.Text = "label6";
            this.lbl_companyName.Visible = false;
            // 
            // lbl_adress2
            // 
            this.lbl_adress2.AutoSize = true;
            this.lbl_adress2.Location = new System.Drawing.Point(6, 135);
            this.lbl_adress2.Name = "lbl_adress2";
            this.lbl_adress2.Size = new System.Drawing.Size(35, 13);
            this.lbl_adress2.TabIndex = 20;
            this.lbl_adress2.Text = "label7";
            this.lbl_adress2.Visible = false;
            // 
            // lbl_zipcode1
            // 
            this.lbl_zipcode1.AutoSize = true;
            this.lbl_zipcode1.Location = new System.Drawing.Point(6, 74);
            this.lbl_zipcode1.Name = "lbl_zipcode1";
            this.lbl_zipcode1.Size = new System.Drawing.Size(35, 13);
            this.lbl_zipcode1.TabIndex = 19;
            this.lbl_zipcode1.Text = "label8";
            this.lbl_zipcode1.Visible = false;
            // 
            // lbl_city1
            // 
            this.lbl_city1.AutoSize = true;
            this.lbl_city1.Location = new System.Drawing.Point(6, 113);
            this.lbl_city1.Name = "lbl_city1";
            this.lbl_city1.Size = new System.Drawing.Size(35, 13);
            this.lbl_city1.TabIndex = 22;
            this.lbl_city1.Text = "label9";
            this.lbl_city1.Visible = false;
            // 
            // lbl_adress1
            // 
            this.lbl_adress1.AutoSize = true;
            this.lbl_adress1.Location = new System.Drawing.Point(6, 94);
            this.lbl_adress1.Name = "lbl_adress1";
            this.lbl_adress1.Size = new System.Drawing.Size(41, 13);
            this.lbl_adress1.TabIndex = 21;
            this.lbl_adress1.Text = "label10";
            this.lbl_adress1.Visible = false;
            // 
            // lbl_contactPerson
            // 
            this.lbl_contactPerson.AutoSize = true;
            this.lbl_contactPerson.Location = new System.Drawing.Point(248, 55);
            this.lbl_contactPerson.Name = "lbl_contactPerson";
            this.lbl_contactPerson.Size = new System.Drawing.Size(41, 13);
            this.lbl_contactPerson.TabIndex = 28;
            this.lbl_contactPerson.Text = "label11";
            this.lbl_contactPerson.Visible = false;
            // 
            // lbl_city2
            // 
            this.lbl_city2.AutoSize = true;
            this.lbl_city2.Location = new System.Drawing.Point(248, 32);
            this.lbl_city2.Name = "lbl_city2";
            this.lbl_city2.Size = new System.Drawing.Size(41, 13);
            this.lbl_city2.TabIndex = 27;
            this.lbl_city2.Text = "label12";
            this.lbl_city2.Visible = false;
            // 
            // lbl_zipcode2
            // 
            this.lbl_zipcode2.AutoSize = true;
            this.lbl_zipcode2.Location = new System.Drawing.Point(6, 157);
            this.lbl_zipcode2.Name = "lbl_zipcode2";
            this.lbl_zipcode2.Size = new System.Drawing.Size(41, 13);
            this.lbl_zipcode2.TabIndex = 25;
            this.lbl_zipcode2.Text = "label14";
            this.lbl_zipcode2.Visible = false;
            // 
            // lbl_phoneNumber1
            // 
            this.lbl_phoneNumber1.AutoSize = true;
            this.lbl_phoneNumber1.Location = new System.Drawing.Point(248, 94);
            this.lbl_phoneNumber1.Name = "lbl_phoneNumber1";
            this.lbl_phoneNumber1.Size = new System.Drawing.Size(41, 13);
            this.lbl_phoneNumber1.TabIndex = 24;
            this.lbl_phoneNumber1.Text = "label15";
            this.lbl_phoneNumber1.Visible = false;
            // 
            // lbl_fax
            // 
            this.lbl_fax.AutoSize = true;
            this.lbl_fax.Location = new System.Drawing.Point(248, 113);
            this.lbl_fax.Name = "lbl_fax";
            this.lbl_fax.Size = new System.Drawing.Size(41, 13);
            this.lbl_fax.TabIndex = 23;
            this.lbl_fax.Text = "label16";
            this.lbl_fax.Visible = false;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(248, 135);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(41, 13);
            this.lbl_email.TabIndex = 30;
            this.lbl_email.Text = "label17";
            this.lbl_email.Visible = false;
            // 
            // lbl_initials
            // 
            this.lbl_initials.AutoSize = true;
            this.lbl_initials.Location = new System.Drawing.Point(248, 74);
            this.lbl_initials.Name = "lbl_initials";
            this.lbl_initials.Size = new System.Drawing.Size(41, 13);
            this.lbl_initials.TabIndex = 29;
            this.lbl_initials.Text = "label18";
            this.lbl_initials.Visible = false;
            // 
            // gb_meetingsDatas
            // 
            this.gb_meetingsDatas.BackColor = System.Drawing.SystemColors.Control;
            this.gb_meetingsDatas.Controls.Add(this.btn_cancelNewMeeting);
            this.gb_meetingsDatas.Controls.Add(this.dg_meetings);
            this.gb_meetingsDatas.Controls.Add(this.btn_newMeeting);
            this.gb_meetingsDatas.Controls.Add(this.gb_newMeeting);
            this.gb_meetingsDatas.Location = new System.Drawing.Point(758, 212);
            this.gb_meetingsDatas.Name = "gb_meetingsDatas";
            this.gb_meetingsDatas.Size = new System.Drawing.Size(457, 262);
            this.gb_meetingsDatas.TabIndex = 31;
            this.gb_meetingsDatas.TabStop = false;
            this.gb_meetingsDatas.Text = "Meetings";
            // 
            // btn_cancelNewMeeting
            // 
            this.btn_cancelNewMeeting.Location = new System.Drawing.Point(397, 218);
            this.btn_cancelNewMeeting.Name = "btn_cancelNewMeeting";
            this.btn_cancelNewMeeting.Size = new System.Drawing.Size(52, 23);
            this.btn_cancelNewMeeting.TabIndex = 17;
            this.btn_cancelNewMeeting.Text = "cancel";
            this.btn_cancelNewMeeting.UseVisualStyleBackColor = true;
            this.btn_cancelNewMeeting.Visible = false;
            this.btn_cancelNewMeeting.Click += new System.EventHandler(this.btn_cancelNewMeeting_Click);
            // 
            // dg_meetings
            // 
            this.dg_meetings.AutoGenerateColumns = false;
            this.dg_meetings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_meetings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.p_projectId,
            this.mmeetingsIdDataGridViewTextBoxColumn,
            this.mdateDataGridViewTextBoxColumn,
            this.msubjectDataGridViewTextBoxColumn});
            this.dg_meetings.DataSource = this.tblmeetingsBindingSource1;
            this.dg_meetings.Location = new System.Drawing.Point(6, 19);
            this.dg_meetings.Name = "dg_meetings";
            this.dg_meetings.Size = new System.Drawing.Size(443, 135);
            this.dg_meetings.TabIndex = 1;
            this.dg_meetings.Visible = false;
            // 
            // p_projectId
            // 
            this.p_projectId.DataPropertyName = "p_projectId";
            this.p_projectId.HeaderText = "p_projectId";
            this.p_projectId.Name = "p_projectId";
            // 
            // mmeetingsIdDataGridViewTextBoxColumn
            // 
            this.mmeetingsIdDataGridViewTextBoxColumn.DataPropertyName = "m_meetingsId";
            this.mmeetingsIdDataGridViewTextBoxColumn.HeaderText = "m_meetingsId";
            this.mmeetingsIdDataGridViewTextBoxColumn.Name = "mmeetingsIdDataGridViewTextBoxColumn";
            this.mmeetingsIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mdateDataGridViewTextBoxColumn
            // 
            this.mdateDataGridViewTextBoxColumn.DataPropertyName = "m_date";
            this.mdateDataGridViewTextBoxColumn.HeaderText = "m_date";
            this.mdateDataGridViewTextBoxColumn.Name = "mdateDataGridViewTextBoxColumn";
            // 
            // msubjectDataGridViewTextBoxColumn
            // 
            this.msubjectDataGridViewTextBoxColumn.DataPropertyName = "m_subject";
            this.msubjectDataGridViewTextBoxColumn.HeaderText = "m_subject";
            this.msubjectDataGridViewTextBoxColumn.Name = "msubjectDataGridViewTextBoxColumn";
            // 
            // tblmeetingsBindingSource1
            // 
            this.tblmeetingsBindingSource1.DataMember = "tbl_meetings";
            this.tblmeetingsBindingSource1.DataSource = this.barocItDbDataSet4;
            // 
            // barocItDbDataSet4
            // 
            this.barocItDbDataSet4.DataSetName = "BarocItDbDataSet4";
            this.barocItDbDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gb_newMeeting
            // 
            this.gb_newMeeting.Controls.Add(this.lbl_meetingSubject);
            this.gb_newMeeting.Controls.Add(this.lbl_meetingDate);
            this.gb_newMeeting.Controls.Add(this.btn_addMeeting);
            this.gb_newMeeting.Controls.Add(this.dtp_meeting);
            this.gb_newMeeting.Controls.Add(this.tb_meetingSubject);
            this.gb_newMeeting.Location = new System.Drawing.Point(6, 160);
            this.gb_newMeeting.Name = "gb_newMeeting";
            this.gb_newMeeting.Size = new System.Drawing.Size(326, 82);
            this.gb_newMeeting.TabIndex = 16;
            this.gb_newMeeting.TabStop = false;
            this.gb_newMeeting.Text = "New Meeting";
            this.gb_newMeeting.Visible = false;
            // 
            // lbl_meetingSubject
            // 
            this.lbl_meetingSubject.AutoSize = true;
            this.lbl_meetingSubject.Location = new System.Drawing.Point(6, 59);
            this.lbl_meetingSubject.Name = "lbl_meetingSubject";
            this.lbl_meetingSubject.Size = new System.Drawing.Size(47, 13);
            this.lbl_meetingSubject.TabIndex = 18;
            this.lbl_meetingSubject.Text = "subject :";
            // 
            // lbl_meetingDate
            // 
            this.lbl_meetingDate.AutoSize = true;
            this.lbl_meetingDate.Location = new System.Drawing.Point(18, 30);
            this.lbl_meetingDate.Name = "lbl_meetingDate";
            this.lbl_meetingDate.Size = new System.Drawing.Size(34, 13);
            this.lbl_meetingDate.TabIndex = 17;
            this.lbl_meetingDate.Text = "date :";
            // 
            // btn_addMeeting
            // 
            this.btn_addMeeting.Location = new System.Drawing.Point(277, 53);
            this.btn_addMeeting.Name = "btn_addMeeting";
            this.btn_addMeeting.Size = new System.Drawing.Size(43, 23);
            this.btn_addMeeting.TabIndex = 16;
            this.btn_addMeeting.Text = "Add";
            this.btn_addMeeting.UseVisualStyleBackColor = true;
            this.btn_addMeeting.Click += new System.EventHandler(this.btn_addMeeting_Click);
            // 
            // dtp_meeting
            // 
            this.dtp_meeting.Location = new System.Drawing.Point(58, 30);
            this.dtp_meeting.Name = "dtp_meeting";
            this.dtp_meeting.Size = new System.Drawing.Size(200, 20);
            this.dtp_meeting.TabIndex = 15;
            // 
            // tb_meetingSubject
            // 
            this.tb_meetingSubject.Location = new System.Drawing.Point(58, 56);
            this.tb_meetingSubject.Name = "tb_meetingSubject";
            this.tb_meetingSubject.Size = new System.Drawing.Size(200, 20);
            this.tb_meetingSubject.TabIndex = 9;
            // 
            // gb_applications
            // 
            this.gb_applications.Controls.Add(this.btn_cancelNewApplication);
            this.gb_applications.Controls.Add(this.gb_newApplication);
            this.gb_applications.Controls.Add(this.dg_applications);
            this.gb_applications.Controls.Add(this.btn_newApplication);
            this.gb_applications.Location = new System.Drawing.Point(750, 480);
            this.gb_applications.Name = "gb_applications";
            this.gb_applications.Size = new System.Drawing.Size(465, 201);
            this.gb_applications.TabIndex = 32;
            this.gb_applications.TabStop = false;
            this.gb_applications.Text = "Applications";
            // 
            // btn_cancelNewApplication
            // 
            this.btn_cancelNewApplication.Location = new System.Drawing.Point(405, 179);
            this.btn_cancelNewApplication.Name = "btn_cancelNewApplication";
            this.btn_cancelNewApplication.Size = new System.Drawing.Size(52, 23);
            this.btn_cancelNewApplication.TabIndex = 18;
            this.btn_cancelNewApplication.Text = "cancel";
            this.btn_cancelNewApplication.UseVisualStyleBackColor = true;
            this.btn_cancelNewApplication.Visible = false;
            this.btn_cancelNewApplication.Click += new System.EventHandler(this.btn_cancelNewApplication_Click);
            // 
            // gb_newApplication
            // 
            this.gb_newApplication.Controls.Add(this.tb_applicationName);
            this.gb_newApplication.Controls.Add(this.lbl_newAppVersion);
            this.gb_newApplication.Controls.Add(this.lbl_newAppName);
            this.gb_newApplication.Controls.Add(this.btn_addApplication);
            this.gb_newApplication.Controls.Add(this.tb_applicationVersion);
            this.gb_newApplication.Location = new System.Drawing.Point(8, 116);
            this.gb_newApplication.Name = "gb_newApplication";
            this.gb_newApplication.Size = new System.Drawing.Size(326, 86);
            this.gb_newApplication.TabIndex = 19;
            this.gb_newApplication.TabStop = false;
            this.gb_newApplication.Text = "New Application";
            this.gb_newApplication.Visible = false;
            // 
            // tb_applicationName
            // 
            this.tb_applicationName.Location = new System.Drawing.Point(58, 27);
            this.tb_applicationName.Name = "tb_applicationName";
            this.tb_applicationName.Size = new System.Drawing.Size(85, 20);
            this.tb_applicationName.TabIndex = 19;
            // 
            // lbl_newAppVersion
            // 
            this.lbl_newAppVersion.AutoSize = true;
            this.lbl_newAppVersion.Location = new System.Drawing.Point(6, 59);
            this.lbl_newAppVersion.Name = "lbl_newAppVersion";
            this.lbl_newAppVersion.Size = new System.Drawing.Size(47, 13);
            this.lbl_newAppVersion.TabIndex = 18;
            this.lbl_newAppVersion.Text = "version :";
            // 
            // lbl_newAppName
            // 
            this.lbl_newAppName.AutoSize = true;
            this.lbl_newAppName.Location = new System.Drawing.Point(18, 30);
            this.lbl_newAppName.Name = "lbl_newAppName";
            this.lbl_newAppName.Size = new System.Drawing.Size(42, 13);
            this.lbl_newAppName.TabIndex = 17;
            this.lbl_newAppName.Text = "name : ";
            // 
            // btn_addApplication
            // 
            this.btn_addApplication.Location = new System.Drawing.Point(277, 53);
            this.btn_addApplication.Name = "btn_addApplication";
            this.btn_addApplication.Size = new System.Drawing.Size(43, 23);
            this.btn_addApplication.TabIndex = 16;
            this.btn_addApplication.Text = "Add";
            this.btn_addApplication.UseVisualStyleBackColor = true;
            this.btn_addApplication.Click += new System.EventHandler(this.btn_addApplication_Click);
            // 
            // tb_applicationVersion
            // 
            this.tb_applicationVersion.Location = new System.Drawing.Point(58, 56);
            this.tb_applicationVersion.Name = "tb_applicationVersion";
            this.tb_applicationVersion.Size = new System.Drawing.Size(85, 20);
            this.tb_applicationVersion.TabIndex = 9;
            // 
            // gb_clientDetails
            // 
            this.gb_clientDetails.BackColor = System.Drawing.SystemColors.Control;
            this.gb_clientDetails.Controls.Add(this.lbl_clientId);
            this.gb_clientDetails.Controls.Add(this.lbl_companyName);
            this.gb_clientDetails.Controls.Add(this.lbl_zipcode1);
            this.gb_clientDetails.Controls.Add(this.lbl_email);
            this.gb_clientDetails.Controls.Add(this.lbl_adress2);
            this.gb_clientDetails.Controls.Add(this.lbl_initials);
            this.gb_clientDetails.Controls.Add(this.lbl_adress1);
            this.gb_clientDetails.Controls.Add(this.lbl_contactPerson);
            this.gb_clientDetails.Controls.Add(this.lbl_city1);
            this.gb_clientDetails.Controls.Add(this.lbl_city2);
            this.gb_clientDetails.Controls.Add(this.lbl_fax);
            this.gb_clientDetails.Controls.Add(this.lbl_zipcode2);
            this.gb_clientDetails.Controls.Add(this.lbl_phoneNumber1);
            this.gb_clientDetails.Location = new System.Drawing.Point(764, 22);
            this.gb_clientDetails.Name = "gb_clientDetails";
            this.gb_clientDetails.Size = new System.Drawing.Size(451, 184);
            this.gb_clientDetails.TabIndex = 33;
            this.gb_clientDetails.TabStop = false;
            this.gb_clientDetails.Text = "Client details";
            // 
            // tbl_developmentProjectsTableAdapter1
            // 
            this.tbl_developmentProjectsTableAdapter1.ClearBeforeFill = true;
            // 
            // tbl_developmentProjectsTableAdapter2
            // 
            this.tbl_developmentProjectsTableAdapter2.ClearBeforeFill = true;
            // 
            // tbl_developmentProjectsTableAdapter3
            // 
            this.tbl_developmentProjectsTableAdapter3.ClearBeforeFill = true;
            // 
            // tbl_meetingsTableAdapter1
            // 
            this.tbl_meetingsTableAdapter1.ClearBeforeFill = true;
            // 
            // gb_projects
            // 
            this.gb_projects.Controls.Add(this.dg_projects);
            this.gb_projects.Location = new System.Drawing.Point(12, 22);
            this.gb_projects.Name = "gb_projects";
            this.gb_projects.Size = new System.Drawing.Size(732, 676);
            this.gb_projects.TabIndex = 34;
            this.gb_projects.TabStop = false;
            this.gb_projects.Text = "Projects";
            // 
            // DevelopmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1227, 704);
            this.Controls.Add(this.gb_projects);
            this.Controls.Add(this.gb_clientDetails);
            this.Controls.Add(this.gb_applications);
            this.Controls.Add(this.gb_meetingsDatas);
            this.Name = "DevelopmentForm";
            this.Text = "BarocIt Development";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DevelopmentForm_FormClosing);
            this.Load += new System.EventHandler(this.DevelopmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_projects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbldevelopmentProjectsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDevelopmentProjects1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbldevelopmentProjectsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barocItDbDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbldevelopmentProjectsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barocItDbDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbldevelopmentProjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsDevelopmentProjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblclientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmeetingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsMeetings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_applications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblapplicationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsApplications)).EndInit();
            this.gb_meetingsDatas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_meetings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmeetingsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barocItDbDataSet4)).EndInit();
            this.gb_newMeeting.ResumeLayout(false);
            this.gb_newMeeting.PerformLayout();
            this.gb_applications.ResumeLayout(false);
            this.gb_newApplication.ResumeLayout(false);
            this.gb_newApplication.PerformLayout();
            this.gb_clientDetails.ResumeLayout(false);
            this.gb_clientDetails.PerformLayout();
            this.gb_projects.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_projects;
        private BarocItDbDataSet DsDevelopmentProjects;
        private System.Windows.Forms.BindingSource tbldevelopmentProjectsBindingSource;
        private BarocItDbDataSetTableAdapters.tbl_developmentProjectsTableAdapter tbl_developmentProjectsTableAdapter;
        private System.Windows.Forms.BindingSource tblclientsBindingSource;
        private DsDevelopmentClientsTableAdapters.tbl_clientsTableAdapter tbl_clientsTableAdapter;
        private BarocItDbDataSet1 DsMeetings;
        private System.Windows.Forms.BindingSource tblmeetingsBindingSource;
        private BarocItDbDataSet1TableAdapters.tbl_meetingsTableAdapter tbl_meetingsTableAdapter;
        private System.Windows.Forms.DataGridView dg_applications;
        private DsApplications dsApplications;
        private System.Windows.Forms.BindingSource tblapplicationsBindingSource;
        private DsApplicationsTableAdapters.tbl_applicationsTableAdapter tbl_applicationsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn aapplicationIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aversionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_newMeeting;
        private System.Windows.Forms.Button btn_newApplication;
        private System.Windows.Forms.Label lbl_clientId;
        private System.Windows.Forms.Label lbl_companyName;
        private System.Windows.Forms.Label lbl_adress2;
        private System.Windows.Forms.Label lbl_zipcode1;
        private System.Windows.Forms.Label lbl_city1;
        private System.Windows.Forms.Label lbl_adress1;
        private System.Windows.Forms.Label lbl_contactPerson;
        private System.Windows.Forms.Label lbl_city2;
        private System.Windows.Forms.Label lbl_zipcode2;
        private System.Windows.Forms.Label lbl_phoneNumber1;
        private System.Windows.Forms.Label lbl_fax;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_initials;
        private System.Windows.Forms.GroupBox gb_meetingsDatas;
        private System.Windows.Forms.GroupBox gb_newMeeting;
        private System.Windows.Forms.Label lbl_meetingSubject;
        private System.Windows.Forms.Label lbl_meetingDate;
        private System.Windows.Forms.Button btn_addMeeting;
        private System.Windows.Forms.DateTimePicker dtp_meeting;
        private System.Windows.Forms.TextBox tb_meetingSubject;
        private System.Windows.Forms.GroupBox gb_applications;
        private System.Windows.Forms.GroupBox gb_newApplication;
        private System.Windows.Forms.TextBox tb_applicationName;
        private System.Windows.Forms.Label lbl_newAppVersion;
        private System.Windows.Forms.Label lbl_newAppName;
        private System.Windows.Forms.Button btn_addApplication;
        private System.Windows.Forms.TextBox tb_applicationVersion;
        private System.Windows.Forms.GroupBox gb_clientDetails;
        private System.Windows.Forms.Button btn_cancelNewMeeting;
        private System.Windows.Forms.Button btn_cancelNewApplication;
        private BarocItDbDataSet2 barocItDbDataSet2;
        private System.Windows.Forms.BindingSource tbldevelopmentProjectsBindingSource1;
        private BarocItDbDataSet2TableAdapters.tbl_developmentProjectsTableAdapter tbl_developmentProjectsTableAdapter1;
        private BarocItDbDataSet3 barocItDbDataSet3;
        private System.Windows.Forms.BindingSource tbldevelopmentProjectsBindingSource2;
        private BarocItDbDataSet3TableAdapters.tbl_developmentProjectsTableAdapter tbl_developmentProjectsTableAdapter2;
        private dsDevelopmentProjects dsDevelopmentProjects1;
        private System.Windows.Forms.BindingSource tbldevelopmentProjectsBindingSource3;
        private dsDevelopmentProjectsTableAdapters.tbl_developmentProjectsTableAdapter tbl_developmentProjectsTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn pprojectIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_clientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn pmaintenanceContractDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phardwareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poperatingSystemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pinternalContactPersonDataGridViewTextBoxColumn;
        private BarocItDbDataSet4 barocItDbDataSet4;
        private System.Windows.Forms.BindingSource tblmeetingsBindingSource1;
        private BarocItDbDataSet4TableAdapters.tbl_meetingsTableAdapter tbl_meetingsTableAdapter1;
        private System.Windows.Forms.DataGridView dg_meetings;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_projectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn mmeetingsIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn msubjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox gb_projects;
    }
}