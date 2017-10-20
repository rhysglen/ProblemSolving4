namespace ProblemSolving4
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
            this.ContinueLabel = new System.Windows.Forms.Label();
            this.continueButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ContinueLabel
            // 
            this.ContinueLabel.Font = new System.Drawing.Font("OCR A Std", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContinueLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ContinueLabel.Location = new System.Drawing.Point(190, 199);
            this.ContinueLabel.Name = "ContinueLabel";
            this.ContinueLabel.Size = new System.Drawing.Size(293, 62);
            this.ContinueLabel.TabIndex = 0;
            this.ContinueLabel.Text = "Click on Screen to Continue";
            this.ContinueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // continueButton
            // 
            this.continueButton.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueButton.Location = new System.Drawing.Point(290, 275);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(84, 29);
            this.continueButton.TabIndex = 1;
            this.continueButton.Text = "Continue?";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Visible = false;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(679, 506);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.ContinueLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ContinueLabel;
        private System.Windows.Forms.Button continueButton;
    }
}

