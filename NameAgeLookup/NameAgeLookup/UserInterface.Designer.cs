namespace NameAgeLookup
{
    partial class UserInterface
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
            this.uxSaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.uxOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.uxNameLabel = new System.Windows.Forms.Label();
            this.uxAgeLabel = new System.Windows.Forms.Label();
            this.uxName = new System.Windows.Forms.TextBox();
            this.uxAge = new System.Windows.Forms.TextBox();
            this.uxLookup = new System.Windows.Forms.Button();
            this.uxUpdate = new System.Windows.Forms.Button();
            this.uxFile = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxOpenMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.uxSaveMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.uxFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxNameLabel
            // 
            this.uxNameLabel.AutoSize = true;
            this.uxNameLabel.Location = new System.Drawing.Point(15, 52);
            this.uxNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.uxNameLabel.Name = "uxNameLabel";
            this.uxNameLabel.Size = new System.Drawing.Size(66, 24);
            this.uxNameLabel.TabIndex = 0;
            this.uxNameLabel.Text = "Name:";
            // 
            // uxAgeLabel
            // 
            this.uxAgeLabel.AutoSize = true;
            this.uxAgeLabel.Location = new System.Drawing.Point(15, 96);
            this.uxAgeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.uxAgeLabel.Name = "uxAgeLabel";
            this.uxAgeLabel.Size = new System.Drawing.Size(50, 24);
            this.uxAgeLabel.TabIndex = 1;
            this.uxAgeLabel.Text = "Age:";
            // 
            // uxName
            // 
            this.uxName.Location = new System.Drawing.Point(93, 52);
            this.uxName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.uxName.Name = "uxName";
            this.uxName.Size = new System.Drawing.Size(265, 29);
            this.uxName.TabIndex = 2;
            // 
            // uxAge
            // 
            this.uxAge.Location = new System.Drawing.Point(93, 96);
            this.uxAge.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.uxAge.Name = "uxAge";
            this.uxAge.Size = new System.Drawing.Size(265, 29);
            this.uxAge.TabIndex = 3;
            // 
            // uxLookup
            // 
            this.uxLookup.Location = new System.Drawing.Point(53, 167);
            this.uxLookup.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.uxLookup.Name = "uxLookup";
            this.uxLookup.Size = new System.Drawing.Size(138, 42);
            this.uxLookup.TabIndex = 4;
            this.uxLookup.Text = "Lookup";
            this.uxLookup.UseVisualStyleBackColor = true;
            this.uxLookup.Click += new System.EventHandler(this.uxLookup_Click);
            // 
            // uxUpdate
            // 
            this.uxUpdate.Location = new System.Drawing.Point(203, 167);
            this.uxUpdate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.uxUpdate.Name = "uxUpdate";
            this.uxUpdate.Size = new System.Drawing.Size(138, 42);
            this.uxUpdate.TabIndex = 5;
            this.uxUpdate.Text = "Update";
            this.uxUpdate.UseVisualStyleBackColor = true;
            // 
            // uxFile
            // 
            this.uxFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.uxFile.Location = new System.Drawing.Point(0, 0);
            this.uxFile.Name = "uxFile";
            this.uxFile.Size = new System.Drawing.Size(383, 24);
            this.uxFile.TabIndex = 6;
            this.uxFile.Text = "File";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxOpenMenu,
            this.uxSaveMenu});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // uxOpenMenu
            // 
            this.uxOpenMenu.Name = "uxOpenMenu";
            this.uxOpenMenu.Size = new System.Drawing.Size(152, 22);
            this.uxOpenMenu.Text = "Open...";
            this.uxOpenMenu.Click += new System.EventHandler(this.OpenFile);
            // 
            // uxSaveMenu
            // 
            this.uxSaveMenu.Name = "uxSaveMenu";
            this.uxSaveMenu.Size = new System.Drawing.Size(152, 22);
            this.uxSaveMenu.Text = "Save...";
            this.uxSaveMenu.Click += new System.EventHandler(this.SaveFile);
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 224);
            this.Controls.Add(this.uxUpdate);
            this.Controls.Add(this.uxLookup);
            this.Controls.Add(this.uxAge);
            this.Controls.Add(this.uxName);
            this.Controls.Add(this.uxAgeLabel);
            this.Controls.Add(this.uxNameLabel);
            this.Controls.Add(this.uxFile);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.uxFile;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "UserInterface";
            this.Text = "Name and Age Lookup";
            this.uxFile.ResumeLayout(false);
            this.uxFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog uxSaveDialog;
        private System.Windows.Forms.OpenFileDialog uxOpenDialog;
        private System.Windows.Forms.Label uxNameLabel;
        private System.Windows.Forms.Label uxAgeLabel;
        private System.Windows.Forms.TextBox uxName;
        private System.Windows.Forms.TextBox uxAge;
        private System.Windows.Forms.Button uxLookup;
        private System.Windows.Forms.Button uxUpdate;
        private System.Windows.Forms.MenuStrip uxFile;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uxOpenMenu;
        private System.Windows.Forms.ToolStripMenuItem uxSaveMenu;
    }
}

