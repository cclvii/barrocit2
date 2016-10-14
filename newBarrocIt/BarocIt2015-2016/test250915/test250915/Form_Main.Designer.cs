namespace test250915
{
    partial class Form_Main
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
            this.dataGridView_Projects = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projects_Column_ProjectsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projects_Column_StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projects_column_DeadLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projects_isFinished = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button_addCustomer = new System.Windows.Forms.Button();
            this.dataGridView_Customers = new System.Windows.Forms.DataGridView();
            this.columns_Customers_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_EditCustomers = new System.Windows.Forms.Button();
            this.button_addProject = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.projectsTableLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Projects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Customers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Projects
            // 
            this.dataGridView_Projects.AllowUserToAddRows = false;
            this.dataGridView_Projects.AllowUserToDeleteRows = false;
            this.dataGridView_Projects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Projects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.projects_Column_ProjectsName,
            this.projects_Column_StartDate,
            this.projects_column_DeadLine,
            this.projects_isFinished});
            this.dataGridView_Projects.Location = new System.Drawing.Point(6, 19);
            this.dataGridView_Projects.Name = "dataGridView_Projects";
            this.dataGridView_Projects.ReadOnly = true;
            this.dataGridView_Projects.Size = new System.Drawing.Size(444, 266);
            this.dataGridView_Projects.TabIndex = 0;
            this.dataGridView_Projects.Visible = false;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // projects_Column_ProjectsName
            // 
            this.projects_Column_ProjectsName.HeaderText = "Project_Name";
            this.projects_Column_ProjectsName.Name = "projects_Column_ProjectsName";
            this.projects_Column_ProjectsName.ReadOnly = true;
            // 
            // projects_Column_StartDate
            // 
            this.projects_Column_StartDate.HeaderText = "Start Date";
            this.projects_Column_StartDate.Name = "projects_Column_StartDate";
            this.projects_Column_StartDate.ReadOnly = true;
            // 
            // projects_column_DeadLine
            // 
            this.projects_column_DeadLine.HeaderText = "Dead Line";
            this.projects_column_DeadLine.Name = "projects_column_DeadLine";
            this.projects_column_DeadLine.ReadOnly = true;
            // 
            // projects_isFinished
            // 
            this.projects_isFinished.HeaderText = "Finished";
            this.projects_isFinished.Name = "projects_isFinished";
            this.projects_isFinished.ReadOnly = true;
            // 
            // button_addCustomer
            // 
            this.button_addCustomer.Location = new System.Drawing.Point(6, 300);
            this.button_addCustomer.Name = "button_addCustomer";
            this.button_addCustomer.Size = new System.Drawing.Size(75, 23);
            this.button_addCustomer.TabIndex = 1;
            this.button_addCustomer.Text = "Add";
            this.button_addCustomer.UseVisualStyleBackColor = true;
            this.button_addCustomer.Click += new System.EventHandler(this.button_addCustomer_Click);
            // 
            // dataGridView_Customers
            // 
            this.dataGridView_Customers.AllowUserToAddRows = false;
            this.dataGridView_Customers.AllowUserToDeleteRows = false;
            this.dataGridView_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Customers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columns_Customers_id,
            this.columnName,
            this.columnEmail,
            this.columnPhone});
            this.dataGridView_Customers.Location = new System.Drawing.Point(6, 19);
            this.dataGridView_Customers.Name = "dataGridView_Customers";
            this.dataGridView_Customers.ReadOnly = true;
            this.dataGridView_Customers.Size = new System.Drawing.Size(444, 266);
            this.dataGridView_Customers.TabIndex = 3;
            this.dataGridView_Customers.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Customers_CellContentDoubleClick);
            // 
            // columns_Customers_id
            // 
            this.columns_Customers_id.HeaderText = "id";
            this.columns_Customers_id.Name = "columns_Customers_id";
            this.columns_Customers_id.ReadOnly = true;
            // 
            // columnName
            // 
            this.columnName.HeaderText = "Name";
            this.columnName.Name = "columnName";
            this.columnName.ReadOnly = true;
            // 
            // columnEmail
            // 
            this.columnEmail.HeaderText = "Email";
            this.columnEmail.Name = "columnEmail";
            this.columnEmail.ReadOnly = true;
            // 
            // columnPhone
            // 
            this.columnPhone.HeaderText = "Phone";
            this.columnPhone.Name = "columnPhone";
            this.columnPhone.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_EditCustomers);
            this.groupBox1.Controls.Add(this.dataGridView_Customers);
            this.groupBox1.Controls.Add(this.button_addCustomer);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 329);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customers";
            // 
            // button_EditCustomers
            // 
            this.button_EditCustomers.Enabled = false;
            this.button_EditCustomers.Location = new System.Drawing.Point(87, 300);
            this.button_EditCustomers.Name = "button_EditCustomers";
            this.button_EditCustomers.Size = new System.Drawing.Size(75, 23);
            this.button_EditCustomers.TabIndex = 4;
            this.button_EditCustomers.Text = "Edit";
            this.button_EditCustomers.UseVisualStyleBackColor = true;
            this.button_EditCustomers.Click += new System.EventHandler(this.button_EditCustomer_Click);
            // 
            // button_addProject
            // 
            this.button_addProject.Enabled = false;
            this.button_addProject.Location = new System.Drawing.Point(6, 300);
            this.button_addProject.Name = "button_addProject";
            this.button_addProject.Size = new System.Drawing.Size(75, 23);
            this.button_addProject.TabIndex = 4;
            this.button_addProject.Text = "Add";
            this.button_addProject.UseVisualStyleBackColor = true;
            this.button_addProject.Click += new System.EventHandler(this.button_addProject_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView_Projects);
            this.groupBox2.Controls.Add(this.button_addProject);
            this.groupBox2.Controls.Add(this.projectsTableLabel);
            this.groupBox2.Location = new System.Drawing.Point(12, 365);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 329);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Projects";
            // 
            // projectsTableLabel
            // 
            this.projectsTableLabel.AutoSize = true;
            this.projectsTableLabel.Location = new System.Drawing.Point(113, 123);
            this.projectsTableLabel.Name = "projectsTableLabel";
            this.projectsTableLabel.Size = new System.Drawing.Size(212, 13);
            this.projectsTableLabel.TabIndex = 2;
            this.projectsTableLabel.Text = "Double click on a client to see his project(s)";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 706);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.HelpButton = true;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Projects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Customers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Projects;
        private System.Windows.Forms.Button button_addCustomer;
        private System.Windows.Forms.Button button_addCustomers;
        private System.Windows.Forms.DataGridView dataGridView_Customers;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn projects_Column_ProjectsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn projects_Column_StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn projects_column_DeadLine;
        private System.Windows.Forms.DataGridViewCheckBoxColumn projects_isFinished;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_addProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn columns_Customers_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPhone;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label projectsTableLabel;
        private System.Windows.Forms.Button button_EditCustomers;
    }
}