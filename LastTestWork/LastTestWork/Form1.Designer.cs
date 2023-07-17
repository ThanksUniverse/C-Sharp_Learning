namespace LastTestWork
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
            this.aasasas = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.sqlView = new System.Windows.Forms.DataGridView();
            this.tableBox = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.asasasasas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.registerDate = new System.Windows.Forms.TextBox();
            this.updateDate = new System.Windows.Forms.TextBox();
            this.insertButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.promptMessages = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sqlView)).BeginInit();
            this.SuspendLayout();
            // 
            // aasasas
            // 
            this.aasasas.AutoSize = true;
            this.aasasas.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aasasas.Location = new System.Drawing.Point(12, 9);
            this.aasasas.Name = "aasasas";
            this.aasasas.Size = new System.Drawing.Size(69, 20);
            this.aasasas.TabIndex = 0;
            this.aasasas.Text = "Search";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(87, 6);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(260, 23);
            this.searchBox.TabIndex = 1;
            // 
            // sqlView
            // 
            this.sqlView.AllowUserToAddRows = false;
            this.sqlView.AllowUserToDeleteRows = false;
            this.sqlView.AllowUserToOrderColumns = true;
            this.sqlView.AllowUserToResizeColumns = false;
            this.sqlView.AllowUserToResizeRows = false;
            this.sqlView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sqlView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sqlView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.sqlView.Location = new System.Drawing.Point(12, 35);
            this.sqlView.Name = "sqlView";
            this.sqlView.ReadOnly = true;
            this.sqlView.RowTemplate.Height = 25;
            this.sqlView.Size = new System.Drawing.Size(776, 236);
            this.sqlView.TabIndex = 2;
            this.sqlView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UpdateOnClick);
            // 
            // tableBox
            // 
            this.tableBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tableBox.Font = new System.Drawing.Font("Fira Code Retina", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tableBox.FormattingEnabled = true;
            this.tableBox.Items.AddRange(new object[] {
            "Product",
            "Person"});
            this.tableBox.Location = new System.Drawing.Point(576, 6);
            this.tableBox.Name = "tableBox";
            this.tableBox.Size = new System.Drawing.Size(212, 24);
            this.tableBox.TabIndex = 3;
            this.tableBox.SelectedIndexChanged += new System.EventHandler(this.TablesBoxUpdate);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Location = new System.Drawing.Point(353, 6);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 23);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // asasasasas
            // 
            this.asasasasas.AutoSize = true;
            this.asasasasas.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.asasasasas.Location = new System.Drawing.Point(67, 285);
            this.asasasasas.Name = "asasasasas";
            this.asasasasas.Size = new System.Drawing.Size(39, 20);
            this.asasasasas.TabIndex = 5;
            this.asasasasas.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(57, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceLabel.Location = new System.Drawing.Point(52, 355);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(69, 20);
            this.priceLabel.TabIndex = 7;
            this.priceLabel.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Register Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Update Date:";
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(172, 285);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(144, 23);
            this.idBox.TabIndex = 10;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(172, 320);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(175, 23);
            this.nameBox.TabIndex = 11;
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(172, 355);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(175, 23);
            this.priceBox.TabIndex = 12;
            // 
            // registerDate
            // 
            this.registerDate.Enabled = false;
            this.registerDate.Location = new System.Drawing.Point(172, 390);
            this.registerDate.Name = "registerDate";
            this.registerDate.Size = new System.Drawing.Size(164, 23);
            this.registerDate.TabIndex = 13;
            // 
            // updateDate
            // 
            this.updateDate.Enabled = false;
            this.updateDate.Location = new System.Drawing.Point(172, 425);
            this.updateDate.Name = "updateDate";
            this.updateDate.Size = new System.Drawing.Size(164, 23);
            this.updateDate.TabIndex = 14;
            // 
            // insertButton
            // 
            this.insertButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.insertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertButton.ForeColor = System.Drawing.Color.Black;
            this.insertButton.Location = new System.Drawing.Point(651, 320);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(100, 23);
            this.insertButton.TabIndex = 15;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = false;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Location = new System.Drawing.Point(651, 355);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(100, 23);
            this.updateButton.TabIndex = 16;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Location = new System.Drawing.Point(651, 390);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(100, 23);
            this.deleteButton.TabIndex = 17;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // promptMessages
            // 
            this.promptMessages.AutoSize = true;
            this.promptMessages.Font = new System.Drawing.Font("Fira Code Retina", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.promptMessages.Location = new System.Drawing.Point(353, 285);
            this.promptMessages.Name = "promptMessages";
            this.promptMessages.Size = new System.Drawing.Size(127, 13);
            this.promptMessages.TabIndex = 18;
            this.promptMessages.Text = "Prompt Messages";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.promptMessages);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.updateDate);
            this.Controls.Add(this.registerDate);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.asasasasas);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.tableBox);
            this.Controls.Add(this.sqlView);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.aasasas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.sqlView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label aasasas;
        private TextBox searchBox;
        private DataGridView sqlView;
        private ComboBox tableBox;
        private Button searchButton;
        private Label asasasasas;
        private Label label1;
        private Label priceLabel;
        private Label label3;
        private Label label4;
        private TextBox idBox;
        private TextBox nameBox;
        private TextBox priceBox;
        private TextBox registerDate;
        private TextBox updateDate;
        private Button insertButton;
        private Button updateButton;
        private Button deleteButton;
        private Label promptMessages;
    }
}