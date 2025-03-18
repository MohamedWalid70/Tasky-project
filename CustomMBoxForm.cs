using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagementSystem.Model;

namespace TaskManagementSystem
{
    public partial class CustomMBoxForm : Form
    {
        bool _searchPurpose;
        public CustomMBoxForm(bool searchPurpose)
        {
            InitializeComponent();

            _searchPurpose = searchPurpose;
        }

        private void SelectBtn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = this.Owner as MainForm;
            mainForm.SetChoice(_searchPurpose, ChoiceCombo.Text);
            this.Close();
        }

        private void CustomMBoxForm_Load(object sender, EventArgs e)
        {
            if (_searchPurpose == true)
            {

                ChoiceCombo.DataSource = new List<string>() { "Title", "Description" };
            }
            else
            {
                ChoiceCombo.DataSource = Enum.GetNames<StatusEnum>();
            }
        }
    }
}
