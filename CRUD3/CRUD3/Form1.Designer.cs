namespace CRUD3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.sqlView = new System.Windows.Forms.DataGridView();
            this.idTitle = new System.Windows.Forms.Label();
            this.nameTitle = new System.Windows.Forms.Label();
            this.emailTitle = new System.Windows.Forms.Label();
            this.phoneTitle = new System.Windows.Forms.Label();
            this.genderTitle = new System.Windows.Forms.Label();
            this.cityTitle = new System.Windows.Forms.Label();
            this.genderBox = new System.Windows.Forms.ComboBox();
            this.cityBox = new System.Windows.Forms.ComboBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.insertButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.promptBox = new System.Windows.Forms.Label();
            this.aaa = new System.Windows.Forms.Label();
            this.departmentBox = new System.Windows.Forms.ComboBox();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sqlView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(102, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search:";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(160, 9);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(397, 23);
            this.searchBox.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Location = new System.Drawing.Point(563, 9);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(120, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // sqlView
            // 
            this.sqlView.AllowUserToAddRows = false;
            this.sqlView.AllowUserToDeleteRows = false;
            this.sqlView.AllowUserToResizeColumns = false;
            this.sqlView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sqlView.Location = new System.Drawing.Point(12, 38);
            this.sqlView.Name = "sqlView";
            this.sqlView.ReadOnly = true;
            this.sqlView.RowTemplate.Height = 25;
            this.sqlView.Size = new System.Drawing.Size(776, 236);
            this.sqlView.TabIndex = 3;
            this.sqlView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectCell);
            // 
            // idTitle
            // 
            this.idTitle.AutoSize = true;
            this.idTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.idTitle.Location = new System.Drawing.Point(12, 294);
            this.idTitle.Name = "idTitle";
            this.idTitle.Size = new System.Drawing.Size(27, 19);
            this.idTitle.TabIndex = 4;
            this.idTitle.Text = "ID:";
            // 
            // nameTitle
            // 
            this.nameTitle.AutoSize = true;
            this.nameTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameTitle.Location = new System.Drawing.Point(12, 326);
            this.nameTitle.Name = "nameTitle";
            this.nameTitle.Size = new System.Drawing.Size(51, 19);
            this.nameTitle.TabIndex = 5;
            this.nameTitle.Text = "Name:";
            // 
            // emailTitle
            // 
            this.emailTitle.AutoSize = true;
            this.emailTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailTitle.Location = new System.Drawing.Point(12, 358);
            this.emailTitle.Name = "emailTitle";
            this.emailTitle.Size = new System.Drawing.Size(49, 19);
            this.emailTitle.TabIndex = 6;
            this.emailTitle.Text = "Email:";
            // 
            // phoneTitle
            // 
            this.phoneTitle.AutoSize = true;
            this.phoneTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneTitle.Location = new System.Drawing.Point(12, 390);
            this.phoneTitle.Name = "phoneTitle";
            this.phoneTitle.Size = new System.Drawing.Size(53, 19);
            this.phoneTitle.TabIndex = 7;
            this.phoneTitle.Text = "Phone:";
            // 
            // genderTitle
            // 
            this.genderTitle.AutoSize = true;
            this.genderTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.genderTitle.Location = new System.Drawing.Point(12, 422);
            this.genderTitle.Name = "genderTitle";
            this.genderTitle.Size = new System.Drawing.Size(60, 19);
            this.genderTitle.TabIndex = 8;
            this.genderTitle.Text = "Gender:";
            // 
            // cityTitle
            // 
            this.cityTitle.AutoSize = true;
            this.cityTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cityTitle.Location = new System.Drawing.Point(331, 294);
            this.cityTitle.Name = "cityTitle";
            this.cityTitle.Size = new System.Drawing.Size(38, 19);
            this.cityTitle.TabIndex = 9;
            this.cityTitle.Text = "City:";
            // 
            // genderBox
            // 
            this.genderBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genderBox.FormattingEnabled = true;
            this.genderBox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.genderBox.Location = new System.Drawing.Point(78, 422);
            this.genderBox.Name = "genderBox";
            this.genderBox.Size = new System.Drawing.Size(183, 23);
            this.genderBox.TabIndex = 10;
            // 
            // cityBox
            // 
            this.cityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cityBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cityBox.FormattingEnabled = true;
            this.cityBox.Items.AddRange(new object[] {
            "Porto Ferreira",
            "Descalvado",
            "Sao Carlos",
            "Campinas"});
            this.cityBox.Location = new System.Drawing.Point(375, 294);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(183, 23);
            this.cityBox.TabIndex = 11;
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(78, 294);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(113, 23);
            this.idBox.TabIndex = 12;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(78, 326);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(254, 23);
            this.nameBox.TabIndex = 13;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(78, 358);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(254, 23);
            this.emailBox.TabIndex = 14;
            // 
            // phoneBox
            // 
            this.phoneBox.Location = new System.Drawing.Point(78, 390);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(183, 23);
            this.phoneBox.TabIndex = 15;
            // 
            // insertButton
            // 
            this.insertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertButton.Location = new System.Drawing.Point(638, 293);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(120, 23);
            this.insertButton.TabIndex = 16;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Location = new System.Drawing.Point(638, 326);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(120, 23);
            this.updateButton.TabIndex = 17;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Location = new System.Drawing.Point(638, 358);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(120, 23);
            this.deleteButton.TabIndex = 18;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.Location = new System.Drawing.Point(638, 390);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(120, 23);
            this.refreshButton.TabIndex = 19;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // promptBox
            // 
            this.promptBox.AutoSize = true;
            this.promptBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.promptBox.Location = new System.Drawing.Point(12, 277);
            this.promptBox.Name = "promptBox";
            this.promptBox.Size = new System.Drawing.Size(38, 15);
            this.promptBox.TabIndex = 20;
            this.promptBox.Text = "label2";
            // 
            // aaa
            // 
            this.aaa.AutoSize = true;
            this.aaa.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aaa.Location = new System.Drawing.Point(283, 390);
            this.aaa.Name = "aaa";
            this.aaa.Size = new System.Drawing.Size(94, 19);
            this.aaa.TabIndex = 21;
            this.aaa.Text = "Department: ";
            // 
            // departmentBox
            // 
            this.departmentBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.departmentBox.FormattingEnabled = true;
            this.departmentBox.Items.AddRange(new object[] {
            "Programacao",
            "Producao",
            "Financeiro"});
            this.departmentBox.Location = new System.Drawing.Point(374, 390);
            this.departmentBox.Name = "departmentBox";
            this.departmentBox.Size = new System.Drawing.Size(183, 23);
            this.departmentBox.TabIndex = 22;
            // 
            // clearButton
            // 
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Location = new System.Drawing.Point(638, 422);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(120, 23);
            this.clearButton.TabIndex = 23;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.departmentBox);
            this.Controls.Add(this.aaa);
            this.Controls.Add(this.promptBox);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.genderBox);
            this.Controls.Add(this.cityTitle);
            this.Controls.Add(this.genderTitle);
            this.Controls.Add(this.phoneTitle);
            this.Controls.Add(this.emailTitle);
            this.Controls.Add(this.nameTitle);
            this.Controls.Add(this.idTitle);
            this.Controls.Add(this.sqlView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.sqlView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox searchBox;
        private Button searchButton;
        private DataGridView sqlView;
        private Label idTitle;
        private Label nameTitle;
        private Label emailTitle;
        private Label phoneTitle;
        private Label genderTitle;
        private Label cityTitle;
        private ComboBox genderBox;
        private ComboBox cityBox;
        private TextBox idBox;
        private TextBox nameBox;
        private TextBox emailBox;
        private TextBox phoneBox;
        private Button insertButton;
        private Button updateButton;
        private Button deleteButton;
        private Button refreshButton;
        private Label promptBox;
        private Label aaa;
        private ComboBox departmentBox;
        private Button clearButton;
    }
}