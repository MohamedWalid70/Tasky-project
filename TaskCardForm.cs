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
    public partial class TaskCardForm : Form
    {
        ApplicationDbContext _appDbContext;
        int _currentUId;
        TaskItem _taskItem;

        public TaskCardForm(ApplicationDbContext appContext, int currentUId, TaskItem taskItem)
        {
            InitializeComponent();
            _appDbContext = appContext;
            _currentUId = currentUId;
            _taskItem = taskItem;
        }

        public TaskCardForm(ApplicationDbContext appContext, int currentUId)
        {
            InitializeComponent();
            _appDbContext = appContext;
            _currentUId = currentUId;
            _taskItem = null;
            SaveBtn.Text = "Add";
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            StatusEnum status = Enum.Parse<StatusEnum>(StatusCombo.Text);
            int categoryId = _appDbContext.Categories.First(category => category.Name == CategoryCombo.Text).Id;

            if (_taskItem == null)
            {
                _taskItem = new TaskItem()
                {
                    Title = TitleTxt.Text,
                    Priority = PriorityCombo.Text,
                    Status = status,
                    CategoryId = categoryId,
                    UserId = _currentUId,
                    Description = DescriptionTxt.Text,
                    DueDate = DueDateTime.Value
                };
                _appDbContext.TaskItems.Add(_taskItem);
            }
            else
            {
                _taskItem.Title = TitleTxt.Text;
                _taskItem.Priority = PriorityCombo.Text;
                _taskItem.Status = status;
                _taskItem.CategoryId = categoryId;
                _taskItem.UserId = _currentUId;
                _taskItem.Description = DescriptionTxt.Text;
                _taskItem.DueDate = DueDateTime.Value;

            }
            _appDbContext.SaveChanges();

            MainForm parentForm =  this.Owner as MainForm;
            parentForm.UpdateView();
            this.Close();
        }

        private void TaskCardForm_Load(object sender, EventArgs e)
        {
            if (_taskItem!=null) {
                TitleTxt.Text = _taskItem.Title;
                DescriptionTxt.Text= _taskItem.Description;
                DueDateTime.Value = _taskItem.DueDate;
            }
            StatusCombo.DataSource = Enum.GetNames<StatusEnum>();
            StatusCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            PriorityCombo.DataSource = new List<string>() { "Low", "Medium", "High" };
            PriorityCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            CategoryCombo.DataSource = _appDbContext.Categories.Select(category => category.Name).ToList();
            CategoryCombo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
