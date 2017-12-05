namespace forms
{
    partial class MainForm
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
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.gamesListBox = new System.Windows.Forms.ListBox();
            this.editButton = new System.Windows.Forms.Button();
            this.editGlobalCfgButton = new System.Windows.Forms.Button();
            this.cleanButton = new System.Windows.Forms.Button();
            this.cleanGlobalButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addButton.Location = new System.Drawing.Point(209, 208);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(82, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add game";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeButton.Location = new System.Drawing.Point(12, 208);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(100, 23);
            this.removeButton.TabIndex = 2;
            this.removeButton.Text = "Remove game";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // gamesListBox
            // 
            this.gamesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gamesListBox.FormattingEnabled = true;
            this.gamesListBox.Location = new System.Drawing.Point(12, 12);
            this.gamesListBox.Name = "gamesListBox";
            this.gamesListBox.Size = new System.Drawing.Size(279, 186);
            this.gamesListBox.TabIndex = 3;
            this.gamesListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gamesListBox_MouseDoubleClick);
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editButton.Location = new System.Drawing.Point(118, 208);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(85, 23);
            this.editButton.TabIndex = 4;
            this.editButton.Text = "Edit game";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // editGlobalCfgButton
            // 
            this.editGlobalCfgButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editGlobalCfgButton.Location = new System.Drawing.Point(12, 237);
            this.editGlobalCfgButton.Name = "editGlobalCfgButton";
            this.editGlobalCfgButton.Size = new System.Drawing.Size(100, 23);
            this.editGlobalCfgButton.TabIndex = 5;
            this.editGlobalCfgButton.Text = "Edit global";
            this.editGlobalCfgButton.UseVisualStyleBackColor = true;
            this.editGlobalCfgButton.Click += new System.EventHandler(this.editGlobalCfgButton_Click);
            // 
            // cleanButton
            // 
            this.cleanButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cleanButton.Location = new System.Drawing.Point(209, 237);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(82, 23);
            this.cleanButton.TabIndex = 6;
            this.cleanButton.Text = "Clean game";
            this.cleanButton.UseVisualStyleBackColor = true;
            this.cleanButton.Click += new System.EventHandler(this.cleanButton_Click);
            // 
            // cleanGlobalButton
            // 
            this.cleanGlobalButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cleanGlobalButton.Location = new System.Drawing.Point(118, 237);
            this.cleanGlobalButton.Name = "cleanGlobalButton";
            this.cleanGlobalButton.Size = new System.Drawing.Size(85, 23);
            this.cleanGlobalButton.TabIndex = 7;
            this.cleanGlobalButton.Text = "Clean global cfg";
            this.cleanGlobalButton.UseVisualStyleBackColor = true;
            this.cleanGlobalButton.Click += new System.EventHandler(this.cleanGlobalButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 265);
            this.Controls.Add(this.cleanGlobalButton);
            this.Controls.Add(this.cleanButton);
            this.Controls.Add(this.editGlobalCfgButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.gamesListBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Name = "MainForm";
            this.Text = "x360ce Helper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.ListBox gamesListBox;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button editGlobalCfgButton;
        private System.Windows.Forms.Button cleanButton;
        private System.Windows.Forms.Button cleanGlobalButton;
    }
}

