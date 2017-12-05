namespace forms
{
    partial class GameForm
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
            this.browseButton = new System.Windows.Forms.Button();
            this.directoryTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.x64RadioButton = new System.Windows.Forms.RadioButton();
            this.x86RadioButton = new System.Windows.Forms.RadioButton();
            this.addButton = new System.Windows.Forms.Button();
            this.directoryLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.cleanCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(585, 10);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 0;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // directoryTextBox
            // 
            this.directoryTextBox.Location = new System.Drawing.Point(57, 12);
            this.directoryTextBox.Name = "directoryTextBox";
            this.directoryTextBox.Size = new System.Drawing.Size(522, 20);
            this.directoryTextBox.TabIndex = 1;
            this.directoryTextBox.Text = "directory?";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(57, 39);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(198, 20);
            this.nameTextBox.TabIndex = 2;
            this.nameTextBox.Text = "Name";
            // 
            // x64RadioButton
            // 
            this.x64RadioButton.AutoSize = true;
            this.x64RadioButton.Location = new System.Drawing.Point(341, 42);
            this.x64RadioButton.Name = "x64RadioButton";
            this.x64RadioButton.Size = new System.Drawing.Size(74, 17);
            this.x64RadioButton.TabIndex = 3;
            this.x64RadioButton.Text = "x64 - 64bit";
            this.x64RadioButton.UseVisualStyleBackColor = true;
            // 
            // x86RadioButton
            // 
            this.x86RadioButton.AutoSize = true;
            this.x86RadioButton.Checked = true;
            this.x86RadioButton.Location = new System.Drawing.Point(261, 42);
            this.x86RadioButton.Name = "x86RadioButton";
            this.x86RadioButton.Size = new System.Drawing.Size(74, 17);
            this.x86RadioButton.TabIndex = 4;
            this.x86RadioButton.TabStop = true;
            this.x86RadioButton.Text = "x86 - 32bit";
            this.x86RadioButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(504, 39);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(156, 23);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // directoryLabel
            // 
            this.directoryLabel.AutoSize = true;
            this.directoryLabel.Location = new System.Drawing.Point(2, 15);
            this.directoryLabel.Name = "directoryLabel";
            this.directoryLabel.Size = new System.Drawing.Size(49, 13);
            this.directoryLabel.TabIndex = 6;
            this.directoryLabel.Text = "Directory";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 42);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Name";
            // 
            // cleanCheckBox
            // 
            this.cleanCheckBox.AutoSize = true;
            this.cleanCheckBox.Checked = true;
            this.cleanCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cleanCheckBox.Location = new System.Drawing.Point(418, 43);
            this.cleanCheckBox.Name = "cleanCheckBox";
            this.cleanCheckBox.Size = new System.Drawing.Size(77, 17);
            this.cleanCheckBox.TabIndex = 8;
            this.cleanCheckBox.Text = "Auto clean";
            this.cleanCheckBox.UseVisualStyleBackColor = true;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 69);
            this.Controls.Add(this.cleanCheckBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.directoryLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.x86RadioButton);
            this.Controls.Add(this.x64RadioButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.directoryTextBox);
            this.Controls.Add(this.browseButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameForm";
            this.Text = "Game dialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox directoryTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.RadioButton x64RadioButton;
        private System.Windows.Forms.RadioButton x86RadioButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label directoryLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.CheckBox cleanCheckBox;
    }
}