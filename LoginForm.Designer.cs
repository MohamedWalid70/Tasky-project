
namespace TaskManagementSystem
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.EmailTxt = new System.Windows.Forms.TextBox();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.PassLbl = new System.Windows.Forms.Label();
            this.PassTxt = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainTitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SignupLinkLabel = new System.Windows.Forms.LinkLabel();
            this.PassSeeUnseePic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassSeeUnseePic)).BeginInit();
            this.SuspendLayout();
            // 
            // EmailTxt
            // 
            this.EmailTxt.Font = new System.Drawing.Font("Roboto Cn", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailTxt.Location = new System.Drawing.Point(303, 148);
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.PlaceholderText = "Enter your email";
            this.EmailTxt.Size = new System.Drawing.Size(243, 33);
            this.EmailTxt.TabIndex = 0;
            // 
            // EmailLbl
            // 
            this.EmailLbl.AutoSize = true;
            this.EmailLbl.Font = new System.Drawing.Font("Roboto Cn", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailLbl.Location = new System.Drawing.Point(185, 151);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(58, 25);
            this.EmailLbl.TabIndex = 1;
            this.EmailLbl.Text = "Email";
            // 
            // PassLbl
            // 
            this.PassLbl.AutoSize = true;
            this.PassLbl.Font = new System.Drawing.Font("Roboto Cn", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PassLbl.Location = new System.Drawing.Point(185, 222);
            this.PassLbl.Name = "PassLbl";
            this.PassLbl.Size = new System.Drawing.Size(92, 25);
            this.PassLbl.TabIndex = 3;
            this.PassLbl.Text = "Password";
            // 
            // PassTxt
            // 
            this.PassTxt.Font = new System.Drawing.Font("Roboto Cn", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PassTxt.Location = new System.Drawing.Point(303, 219);
            this.PassTxt.Name = "PassTxt";
            this.PassTxt.PasswordChar = '*';
            this.PassTxt.PlaceholderText = "Enter your password";
            this.PassTxt.Size = new System.Drawing.Size(243, 33);
            this.PassTxt.TabIndex = 2;
            // 
            // LoginBtn
            // 
            this.LoginBtn.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginBtn.Location = new System.Drawing.Point(374, 283);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(96, 37);
            this.LoginBtn.TabIndex = 4;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // MainTitle
            // 
            this.MainTitle.AutoSize = true;
            this.MainTitle.Font = new System.Drawing.Font("Roboto Cn", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainTitle.Location = new System.Drawing.Point(76, 9);
            this.MainTitle.Name = "MainTitle";
            this.MainTitle.Size = new System.Drawing.Size(400, 44);
            this.MainTitle.TabIndex = 16;
            this.MainTitle.Text = "Task Management System";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Don\'t have an account yet ?";
            // 
            // SignupLinkLabel
            // 
            this.SignupLinkLabel.AutoSize = true;
            this.SignupLinkLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignupLinkLabel.Location = new System.Drawing.Point(401, 350);
            this.SignupLinkLabel.Name = "SignupLinkLabel";
            this.SignupLinkLabel.Size = new System.Drawing.Size(44, 15);
            this.SignupLinkLabel.TabIndex = 19;
            this.SignupLinkLabel.TabStop = true;
            this.SignupLinkLabel.Text = "Signup";
            this.SignupLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignupLinkLabel_LinkClicked);
            // 
            // PassSeeUnseePic
            // 
            this.PassSeeUnseePic.BackColor = System.Drawing.SystemColors.Window;
            this.PassSeeUnseePic.BackgroundImage = global::TaskManagementSystem.Properties.Resources.eye;
            this.PassSeeUnseePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PassSeeUnseePic.Location = new System.Drawing.Point(515, 224);
            this.PassSeeUnseePic.Name = "PassSeeUnseePic";
            this.PassSeeUnseePic.Size = new System.Drawing.Size(21, 23);
            this.PassSeeUnseePic.TabIndex = 20;
            this.PassSeeUnseePic.TabStop = false;
            this.PassSeeUnseePic.Click += new System.EventHandler(this.PassSeeUnseePic_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PassSeeUnseePic);
            this.Controls.Add(this.SignupLinkLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MainTitle);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PassLbl);
            this.Controls.Add(this.PassTxt);
            this.Controls.Add(this.EmailLbl);
            this.Controls.Add(this.EmailTxt);
            this.MaximumSize = new System.Drawing.Size(816, 488);
            this.MinimumSize = new System.Drawing.Size(816, 488);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassSeeUnseePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmailTxt;
        private System.Windows.Forms.Label EmailLbl;
        private System.Windows.Forms.Label PassLbl;
        private System.Windows.Forms.TextBox PassTxt;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label MainTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel SignupLinkLabel;
        private System.Windows.Forms.PictureBox PassSeeUnseePic;
    }
}