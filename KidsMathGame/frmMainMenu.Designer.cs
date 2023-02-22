
namespace Program5
{
    partial class MainMenuWindow
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
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userAgeLabel = new System.Windows.Forms.Label();
            this.userAgeTextBox = new System.Windows.Forms.TextBox();
            this.userNameErrorLabel = new System.Windows.Forms.Label();
            this.userAgeErrorLabel = new System.Windows.Forms.Label();
            this.userInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.addRadioButton = new System.Windows.Forms.RadioButton();
            this.subtractRadioButton = new System.Windows.Forms.RadioButton();
            this.multiplyRadioButton = new System.Windows.Forms.RadioButton();
            this.divideRadioButton = new System.Windows.Forms.RadioButton();
            this.gameTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.beginGameButton = new System.Windows.Forms.Button();
            this.gameTypeErrorLabel = new System.Windows.Forms.Label();
            this.userInfoGroupBox.SuspendLayout();
            this.gameTypeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(62, 22);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.userNameTextBox.TabIndex = 0;
            this.userNameTextBox.TextChanged += new System.EventHandler(this.userNameTextBox_TextChanged);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.BackColor = System.Drawing.SystemColors.Control;
            this.userNameLabel.Location = new System.Drawing.Point(7, 22);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(49, 17);
            this.userNameLabel.TabIndex = 1;
            this.userNameLabel.Text = "Name:";
            // 
            // userAgeLabel
            // 
            this.userAgeLabel.AutoSize = true;
            this.userAgeLabel.Location = new System.Drawing.Point(10, 57);
            this.userAgeLabel.Name = "userAgeLabel";
            this.userAgeLabel.Size = new System.Drawing.Size(37, 17);
            this.userAgeLabel.TabIndex = 2;
            this.userAgeLabel.Text = "Age:";
            // 
            // userAgeTextBox
            // 
            this.userAgeTextBox.Location = new System.Drawing.Point(62, 57);
            this.userAgeTextBox.MaxLength = 2;
            this.userAgeTextBox.Name = "userAgeTextBox";
            this.userAgeTextBox.Size = new System.Drawing.Size(100, 22);
            this.userAgeTextBox.TabIndex = 3;
            this.userAgeTextBox.TextChanged += new System.EventHandler(this.userAgeTextBox_TextChanged);
            // 
            // userNameErrorLabel
            // 
            this.userNameErrorLabel.AutoSize = true;
            this.userNameErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.userNameErrorLabel.Location = new System.Drawing.Point(169, 26);
            this.userNameErrorLabel.Name = "userNameErrorLabel";
            this.userNameErrorLabel.Size = new System.Drawing.Size(0, 17);
            this.userNameErrorLabel.TabIndex = 4;
            // 
            // userAgeErrorLabel
            // 
            this.userAgeErrorLabel.AutoSize = true;
            this.userAgeErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.userAgeErrorLabel.Location = new System.Drawing.Point(169, 60);
            this.userAgeErrorLabel.Name = "userAgeErrorLabel";
            this.userAgeErrorLabel.Size = new System.Drawing.Size(0, 17);
            this.userAgeErrorLabel.TabIndex = 5;
            // 
            // userInfoGroupBox
            // 
            this.userInfoGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.userInfoGroupBox.Controls.Add(this.userAgeErrorLabel);
            this.userInfoGroupBox.Controls.Add(this.userNameErrorLabel);
            this.userInfoGroupBox.Controls.Add(this.userAgeTextBox);
            this.userInfoGroupBox.Controls.Add(this.userAgeLabel);
            this.userInfoGroupBox.Controls.Add(this.userNameLabel);
            this.userInfoGroupBox.Controls.Add(this.userNameTextBox);
            this.userInfoGroupBox.Location = new System.Drawing.Point(12, 12);
            this.userInfoGroupBox.Name = "userInfoGroupBox";
            this.userInfoGroupBox.Size = new System.Drawing.Size(338, 99);
            this.userInfoGroupBox.TabIndex = 0;
            this.userInfoGroupBox.TabStop = false;
            this.userInfoGroupBox.Text = "User Info";
            // 
            // addRadioButton
            // 
            this.addRadioButton.AutoSize = true;
            this.addRadioButton.Location = new System.Drawing.Point(23, 28);
            this.addRadioButton.Name = "addRadioButton";
            this.addRadioButton.Size = new System.Drawing.Size(54, 21);
            this.addRadioButton.TabIndex = 0;
            this.addRadioButton.TabStop = true;
            this.addRadioButton.Text = "Add";
            this.addRadioButton.UseVisualStyleBackColor = true;
            // 
            // subtractRadioButton
            // 
            this.subtractRadioButton.AutoSize = true;
            this.subtractRadioButton.Location = new System.Drawing.Point(23, 57);
            this.subtractRadioButton.Name = "subtractRadioButton";
            this.subtractRadioButton.Size = new System.Drawing.Size(82, 21);
            this.subtractRadioButton.TabIndex = 1;
            this.subtractRadioButton.TabStop = true;
            this.subtractRadioButton.Text = "Subtract";
            this.subtractRadioButton.UseVisualStyleBackColor = true;
            // 
            // multiplyRadioButton
            // 
            this.multiplyRadioButton.AutoSize = true;
            this.multiplyRadioButton.Location = new System.Drawing.Point(23, 84);
            this.multiplyRadioButton.Name = "multiplyRadioButton";
            this.multiplyRadioButton.Size = new System.Drawing.Size(76, 21);
            this.multiplyRadioButton.TabIndex = 2;
            this.multiplyRadioButton.TabStop = true;
            this.multiplyRadioButton.Text = "Multiply";
            this.multiplyRadioButton.UseVisualStyleBackColor = true;
            // 
            // divideRadioButton
            // 
            this.divideRadioButton.AutoSize = true;
            this.divideRadioButton.Location = new System.Drawing.Point(23, 111);
            this.divideRadioButton.Name = "divideRadioButton";
            this.divideRadioButton.Size = new System.Drawing.Size(68, 21);
            this.divideRadioButton.TabIndex = 3;
            this.divideRadioButton.TabStop = true;
            this.divideRadioButton.Text = "Divide";
            this.divideRadioButton.UseVisualStyleBackColor = true;
            // 
            // gameTypeGroupBox
            // 
            this.gameTypeGroupBox.Controls.Add(this.divideRadioButton);
            this.gameTypeGroupBox.Controls.Add(this.multiplyRadioButton);
            this.gameTypeGroupBox.Controls.Add(this.subtractRadioButton);
            this.gameTypeGroupBox.Controls.Add(this.addRadioButton);
            this.gameTypeGroupBox.Location = new System.Drawing.Point(12, 129);
            this.gameTypeGroupBox.Name = "gameTypeGroupBox";
            this.gameTypeGroupBox.Size = new System.Drawing.Size(200, 149);
            this.gameTypeGroupBox.TabIndex = 1;
            this.gameTypeGroupBox.TabStop = false;
            this.gameTypeGroupBox.Text = "Game Types";
            // 
            // beginGameButton
            // 
            this.beginGameButton.Location = new System.Drawing.Point(270, 186);
            this.beginGameButton.Name = "beginGameButton";
            this.beginGameButton.Size = new System.Drawing.Size(113, 37);
            this.beginGameButton.TabIndex = 2;
            this.beginGameButton.Text = "Begin Game";
            this.beginGameButton.UseVisualStyleBackColor = true;
            this.beginGameButton.Click += new System.EventHandler(this.beginGameButton_Click);
            // 
            // gameTypeErrorLabel
            // 
            this.gameTypeErrorLabel.AutoSize = true;
            this.gameTypeErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.gameTypeErrorLabel.Location = new System.Drawing.Point(35, 285);
            this.gameTypeErrorLabel.Name = "gameTypeErrorLabel";
            this.gameTypeErrorLabel.Size = new System.Drawing.Size(0, 17);
            this.gameTypeErrorLabel.TabIndex = 3;
            // 
            // MainMenuWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 336);
            this.Controls.Add(this.gameTypeErrorLabel);
            this.Controls.Add(this.beginGameButton);
            this.Controls.Add(this.gameTypeGroupBox);
            this.Controls.Add(this.userInfoGroupBox);
            this.Name = "MainMenuWindow";
            this.Text = " MainMenu";
            this.userInfoGroupBox.ResumeLayout(false);
            this.userInfoGroupBox.PerformLayout();
            this.gameTypeGroupBox.ResumeLayout(false);
            this.gameTypeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label userAgeLabel;
        private System.Windows.Forms.TextBox userAgeTextBox;
        private System.Windows.Forms.Label userNameErrorLabel;
        private System.Windows.Forms.Label userAgeErrorLabel;
        private System.Windows.Forms.GroupBox userInfoGroupBox;
        private System.Windows.Forms.RadioButton addRadioButton;
        private System.Windows.Forms.RadioButton subtractRadioButton;
        private System.Windows.Forms.RadioButton multiplyRadioButton;
        private System.Windows.Forms.RadioButton divideRadioButton;
        private System.Windows.Forms.GroupBox gameTypeGroupBox;
        private System.Windows.Forms.Button beginGameButton;
        private System.Windows.Forms.Label gameTypeErrorLabel;
    }
}

