namespace T_SQLGame
{
    partial class GameWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWindow));
            this.allCharacters = new System.Windows.Forms.DataGridView();
            this.characterName = new System.Windows.Forms.Label();
            this.HEALTH = new System.Windows.Forms.Label();
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.LEVEL = new System.Windows.Forms.Label();
            this.itLevel = new System.Windows.Forms.LinkLabel();
            this.EXPERIENCE = new System.Windows.Forms.Label();
            this.itExperience = new System.Windows.Forms.LinkLabel();
            this.fightButton = new System.Windows.Forms.Button();
            this.lootButton = new System.Windows.Forms.Button();
            this.healButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.eventLogs = new System.Windows.Forms.ListBox();
            this.playersInfo = new System.Windows.Forms.Button();
            this.playerItems = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.allCharacters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // allCharacters
            // 
            this.allCharacters.BackgroundColor = System.Drawing.Color.Silver;
            this.allCharacters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allCharacters.Location = new System.Drawing.Point(16, 208);
            this.allCharacters.Name = "allCharacters";
            this.allCharacters.Size = new System.Drawing.Size(965, 133);
            this.allCharacters.TabIndex = 0;
            // 
            // characterName
            // 
            this.characterName.AutoSize = true;
            this.characterName.Font = new System.Drawing.Font("Fira Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterName.Location = new System.Drawing.Point(68, 8);
            this.characterName.Name = "characterName";
            this.characterName.Size = new System.Drawing.Size(111, 16);
            this.characterName.TabIndex = 1;
            this.characterName.Text = "CharacterName";
            // 
            // HEALTH
            // 
            this.HEALTH.AutoSize = true;
            this.HEALTH.Location = new System.Drawing.Point(16, 36);
            this.HEALTH.Name = "HEALTH";
            this.HEALTH.Size = new System.Drawing.Size(49, 15);
            this.HEALTH.TabIndex = 2;
            this.HEALTH.Text = "Health";
            // 
            // healthBar
            // 
            this.healthBar.ForeColor = System.Drawing.Color.GreenYellow;
            this.healthBar.Location = new System.Drawing.Point(71, 36);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(148, 15);
            this.healthBar.TabIndex = 3;
            // 
            // LEVEL
            // 
            this.LEVEL.AutoSize = true;
            this.LEVEL.Location = new System.Drawing.Point(16, 64);
            this.LEVEL.Name = "LEVEL";
            this.LEVEL.Size = new System.Drawing.Size(42, 15);
            this.LEVEL.TabIndex = 4;
            this.LEVEL.Text = "Level";
            // 
            // itLevel
            // 
            this.itLevel.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.itLevel.AutoSize = true;
            this.itLevel.BackColor = System.Drawing.Color.Transparent;
            this.itLevel.CausesValidation = false;
            this.itLevel.Enabled = false;
            this.itLevel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.itLevel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.itLevel.LinkColor = System.Drawing.Color.Black;
            this.itLevel.Location = new System.Drawing.Point(68, 64);
            this.itLevel.Name = "itLevel";
            this.itLevel.Size = new System.Drawing.Size(14, 15);
            this.itLevel.TabIndex = 5;
            this.itLevel.TabStop = true;
            this.itLevel.Text = "0";
            // 
            // EXPERIENCE
            // 
            this.EXPERIENCE.AutoSize = true;
            this.EXPERIENCE.Location = new System.Drawing.Point(16, 91);
            this.EXPERIENCE.Name = "EXPERIENCE";
            this.EXPERIENCE.Size = new System.Drawing.Size(77, 15);
            this.EXPERIENCE.TabIndex = 6;
            this.EXPERIENCE.Text = "Experience";
            // 
            // itExperience
            // 
            this.itExperience.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.itExperience.AutoSize = true;
            this.itExperience.BackColor = System.Drawing.Color.Transparent;
            this.itExperience.CausesValidation = false;
            this.itExperience.Enabled = false;
            this.itExperience.ForeColor = System.Drawing.SystemColors.ControlText;
            this.itExperience.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.itExperience.LinkColor = System.Drawing.Color.Black;
            this.itExperience.Location = new System.Drawing.Point(99, 91);
            this.itExperience.Name = "itExperience";
            this.itExperience.Size = new System.Drawing.Size(56, 15);
            this.itExperience.TabIndex = 7;
            this.itExperience.TabStop = true;
            this.itExperience.Text = "0 / 100";
            // 
            // fightButton
            // 
            this.fightButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fightButton.ForeColor = System.Drawing.Color.Maroon;
            this.fightButton.Location = new System.Drawing.Point(16, 121);
            this.fightButton.Name = "fightButton";
            this.fightButton.Size = new System.Drawing.Size(75, 23);
            this.fightButton.TabIndex = 8;
            this.fightButton.Text = "Fight";
            this.fightButton.UseVisualStyleBackColor = true;
            this.fightButton.Click += new System.EventHandler(this.fightButton_Click);
            // 
            // lootButton
            // 
            this.lootButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lootButton.ForeColor = System.Drawing.Color.White;
            this.lootButton.Location = new System.Drawing.Point(97, 121);
            this.lootButton.Name = "lootButton";
            this.lootButton.Size = new System.Drawing.Size(75, 23);
            this.lootButton.TabIndex = 9;
            this.lootButton.Text = "Loot";
            this.lootButton.UseVisualStyleBackColor = true;
            this.lootButton.Click += new System.EventHandler(this.lootButton_Click);
            // 
            // healButton
            // 
            this.healButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.healButton.ForeColor = System.Drawing.Color.Green;
            this.healButton.Location = new System.Drawing.Point(178, 121);
            this.healButton.Name = "healButton";
            this.healButton.Size = new System.Drawing.Size(75, 23);
            this.healButton.TabIndex = 10;
            this.healButton.Text = "Heal";
            this.healButton.UseVisualStyleBackColor = true;
            this.healButton.Click += new System.EventHandler(this.healButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveButton.ForeColor = System.Drawing.Color.Yellow;
            this.saveButton.Location = new System.Drawing.Point(61, 152);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(148, 23);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // eventLogs
            // 
            this.eventLogs.BackColor = System.Drawing.Color.Black;
            this.eventLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eventLogs.ForeColor = System.Drawing.Color.White;
            this.eventLogs.FormattingEnabled = true;
            this.eventLogs.ItemHeight = 15;
            this.eventLogs.Location = new System.Drawing.Point(263, 12);
            this.eventLogs.Name = "eventLogs";
            this.eventLogs.Size = new System.Drawing.Size(322, 150);
            this.eventLogs.TabIndex = 12;
            // 
            // playersInfo
            // 
            this.playersInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.playersInfo.ForeColor = System.Drawing.Color.White;
            this.playersInfo.Location = new System.Drawing.Point(263, 168);
            this.playersInfo.Name = "playersInfo";
            this.playersInfo.Size = new System.Drawing.Size(322, 28);
            this.playersInfo.TabIndex = 13;
            this.playersInfo.Text = "Update Players";
            this.playersInfo.UseVisualStyleBackColor = true;
            this.playersInfo.Click += new System.EventHandler(this.playersInfo_Click);
            // 
            // playerItems
            // 
            this.playerItems.AutoSize = true;
            this.playerItems.Font = new System.Drawing.Font("Fira Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerItems.Location = new System.Drawing.Point(735, 8);
            this.playerItems.Name = "playerItems";
            this.playerItems.Size = new System.Drawing.Size(103, 16);
            this.playerItems.TabIndex = 14;
            this.playerItems.Text = "Player Items";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(602, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(375, 169);
            this.dataGridView1.TabIndex = 15;
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(989, 367);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.playerItems);
            this.Controls.Add(this.playersInfo);
            this.Controls.Add(this.eventLogs);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.healButton);
            this.Controls.Add(this.lootButton);
            this.Controls.Add(this.fightButton);
            this.Controls.Add(this.itExperience);
            this.Controls.Add(this.EXPERIENCE);
            this.Controls.Add(this.itLevel);
            this.Controls.Add(this.LEVEL);
            this.Controls.Add(this.healthBar);
            this.Controls.Add(this.HEALTH);
            this.Controls.Add(this.characterName);
            this.Controls.Add(this.allCharacters);
            this.Font = new System.Drawing.Font("Fira Code", 8.999999F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQLGame";
            ((System.ComponentModel.ISupportInitialize)(this.allCharacters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView allCharacters;
        private System.Windows.Forms.Label characterName;
        private System.Windows.Forms.Label HEALTH;
        private System.Windows.Forms.ProgressBar healthBar;
        private System.Windows.Forms.Label LEVEL;
        private System.Windows.Forms.LinkLabel itLevel;
        private System.Windows.Forms.Label EXPERIENCE;
        private System.Windows.Forms.LinkLabel itExperience;
        private System.Windows.Forms.Button fightButton;
        private System.Windows.Forms.Button lootButton;
        private System.Windows.Forms.Button healButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ListBox eventLogs;
        private System.Windows.Forms.Button playersInfo;
        private System.Windows.Forms.Label playerItems;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

