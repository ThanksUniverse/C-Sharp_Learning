namespace CRUD2
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
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sqlView = new System.Windows.Forms.DataGridView();
            this.searchButton = new System.Windows.Forms.Button();
            this.labelrand = new System.Windows.Forms.Label();
            this.nameBoxasasas = new System.Windows.Forms.Label();
            this.emailBoxasas = new System.Windows.Forms.Label();
            this.phoneBoxasas = new System.Windows.Forms.Label();
            this.genderBoxasas = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.cityBoxasas = new System.Windows.Forms.Label();
            this.cityBox = new System.Windows.Forms.ComboBox();
            this.genderBox = new System.Windows.Forms.ComboBox();
            this.departmentBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.notifyPrompt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.insertButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.phoneBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sqlView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox.Location = new System.Drawing.Point(141, 20);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(384, 23);
            this.searchBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(59, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pesquisar:";
            // 
            // sqlView
            // 
            this.sqlView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sqlView.Location = new System.Drawing.Point(12, 49);
            this.sqlView.Name = "sqlView";
            this.sqlView.RowTemplate.Height = 25;
            this.sqlView.Size = new System.Drawing.Size(776, 246);
            this.sqlView.TabIndex = 3;
            this.sqlView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sqlView_CellClick);
            // 
            // searchButton
            // 
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchButton.Location = new System.Drawing.Point(531, 20);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(120, 23);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Pesquisar";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // labelrand
            // 
            this.labelrand.AutoSize = true;
            this.labelrand.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelrand.Location = new System.Drawing.Point(12, 335);
            this.labelrand.Name = "labelrand";
            this.labelrand.Size = new System.Drawing.Size(27, 19);
            this.labelrand.TabIndex = 5;
            this.labelrand.Text = "ID:";
            // 
            // nameBoxasasas
            // 
            this.nameBoxasasas.AutoSize = true;
            this.nameBoxasasas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameBoxasasas.Location = new System.Drawing.Point(12, 371);
            this.nameBoxasasas.Name = "nameBoxasasas";
            this.nameBoxasasas.Size = new System.Drawing.Size(51, 19);
            this.nameBoxasasas.TabIndex = 6;
            this.nameBoxasasas.Text = "Name:";
            // 
            // emailBoxasas
            // 
            this.emailBoxasas.AutoSize = true;
            this.emailBoxasas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailBoxasas.Location = new System.Drawing.Point(12, 411);
            this.emailBoxasas.Name = "emailBoxasas";
            this.emailBoxasas.Size = new System.Drawing.Size(49, 19);
            this.emailBoxasas.TabIndex = 7;
            this.emailBoxasas.Text = "Email:";
            // 
            // phoneBoxasas
            // 
            this.phoneBoxasas.Location = new System.Drawing.Point(0, 0);
            this.phoneBoxasas.Name = "phoneBoxasas";
            this.phoneBoxasas.Size = new System.Drawing.Size(100, 23);
            this.phoneBoxasas.TabIndex = 0;
            // 
            // genderBoxasas
            // 
            this.genderBoxasas.AutoSize = true;
            this.genderBoxasas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.genderBoxasas.Location = new System.Drawing.Point(12, 493);
            this.genderBoxasas.Name = "genderBoxasas";
            this.genderBoxasas.Size = new System.Drawing.Size(60, 19);
            this.genderBoxasas.TabIndex = 9;
            this.genderBoxasas.Text = "Genero:";
            // 
            // idBox
            // 
            this.idBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idBox.Location = new System.Drawing.Point(102, 336);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(125, 23);
            this.idBox.TabIndex = 10;
            // 
            // nameBox
            // 
            this.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameBox.Location = new System.Drawing.Point(102, 372);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(408, 23);
            this.nameBox.TabIndex = 11;
            // 
            // emailBox
            // 
            this.emailBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailBox.Location = new System.Drawing.Point(102, 412);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(410, 23);
            this.emailBox.TabIndex = 12;
            // 
            // cityBoxasas
            // 
            this.cityBoxasas.AutoSize = true;
            this.cityBoxasas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cityBoxasas.Location = new System.Drawing.Point(259, 335);
            this.cityBoxasas.Name = "cityBoxasas";
            this.cityBoxasas.Size = new System.Drawing.Size(58, 19);
            this.cityBoxasas.TabIndex = 15;
            this.cityBoxasas.Text = "Cidade:";
            // 
            // cityBox
            // 
            this.cityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cityBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cityBox.FormattingEnabled = true;
            this.cityBox.Items.AddRange(new object[] {
            "Porto Ferreira",
            "Descalvado",
            "Sao Carlos"});
            this.cityBox.Location = new System.Drawing.Point(371, 335);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(189, 23);
            this.cityBox.TabIndex = 16;
            // 
            // genderBox
            // 
            this.genderBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.genderBox.FormattingEnabled = true;
            this.genderBox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.genderBox.Location = new System.Drawing.Point(102, 493);
            this.genderBox.Name = "genderBox";
            this.genderBox.Size = new System.Drawing.Size(147, 23);
            this.genderBox.TabIndex = 17;
            // 
            // departmentBox
            // 
            this.departmentBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.departmentBox.FormattingEnabled = true;
            this.departmentBox.Items.AddRange(new object[] {
            "Producao",
            "Programacao",
            "Financeiro"});
            this.departmentBox.Location = new System.Drawing.Point(371, 452);
            this.departmentBox.Name = "departmentBox";
            this.departmentBox.Size = new System.Drawing.Size(189, 23);
            this.departmentBox.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(259, 452);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Departamento:";
            // 
            // notifyPrompt
            // 
            this.notifyPrompt.AutoSize = true;
            this.notifyPrompt.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.notifyPrompt.Location = new System.Drawing.Point(12, 298);
            this.notifyPrompt.Name = "notifyPrompt";
            this.notifyPrompt.Size = new System.Drawing.Size(40, 23);
            this.notifyPrompt.TabIndex = 20;
            this.notifyPrompt.Text = "Text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 456);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "Phone:";
            // 
            // insertButton
            // 
            this.insertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertButton.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.insertButton.Location = new System.Drawing.Point(631, 336);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(120, 23);
            this.insertButton.TabIndex = 22;
            this.insertButton.Text = "Inserir";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateButton.Location = new System.Drawing.Point(631, 372);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(120, 23);
            this.updateButton.TabIndex = 23;
            this.updateButton.Text = "Atualizar";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.Location = new System.Drawing.Point(631, 407);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(120, 23);
            this.deleteButton.TabIndex = 24;
            this.deleteButton.Text = "Deletar";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // phoneBox2
            // 
            this.phoneBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneBox2.Location = new System.Drawing.Point(102, 456);
            this.phoneBox2.Name = "phoneBox2";
            this.phoneBox2.Size = new System.Drawing.Size(125, 23);
            this.phoneBox2.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.phoneBox2);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.notifyPrompt);
            this.Controls.Add(this.departmentBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.genderBox);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.cityBoxasas);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.genderBoxasas);
            this.Controls.Add(this.emailBoxasas);
            this.Controls.Add(this.nameBoxasasas);
            this.Controls.Add(this.labelrand);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.sqlView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicativo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.closedForm);
            ((System.ComponentModel.ISupportInitialize)(this.sqlView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox searchBox;
        private Label label1;
        private DataGridView sqlView;
        private Button searchButton;
        private Label labelrand;
        private Label nameBoxasasas;
        private Label emailBoxasas;
        private Label phoneBoxasas;
        private Label genderBoxasas;
        private TextBox idBox;
        private TextBox nameBox;
        private TextBox emailBox;
        private TextBox phoneBox;
        private Label cityBoxasas;
        private ComboBox cityBox;
        private ComboBox genderBox;
        private ComboBox departmentBox;
        private Label label2;
        private Label notifyPrompt;
        private Label label3;
        private Button insertButton;
        private Button updateButton;
        private Button deleteButton;
        private TextBox phoneBox2;
    }
}