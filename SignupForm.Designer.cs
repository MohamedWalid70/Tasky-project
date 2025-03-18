
namespace TaskManagementSystem
{
    partial class SignupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainTitle = new System.Windows.Forms.Label();
            this.PassLbl = new System.Windows.Forms.Label();
            this.PassTxt = new System.Windows.Forms.TextBox();
            this.LastNameLbl = new System.Windows.Forms.Label();
            this.LNameTxt = new System.Windows.Forms.TextBox();
            this.FirstNameLbl = new System.Windows.Forms.Label();
            this.FNameTxt = new System.Windows.Forms.TextBox();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.EmailTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PassConfirmTxt = new System.Windows.Forms.TextBox();
            this.SignUpBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // MainTitle
            // 
            this.MainTitle.AutoSize = true;
            this.MainTitle.Font = new System.Drawing.Font("Roboto Cn", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainTitle.Location = new System.Drawing.Point(74, 9);
            this.MainTitle.Name = "MainTitle";
            this.MainTitle.Size = new System.Drawing.Size(400, 44);
            this.MainTitle.TabIndex = 22;
            this.MainTitle.Text = "Task Management System";
            // 
            // PassLbl
            // 
            this.PassLbl.AutoSize = true;
            this.PassLbl.Font = new System.Drawing.Font("Roboto Cn", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PassLbl.Location = new System.Drawing.Point(177, 301);
            this.PassLbl.Name = "PassLbl";
            this.PassLbl.Size = new System.Drawing.Size(92, 25);
            this.PassLbl.TabIndex = 21;
            this.PassLbl.Text = "Password";
            // 
            // PassTxt
            // 
            this.PassTxt.Font = new System.Drawing.Font("Roboto Cn", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PassTxt.Location = new System.Drawing.Point(312, 298);
            this.PassTxt.Name = "PassTxt";
            this.PassTxt.PlaceholderText = "Must contain alphanumerics";
            this.PassTxt.Size = new System.Drawing.Size(243, 33);
            this.PassTxt.TabIndex = 20;
            this.PassTxt.TextChanged += new System.EventHandler(this.PassTxt_TextChanged);
            // 
            // LastNameLbl
            // 
            this.LastNameLbl.AutoSize = true;
            this.LastNameLbl.Font = new System.Drawing.Font("Roboto Cn", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastNameLbl.Location = new System.Drawing.Point(177, 170);
            this.LastNameLbl.Name = "LastNameLbl";
            this.LastNameLbl.Size = new System.Drawing.Size(101, 25);
            this.LastNameLbl.TabIndex = 19;
            this.LastNameLbl.Text = "Last Name";
            // 
            // LNameTxt
            // 
            this.LNameTxt.Font = new System.Drawing.Font("Roboto Cn", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LNameTxt.Location = new System.Drawing.Point(312, 167);
            this.LNameTxt.Name = "LNameTxt";
            this.LNameTxt.PlaceholderText = "eg: Gamal";
            this.LNameTxt.Size = new System.Drawing.Size(243, 33);
            this.LNameTxt.TabIndex = 18;
            this.LNameTxt.TextChanged += new System.EventHandler(this.LNameTxt_TextChanged);
            // 
            // FirstNameLbl
            // 
            this.FirstNameLbl.AutoSize = true;
            this.FirstNameLbl.Font = new System.Drawing.Font("Roboto Cn", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstNameLbl.Location = new System.Drawing.Point(177, 105);
            this.FirstNameLbl.Name = "FirstNameLbl";
            this.FirstNameLbl.Size = new System.Drawing.Size(102, 25);
            this.FirstNameLbl.TabIndex = 25;
            this.FirstNameLbl.Text = "First Name";
            // 
            // FNameTxt
            // 
            this.FNameTxt.Font = new System.Drawing.Font("Roboto Cn", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FNameTxt.Location = new System.Drawing.Point(312, 102);
            this.FNameTxt.Name = "FNameTxt";
            this.FNameTxt.PlaceholderText = "eg: Alaa";
            this.FNameTxt.Size = new System.Drawing.Size(243, 33);
            this.FNameTxt.TabIndex = 24;
            this.FNameTxt.TextChanged += new System.EventHandler(this.FNameTxt_TextChanged);
            // 
            // EmailLbl
            // 
            this.EmailLbl.AutoSize = true;
            this.EmailLbl.Font = new System.Drawing.Font("Roboto Cn", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailLbl.Location = new System.Drawing.Point(177, 236);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(58, 25);
            this.EmailLbl.TabIndex = 27;
            this.EmailLbl.Text = "Email";
            // 
            // EmailTxt
            // 
            this.EmailTxt.BackColor = System.Drawing.SystemColors.Window;
            this.EmailTxt.Font = new System.Drawing.Font("Roboto Cn", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailTxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.EmailTxt.Location = new System.Drawing.Point(312, 233);
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.PlaceholderText = "eg: abc@gmail.com";
            this.EmailTxt.Size = new System.Drawing.Size(243, 33);
            this.EmailTxt.TabIndex = 26;
            this.EmailTxt.TextChanged += new System.EventHandler(this.EmailTxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Cn", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(177, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "Confirmation";
            // 
            // PassConfirmTxt
            // 
            this.PassConfirmTxt.Font = new System.Drawing.Font("Roboto Cn", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PassConfirmTxt.Location = new System.Drawing.Point(312, 364);
            this.PassConfirmTxt.Name = "PassConfirmTxt";
            this.PassConfirmTxt.PlaceholderText = "Cnfirm you password";
            this.PassConfirmTxt.Size = new System.Drawing.Size(243, 33);
            this.PassConfirmTxt.TabIndex = 28;
            this.PassConfirmTxt.TextChanged += new System.EventHandler(this.PassConfirmTxt_TextChanged);
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SignUpBtn.Location = new System.Drawing.Point(378, 428);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.Size = new System.Drawing.Size(96, 37);
            this.SignUpBtn.TabIndex = 30;
            this.SignUpBtn.Text = "Signup";
            this.SignUpBtn.UseVisualStyleBackColor = true;
            this.SignUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // SignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.SignUpBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PassConfirmTxt);
            this.Controls.Add(this.EmailLbl);
            this.Controls.Add(this.EmailTxt);
            this.Controls.Add(this.FirstNameLbl);
            this.Controls.Add(this.FNameTxt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MainTitle);
            this.Controls.Add(this.PassLbl);
            this.Controls.Add(this.PassTxt);
            this.Controls.Add(this.LastNameLbl);
            this.Controls.Add(this.LNameTxt);
            this.MaximumSize = new System.Drawing.Size(816, 551);
            this.MinimumSize = new System.Drawing.Size(816, 551);
            this.Name = "SignupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account creation";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label MainTitle;
        private System.Windows.Forms.Label PassLbl;
        private System.Windows.Forms.TextBox PassTxt;
        private System.Windows.Forms.Label LastNameLbl;
        private System.Windows.Forms.TextBox LNameTxt;
        private System.Windows.Forms.Label FirstNameLbl;
        private System.Windows.Forms.TextBox FNameTxt;
        private System.Windows.Forms.Label EmailLbl;
        private System.Windows.Forms.TextBox EmailTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PassConfirmTxt;
        private System.Windows.Forms.Button SignUpBtn;
    }
}