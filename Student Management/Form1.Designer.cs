namespace Student_Management
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblStudentName = new Label();
            txtStudentName = new TextBox();
            lblAge = new Label();
            txtAge = new TextBox();
            lblContact = new Label();
            txtContact = new TextBox();
            lblGender = new Label();
            cmbGender = new ComboBox();
            dtpDOB = new DateTimePicker();
            lblDOB = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnView = new Button();
            btnExport = new Button();
            dataGridViewStudents = new DataGridView();
            txtSearch = new TextBox();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).BeginInit();
            SuspendLayout();

            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.ForeColor = Color.White;
            lblStudentName.Location = new Point(12, 20);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(107, 20);
            lblStudentName.TabIndex = 0;
            lblStudentName.Text = "Student Name:";

            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(130, 17);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(250, 27);
            txtStudentName.TabIndex = 1;

            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.ForeColor = Color.White;
            lblAge.Location = new Point(12, 60);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(39, 20);
            lblAge.TabIndex = 2;
            lblAge.Text = "Age:";

            // 
            // txtAge
            // 
            txtAge.Location = new Point(130, 57);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(250, 27);
            txtAge.TabIndex = 3;

            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.ForeColor = Color.White;
            lblContact.Location = new Point(12, 100);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(63, 20);
            lblContact.TabIndex = 4;
            lblContact.Text = "Contact:";

            // 
            // txtContact
            // 
            txtContact.Location = new Point(130, 97);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(250, 27);
            txtContact.TabIndex = 5;

            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.ForeColor = Color.White;
            lblGender.Location = new Point(12, 140);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(60, 20);
            lblGender.TabIndex = 6;
            lblGender.Text = "Gender:";

            // 
            // cmbGender
            // 
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            cmbGender.Location = new Point(130, 137);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(250, 28);
            cmbGender.TabIndex = 7;

            // 
            // dtpDOB
            // 
            dtpDOB.Format = DateTimePickerFormat.Short;
            dtpDOB.Location = new Point(130, 177);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(250, 27);
            dtpDOB.TabIndex = 9;

            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.ForeColor = Color.White;
            lblDOB.Location = new Point(12, 180);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(97, 20);
            lblDOB.TabIndex = 8;
            lblDOB.Text = "Date of Birth:";

            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.MediumSeaGreen;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(400, 16);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 30);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += new EventHandler(btnAdd_Click);

            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Goldenrod;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(400, 56);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 30);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += new EventHandler(btnUpdate_Click);

            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Crimson;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(400, 96);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 30);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += new EventHandler(btnDelete_Click);

            // 
            // btnView
            // 
            btnView.BackColor = Color.DodgerBlue;
            btnView.ForeColor = Color.White;
            btnView.Location = new Point(400, 136);
            btnView.Name = "btnView";
            btnView.Size = new Size(100, 30);
            btnView.TabIndex = 13;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = false;
          //  btnView.Click += new EventHandler(btnView_Click);

            // 
            // btnExport
            // 
            btnExport.BackColor = Color.Orange;
            btnExport.ForeColor = Color.White;
            btnExport.Location = new Point(400, 176);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(100, 30);
            btnExport.TabIndex = 14;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = false;

            // 
            // dataGridViewStudents
            // 
            dataGridViewStudents.BackgroundColor = Color.AliceBlue;
            dataGridViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudents.Location = new Point(12, 260);
            dataGridViewStudents.Name = "dataGridViewStudents";
            dataGridViewStudents.RowHeadersWidth = 51;
            dataGridViewStudents.Size = new Size(776, 178);
            dataGridViewStudents.TabIndex = 17;

            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 220);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(250, 27);
            txtSearch.TabIndex = 15;

            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Purple;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(270, 219);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(110, 30);
            btnSearch.TabIndex = 16;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += new EventHandler(btnSearch_Click);

            // 
            // Form1
            // 
            BackColor = Color.SlateGray;
            ClientSize = new Size(821, 477);
            Controls.Add(dataGridViewStudents);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnExport);
            Controls.Add(btnView);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dtpDOB);
            Controls.Add(lblDOB);
            Controls.Add(cmbGender);
            Controls.Add(lblGender);
            Controls.Add(txtContact);
            Controls.Add(lblContact);
            Controls.Add(txtAge);
            Controls.Add(lblAge);
            Controls.Add(txtStudentName);
            Controls.Add(lblStudentName);
            Name = "Form1";
            Text = "Student Management System";
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudentName;
        private TextBox txtStudentName;
        private Label lblAge;
        private TextBox txtAge;
        private Label lblContact;
        private TextBox txtContact;
        private Label lblGender;
        private ComboBox cmbGender;
        private DateTimePicker dtpDOB;
        private Label lblDOB;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnView;
        private Button btnExport;
        private DataGridView dataGridViewStudents;
        private TextBox txtSearch;
        private Button btnSearch;
    }
}
