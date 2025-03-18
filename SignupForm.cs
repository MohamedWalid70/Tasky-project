using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagementSystem.Model;

namespace TaskManagementSystem
{
    public partial class SignupForm : Form
    {
        ApplicationDbContext _appDbContext;

        Regex _emailReg;

        Regex _passReg;

        Regex _nameReg;

        byte[] _mismatchFlags;

        public SignupForm(ApplicationDbContext appContext)
        {
            InitializeComponent();
            _appDbContext = appContext;
            _passReg = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$");
            _emailReg = new Regex(@"[a-z]+\d*(_)*\.*\w+@(gmail|yahoo|outlook){1,1}\.(com)");
            _nameReg = new Regex(@"([A-Z]|[a-z]){1,16}");
            _mismatchFlags = new byte[5];
        }

        private void EmailTxt_TextChanged(object sender, EventArgs e)
        {
            if (!_emailReg.IsMatch(EmailTxt.Text))
            {
                EmailTxt.ForeColor = Color.Red;
                _mismatchFlags[0] = 1;
            }
            else
            {
                EmailTxt.ForeColor = SystemColors.WindowText;
                _mismatchFlags[0] = 0;
            }
        }

        private void PassTxt_TextChanged(object sender, EventArgs e)
        {
            if (!_passReg.IsMatch(PassTxt.Text))
            {
                PassTxt.ForeColor = Color.Red;
                _mismatchFlags[1] = 1;
            }
            else
            {
                PassTxt.ForeColor = SystemColors.WindowText;
                _mismatchFlags[1] = 0;
            }
        }

        private void PassConfirmTxt_TextChanged(object sender, EventArgs e)
        {
            if (!PassConfirmTxt.Text.Equals(PassTxt.Text))
            {
                PassTxt.ForeColor = Color.Red;
                _mismatchFlags[2] = 1;
            }
            else
            {
                PassTxt.ForeColor = SystemColors.WindowText;
                _mismatchFlags[2] = 0;
            }
        }

        private void FNameTxt_TextChanged(object sender, EventArgs e)
        {
            if (_nameReg.IsMatch(FNameTxt.Text))
            {
                FNameTxt.ForeColor = SystemColors.WindowText;
                _mismatchFlags[3] = 0;
            }
            else
            {
                FNameTxt.ForeColor = Color.Red;
                _mismatchFlags[3] = 1;
            }
        }

        private void LNameTxt_TextChanged(object sender, EventArgs e)
        {
            if (_nameReg.IsMatch(LNameTxt.Text))
            {
                LNameTxt.ForeColor = SystemColors.WindowText;
                _mismatchFlags[4] = 0;
            }
            else
            {
                LNameTxt.ForeColor = Color.Red;
                _mismatchFlags[4] = 1;
            }
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = DialogResult.None;

            for(int i = 0; i < _mismatchFlags.Length; i++)
            {
                if (_mismatchFlags[i] == 1)
                {
                    dialogResult = MessageBox.Show("Please, fill the required fields according to the rules specified", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                }

            }

            if (dialogResult == DialogResult.None)
            { 
                ConfirmationForm confirmationForm = new ConfirmationForm(_appDbContext, new User { Name=FNameTxt.Text+" "+LNameTxt.Text, Email = EmailTxt.Text, Password=PassTxt.Text } );
                confirmationForm.Show(this);
                this.Hide();
            }

        }
    }
}
