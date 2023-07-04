namespace CRUDAdvanced
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.registerDate = new System.Windows.Forms.TextBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.sqlView = new System.Windows.Forms.DataGridView();
            this.searchButton = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.insertButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.tableBox = new System.Windows.Forms.ComboBox();
            this.promptBox = new System.Windows.Forms.Label();
            this.Setor = new System.Windows.Forms.Label();
            this.sectorName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.sqlView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 414);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Preco";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(342, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Descricao:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 454);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Data de Cadastro:";
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(102, 341);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(99, 20);
            this.idBox.TabIndex = 6;
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(432, 343);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(168, 20);
            this.descriptionBox.TabIndex = 8;
            // 
            // registerDate
            // 
            this.registerDate.Enabled = false;
            this.registerDate.Location = new System.Drawing.Point(176, 454);
            this.registerDate.Name = "registerDate";
            this.registerDate.Size = new System.Drawing.Size(168, 20);
            this.registerDate.TabIndex = 10;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(102, 11);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(364, 20);
            this.searchBox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Search:";
            // 
            // sqlView
            // 
            this.sqlView.AllowUserToAddRows = false;
            this.sqlView.AllowUserToDeleteRows = false;
            this.sqlView.AllowUserToResizeColumns = false;
            this.sqlView.AllowUserToResizeRows = false;
            this.sqlView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sqlView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.sqlView.Location = new System.Drawing.Point(12, 37);
            this.sqlView.Name = "sqlView";
            this.sqlView.ReadOnly = true;
            this.sqlView.Size = new System.Drawing.Size(776, 255);
            this.sqlView.TabIndex = 14;
            this.sqlView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickCell);
            // 
            // searchButton
            // 
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Location = new System.Drawing.Point(472, 11);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 15;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(102, 374);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(194, 20);
            this.nameBox.TabIndex = 16;
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(102, 416);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(99, 20);
            this.priceBox.TabIndex = 17;
            // 
            // insertButton
            // 
            this.insertButton.BackColor = System.Drawing.SystemColors.Info;
            this.insertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertButton.Location = new System.Drawing.Point(673, 361);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(75, 23);
            this.insertButton.TabIndex = 18;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = false;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Location = new System.Drawing.Point(673, 390);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 19;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.IndianRed;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Location = new System.Drawing.Point(673, 419);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 20;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // tableBox
            // 
            this.tableBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tableBox.FormattingEnabled = true;
            this.tableBox.Items.AddRange(new object[] {
            "Produtos",
            "Setores"});
            this.tableBox.Location = new System.Drawing.Point(667, 11);
            this.tableBox.Name = "tableBox";
            this.tableBox.Size = new System.Drawing.Size(121, 21);
            this.tableBox.TabIndex = 21;
            this.tableBox.SelectedIndexChanged += new System.EventHandler(this.tableBox_SelectedIndexChanged);
            // 
            // promptBox
            // 
            this.promptBox.AutoSize = true;
            this.promptBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promptBox.Location = new System.Drawing.Point(13, 309);
            this.promptBox.Name = "promptBox";
            this.promptBox.Size = new System.Drawing.Size(72, 19);
            this.promptBox.TabIndex = 22;
            this.promptBox.Text = "Whatever";
            // 
            // Setor
            // 
            this.Setor.AutoSize = true;
            this.Setor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Setor.Location = new System.Drawing.Point(342, 393);
            this.Setor.Name = "Setor";
            this.Setor.Size = new System.Drawing.Size(52, 20);
            this.Setor.TabIndex = 23;
            this.Setor.Text = "Setor:";
            // 
            // sectorName
            // 
            this.sectorName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sectorName.FormattingEnabled = true;
            this.sectorName.Items.AddRange(new object[] {
            "Pedro",
            "Pedro2"});
            this.sectorName.Location = new System.Drawing.Point(432, 395);
            this.sectorName.Name = "sectorName";
            this.sectorName.Size = new System.Drawing.Size(168, 21);
            this.sectorName.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.sectorName);
            this.Controls.Add(this.Setor);
            this.Controls.Add(this.promptBox);
            this.Controls.Add(this.tableBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.sqlView);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.registerDate);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClosedForm);
            ((System.ComponentModel.ISupportInitialize)(this.sqlView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.TextBox registerDate;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView sqlView;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ComboBox tableBox;
        private System.Windows.Forms.Label promptBox;
        private System.Windows.Forms.Label Setor;
        private System.Windows.Forms.ComboBox sectorName;
    }
}

