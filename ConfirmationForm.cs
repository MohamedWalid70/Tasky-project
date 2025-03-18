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
    public partial class ConfirmationForm : Form
    {
        ApplicationDbContext _appDbContext;

        User _tmpInfo;

        int _code;

        public ConfirmationForm(ApplicationDbContext applicationDbContext, User signInfo)
        {
            InitializeComponent();
            _appDbContext = applicationDbContext;            
            _tmpInfo = signInfo;
        }

        private void CodeRetryLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SendVerificationCode();
        }

        public void SendVerificationCode()
        {
            try
            {
                Random codeGenerator = new Random();
                _code = codeGenerator.Next(100000, 999999);

                MailMessage message = new MailMessage();
 
                SmtpClient client = new SmtpClient("smtp.gmail.com");

                message.From = new MailAddress("mh406407408@gmail.com", "Tasky");       // The task system email

                message.To.Add(_tmpInfo.Email);

                message.Subject = "Verify your email address";

                message.IsBodyHtml = true;
                message.Body = $"<label> Here is the confirmation code </label><br> <h1> {_code} </h1> <br> <label> This code will expire 10 minutes after it was sent </label>";

                // enable SSL for encryption across channels
                client.EnableSsl = true;
                // Port 465 for SSL communication
                client.Port = 587;
                // Provide authentication information with Gmail SMTP server to authenticate your sender account
                client.Credentials = new System.Net.NetworkCredential("mh406407408@gmail.com", "zlvn csjs tijd ovvk");

                //System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

                client.Send(message); // Send the constructed mail
            }
            catch (Exception e)
            {
                SmtpException E = e as SmtpException;
                MessageBox.Show($"Because of an error, the confirmation code hasn't been sent, yet\nTry again");
            }

        }

        private void ConfirmationForm_Load(object sender, EventArgs e)
        {
            SendVerificationCode();
        }

        private void ConfirmCodeTxt_TextChanged(object sender, EventArgs e)
        {
            int input;

            if (int.TryParse(ConfirmCodeTxt.Text, out input))
            {
                if (input == _code)
                {
                    ConfirmCodeTxt.ForeColor = SystemColors.WindowText;
                    MismatchLbl.Visible = false;

                    _appDbContext.Users.Add(_tmpInfo);
                    _appDbContext.SaveChanges();
                    this.Owner.Close();
                    // Return to the login page
                }
                else
                {
                    MismatchLbl.Visible = true;
                    ConfirmCodeTxt.ForeColor = Color.Red;
                    // implement a scenario to handle many faulty codes
                }
            }
            else
            {
                MismatchLbl.Visible = true;
                ConfirmCodeTxt.ForeColor = Color.Red;
            }
        }

        private void ConfirmationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MismatchLbl.Visible == true)
            {
                this.Owner.Show();
            }
            else
            {
                this.Owner.Owner.Show();
            }
        }
    }
}
