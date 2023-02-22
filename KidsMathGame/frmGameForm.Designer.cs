
namespace Program5
{
    partial class frmGameForm
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.timerLabel = new System.Windows.Forms.Label();
            this.numberOneLabel = new System.Windows.Forms.Label();
            this.numberTwoLabel = new System.Windows.Forms.Label();
            this.mathSignLabel = new System.Windows.Forms.Label();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.equalsLabel = new System.Windows.Forms.Label();
            this.correctOrIncorrectLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(219, 324);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(96, 33);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(90, 324);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(96, 33);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.Location = new System.Drawing.Point(145, 35);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(128, 48);
            this.timerLabel.TabIndex = 2;
            this.timerLabel.Text = "Timer";
            // 
            // numberOneLabel
            // 
            this.numberOneLabel.AutoSize = true;
            this.numberOneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOneLabel.Location = new System.Drawing.Point(71, 120);
            this.numberOneLabel.Name = "numberOneLabel";
            this.numberOneLabel.Size = new System.Drawing.Size(19, 26);
            this.numberOneLabel.TabIndex = 3;
            this.numberOneLabel.Text = "-";
            // 
            // numberTwoLabel
            // 
            this.numberTwoLabel.AutoSize = true;
            this.numberTwoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberTwoLabel.Location = new System.Drawing.Point(214, 120);
            this.numberTwoLabel.Name = "numberTwoLabel";
            this.numberTwoLabel.Size = new System.Drawing.Size(19, 26);
            this.numberTwoLabel.TabIndex = 4;
            this.numberTwoLabel.Text = "-";
            // 
            // mathSignLabel
            // 
            this.mathSignLabel.AutoSize = true;
            this.mathSignLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mathSignLabel.Location = new System.Drawing.Point(135, 120);
            this.mathSignLabel.Name = "mathSignLabel";
            this.mathSignLabel.Size = new System.Drawing.Size(19, 26);
            this.mathSignLabel.TabIndex = 5;
            this.mathSignLabel.Text = "-";
            // 
            // answerTextBox
            // 
            this.answerTextBox.Location = new System.Drawing.Point(331, 124);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(100, 22);
            this.answerTextBox.TabIndex = 6;
            this.answerTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.answerTextBox_KeyPress);
            // 
            // equalsLabel
            // 
            this.equalsLabel.AutoSize = true;
            this.equalsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalsLabel.Location = new System.Drawing.Point(276, 120);
            this.equalsLabel.Name = "equalsLabel";
            this.equalsLabel.Size = new System.Drawing.Size(25, 26);
            this.equalsLabel.TabIndex = 7;
            this.equalsLabel.Text = "=";
            // 
            // correctOrIncorrectLabel
            // 
            this.correctOrIncorrectLabel.AutoSize = true;
            this.correctOrIncorrectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctOrIncorrectLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.correctOrIncorrectLabel.Location = new System.Drawing.Point(167, 217);
            this.correctOrIncorrectLabel.Name = "correctOrIncorrectLabel";
            this.correctOrIncorrectLabel.Size = new System.Drawing.Size(0, 26);
            this.correctOrIncorrectLabel.TabIndex = 8;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(344, 168);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 10;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // frmGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 450);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.correctOrIncorrectLabel);
            this.Controls.Add(this.equalsLabel);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.mathSignLabel);
            this.Controls.Add(this.numberTwoLabel);
            this.Controls.Add(this.numberOneLabel);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.cancelButton);
            this.Name = "frmGameForm";
            this.Text = "Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Label numberOneLabel;
        private System.Windows.Forms.Label numberTwoLabel;
        private System.Windows.Forms.Label mathSignLabel;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Label equalsLabel;
        private System.Windows.Forms.Label correctOrIncorrectLabel;
        private System.Windows.Forms.Button submitButton;
    }
}