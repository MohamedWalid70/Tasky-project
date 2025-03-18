
namespace TaskManagementSystem
{
    partial class ConfirmationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmationForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ConfirmCodeTxt = new System.Windows.Forms.TextBox();
            this.CodeRetryLbl = new System.Windows.Forms.Label();
            this.CodeRetryLbl2 = new System.Windows.Forms.Label();
            this.CodeRetryLinkLbl = new System.Windows.Forms.LinkLabel();
            this.MismatchLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // MainTitle
            // 
            this.MainTitle.AutoSize = true;
            this.MainTitle.Font = new System.Drawing.Font("Roboto Cn", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainTitle.Location = new System.Drawing.Point(85, 18);
            this.MainTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MainTitle.Name = "MainTitle";
            this.MainTitle.Size = new System.Drawing.Size(400, 44);
            this.MainTitle.TabIndex = 24;
            this.MainTitle.Text = "Task Management System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Cn", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(80, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(616, 29);
            this.label1.TabIndex = 26;
            this.label1.Text = "An email with the confirmation code has been sent to your email!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Cn", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(233, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 29);
            this.label2.TabIndex = 27;
            this.label2.Text = "Enter the confirmation code here";
            // 
            // ConfirmCodeTxt
            // 
            this.ConfirmCodeTxt.Font = new System.Drawing.Font("Roboto Cn", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConfirmCodeTxt.Location = new System.Drawing.Point(326, 250);
            this.ConfirmCodeTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ConfirmCodeTxt.Name = "ConfirmCodeTxt";
            this.ConfirmCodeTxt.Size = new System.Drawing.Size(132, 33);
            this.ConfirmCodeTxt.TabIndex = 28;
            this.ConfirmCodeTxt.TextChanged += new System.EventHandler(this.ConfirmCodeTxt_TextChanged);
            // 
            // CodeRetryLbl
            // 
            this.CodeRetryLbl.AutoSize = true;
            this.CodeRetryLbl.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CodeRetryLbl.Location = new System.Drawing.Point(254, 314);
            this.CodeRetryLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CodeRetryLbl.Name = "CodeRetryLbl";
            this.CodeRetryLbl.Size = new System.Drawing.Size(281, 19);
            this.CodeRetryLbl.TabIndex = 29;
            this.CodeRetryLbl.Text = "Confirmation code hasn\'t reached you, yet!";
            // 
            // CodeRetryLbl2
            // 
            this.CodeRetryLbl2.AutoSize = true;
            this.CodeRetryLbl2.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CodeRetryLbl2.Location = new System.Drawing.Point(361, 343);
            this.CodeRetryLbl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CodeRetryLbl2.Name = "CodeRetryLbl2";
            this.CodeRetryLbl2.Size = new System.Drawing.Size(40, 19);
            this.CodeRetryLbl2.TabIndex = 30;
            this.CodeRetryLbl2.Text = "Click";
            // 
            // CodeRetryLinkLbl
            // 
            this.CodeRetryLinkLbl.AutoSize = true;
            this.CodeRetryLinkLbl.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CodeRetryLinkLbl.Location = new System.Drawing.Point(399, 343);
            this.CodeRetryLinkLbl.Name = "CodeRetryLinkLbl";
            this.CodeRetryLinkLbl.Size = new System.Drawing.Size(38, 19);
            this.CodeRetryLinkLbl.TabIndex = 31;
            this.CodeRetryLinkLbl.TabStop = true;
            this.CodeRetryLinkLbl.Text = "Here";
            this.CodeRetryLinkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CodeRetryLinkLbl_LinkClicked);
            // 
            // MismatchLbl
            // 
            this.MismatchLbl.AutoSize = true;
            this.MismatchLbl.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MismatchLbl.ForeColor = System.Drawing.Color.Red;
            this.MismatchLbl.Location = new System.Drawing.Point(343, 286);
            this.MismatchLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MismatchLbl.Name = "MismatchLbl";
            this.MismatchLbl.Size = new System.Drawing.Size(99, 19);
            this.MismatchLbl.TabIndex = 32;
            this.MismatchLbl.Text = "Incorrect code";
            this.MismatchLbl.Visible = false;
            // 
            // ConfirmationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MismatchLbl);
            this.Controls.Add(this.CodeRetryLinkLbl);
            this.Controls.Add(this.CodeRetryLbl2);
            this.Controls.Add(this.CodeRetryLbl);
            this.Controls.Add(this.ConfirmCodeTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MainTitle);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(816, 488);
            this.MinimumSize = new System.Drawing.Size(816, 488);
            this.Name = "ConfirmationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfirmationForm_FormClosing);
            this.Load += new System.EventHandler(this.ConfirmationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label MainTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ConfirmCodeTxt;
        private System.Windows.Forms.Label CodeRetryLbl;
        private System.Windows.Forms.Label CodeRetryLbl2;
        private System.Windows.Forms.LinkLabel CodeRetryLinkLbl;
        private System.Windows.Forms.Label MismatchLbl;
    }
}