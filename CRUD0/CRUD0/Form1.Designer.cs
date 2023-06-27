namespace CRUD0
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.cityBox = new System.Windows.Forms.ComboBox();
            this.genderBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sqlView = new System.Windows.Forms.DataGridView();
            this.insertButton = new System.Windows.Forms.Button();
            this.actualDate = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.tableBox = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sqlView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(211, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "CRUD Operation in C#";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(90, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(90, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(90, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label5.Location = new System.Drawing.Point(90, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gender";
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(211, 52);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(242, 23);
            this.idBox.TabIndex = 5;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(211, 84);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(242, 23);
            this.nameBox.TabIndex = 6;
            // 
            // cityBox
            // 
            this.cityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cityBox.FormattingEnabled = true;
            this.cityBox.Items.AddRange(new object[] {
            "Porto Ferreira",
            "Descalvado"});
            this.cityBox.Location = new System.Drawing.Point(211, 113);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(242, 23);
            this.cityBox.TabIndex = 7;
            // 
            // genderBox
            // 
            this.genderBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderBox.FormattingEnabled = true;
            this.genderBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderBox.Location = new System.Drawing.Point(211, 142);
            this.genderBox.Name = "genderBox";
            this.genderBox.Size = new System.Drawing.Size(242, 23);
            this.genderBox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label6.Location = new System.Drawing.Point(90, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Create Date";
            // 
            // sqlView
            // 
            this.sqlView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.sqlView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sqlView.Location = new System.Drawing.Point(12, 239);
            this.sqlView.Name = "sqlView";
            this.sqlView.RowTemplate.Height = 25;
            this.sqlView.Size = new System.Drawing.Size(661, 166);
            this.sqlView.TabIndex = 11;
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(90, 210);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(113, 23);
            this.insertButton.TabIndex = 12;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // actualDate
            // 
            this.actualDate.AutoSize = true;
            this.actualDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.actualDate.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.actualDate.Location = new System.Drawing.Point(211, 173);
            this.actualDate.Name = "actualDate";
            this.actualDate.Size = new System.Drawing.Size(91, 21);
            this.actualDate.TabIndex = 13;
            this.actualDate.Text = "Create Date";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(209, 210);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(113, 23);
            this.updateButton.TabIndex = 14;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(328, 210);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(113, 23);
            this.deleteButton.TabIndex = 15;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(284, 194);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 15);
            this.outputLabel.TabIndex = 16;
            // 
            // tableBox
            // 
            this.tableBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tableBox.FormattingEnabled = true;
            this.tableBox.Items.AddRange(new object[] {
            "Users"});
            this.tableBox.Location = new System.Drawing.Point(523, 210);
            this.tableBox.Name = "tableBox";
            this.tableBox.Size = new System.Drawing.Size(150, 23);
            this.tableBox.TabIndex = 17;
            this.tableBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(459, 51);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(113, 23);
            this.searchButton.TabIndex = 18;
            this.searchButton.Text = "Search ID";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(459, 209);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(58, 23);
            this.refreshButton.TabIndex = 19;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(685, 417);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.tableBox);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.actualDate);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.sqlView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.genderBox);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD";
            ((System.ComponentModel.ISupportInitialize)(this.sqlView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox idBox;
        private TextBox nameBox;
        private ComboBox cityBox;
        private ComboBox genderBox;
        private Label label6;
        private DataGridView sqlView;
        private Button insertButton;
        private Label actualDate;
        private Button updateButton;
        private Button deleteButton;
        private Label outputLabel;
        private ComboBox tableBox;
        private Button searchButton;
        private Button refreshButton;
    }
}