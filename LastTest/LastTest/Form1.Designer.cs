namespace LastTest
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
            this.sqlView = new System.Windows.Forms.DataGridView();
            this.commandBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.executeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sqlView)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlView
            // 
            this.sqlView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sqlView.Location = new System.Drawing.Point(12, 122);
            this.sqlView.Name = "sqlView";
            this.sqlView.RowTemplate.Height = 25;
            this.sqlView.Size = new System.Drawing.Size(776, 172);
            this.sqlView.TabIndex = 0;
            // 
            // commandBox
            // 
            this.commandBox.Location = new System.Drawing.Point(12, 37);
            this.commandBox.Multiline = true;
            this.commandBox.Name = "commandBox";
            this.commandBox.Size = new System.Drawing.Size(776, 79);
            this.commandBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Write your command and press apply";
            // 
            // executeButton
            // 
            this.executeButton.Location = new System.Drawing.Point(223, 15);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(565, 23);
            this.executeButton.TabIndex = 3;
            this.executeButton.Text = "Execute";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 307);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.commandBox);
            this.Controls.Add(this.sqlView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.sqlView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView sqlView;
        private TextBox commandBox;
        private Label label1;
        private Button executeButton;
    }
}