using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagementSystem.Model;

namespace TaskManagementSystem
{
    public partial class LoginForm : Form
    {

        ApplicationDbContext _appDbContext;

        public LoginForm(ApplicationDbContext appContext)
        {
            InitializeComponent();
            _appDbContext = appContext;
        }

        private void SignupLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignupForm signupForm = new SignupForm(_appDbContext);
      
            signupForm.Show(this);
            this.Hide();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string email = EmailTxt.Text;

            User user = _appDbContext.Users.FirstOrDefault(user => user.Email.Equals(email));

            if (user == null || !(user.Password.Equals(PassTxt.Text)))
            {
                MessageBox.Show("The password or email you have entered is incorrect","Invalid Email or password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MainForm mainForm = new MainForm(_appDbContext, user.Id);

                mainForm.Show(this);
                this.Hide();
            }
        }

        private void PassSeeUnseePic_Click(object sender, EventArgs e)
        {
            if (PassTxt.PasswordChar == '*') {

                PassSeeUnseePic.BackgroundImage = TaskManagementSystem.Properties.Resources.show;
                PassTxt.PasswordChar = default;
            }
            else
            {
                PassSeeUnseePic.BackgroundImage = TaskManagementSystem.Properties.Resources.eye;
                PassTxt.PasswordChar = '*';
            }
            
        }
    }
}
