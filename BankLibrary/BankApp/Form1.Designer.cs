namespace BankApp
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
            this.btnWithdrawForm = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnWithdrawForm
            // 
            this.btnWithdrawForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btnWithdrawForm.Location = new System.Drawing.Point(680, 180);
            this.btnWithdrawForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnWithdrawForm.Name = "btnWithdrawForm";
            this.btnWithdrawForm.Size = new System.Drawing.Size(362, 125);
            this.btnWithdrawForm.TabIndex = 0;
            this.btnWithdrawForm.Text = "Withdraw";
            this.btnWithdrawForm.UseVisualStyleBackColor = true;
            this.btnWithdrawForm.Click += new System.EventHandler(this.btnWithdrawForm_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btnExit.Location = new System.Drawing.Point(680, 366);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(362, 125);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.label1.Location = new System.Drawing.Point(528, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(696, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to rob0rt\'s ATM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1738, 1051);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnWithdrawForm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWithdrawForm;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
    }
}