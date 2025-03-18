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
using Microsoft.EntityFrameworkCore;

// mw706760@gmail.com

namespace TaskManagementSystem
{
    public partial class MainForm : Form
    {
        int _currentUId;

        int _skippedEntries;

        // number of pages the pagination occurs based on
        int _takenEntries;

        ApplicationDbContext _appDbContext;

        List<TaskItem> _localTasksList;

        List<TaskItem> _affectedTasksList;

        StatusEnum _filterChoice;

        string _searchChoice;

        public MainForm(ApplicationDbContext applicationContext, int currentUId)
        {
            InitializeComponent();
            _appDbContext = applicationContext;
            _currentUId = currentUId;
            _takenEntries = 5;
            _skippedEntries = 0;
            _filterChoice = StatusEnum.Pending;
            _searchChoice = "Title";
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            UpdateView();
            for (int i = 0; i < TaskGridView.Columns.Count; i++)
            {
                TaskGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void TaskGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                // Edit operation
                int taskId = (int)TaskGridView.CurrentRow.Cells["Id"].Value;

                TaskItem taskItem = _appDbContext.TaskItems.Find(taskId);
                TaskCardForm taskCard = new TaskCardForm(_appDbContext, _currentUId, taskItem);
                taskCard.Show(this);
                TaskGridView.ClearSelection();

            }
            else if (e.Button == MouseButtons.Right)
            {
                // Delete operation

                DialogResult dr = MessageBox.Show("Are you sure about this task deletion ?", "Task Deletion Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    int taskId = (int)TaskGridView.CurrentRow.Cells["Id"].Value;
                    TaskItem task = _appDbContext.TaskItems.Find(taskId);
                    _appDbContext.TaskItems.Remove(task);
                    _appDbContext.SaveChanges();

                    UpdateView();
                }
                else
                {
                    TaskGridView.ClearSelection();
                }

            }
        }

        private void PageUpDown_ValueChanged(object sender, EventArgs e)
        {
            _skippedEntries = Convert.ToInt32(PageUpDown.Value) - 1;
            _skippedEntries *= _takenEntries;

            UpdatePage();
        }

        internal void UpdateView()
        {
            //var _localTasksList = _appDbContext.TaskItems.Include(task => task.Category).Where(task => task.UserId==_currentUId).ToList();

            _localTasksList = _appDbContext.TaskItems.Include(task => task.Category).Where(task => task.UserId == _currentUId).ToList();

            _affectedTasksList = new List<TaskItem>(_localTasksList);

            UpdatePaginationLimits();

            UpdatePage();
        }

        private void UpdatePage()
        {
            TaskGridView.DataSource = _affectedTasksList.Skip(_skippedEntries).Take(_takenEntries).Select(taskItem => new {
                taskItem.Id,
                taskItem.Title,
                taskItem.Priority,
                taskItem.DueDate,
                taskItem.Status,
                Category = taskItem.Category.Name
            }).ToList();

            TaskGridView.Columns["Id"].Visible = false;
        }

        private void LogoutPicBox_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void AddPicBox_Click(object sender, EventArgs e)
        {
            // This creates a new task item if the user submits the his input in the task card form
            TaskCardForm newTask = new TaskCardForm(_appDbContext, _currentUId);
            newTask.Show(this);
        }

        private void SortPic_Click(object sender, EventArgs e)
        {
            _affectedTasksList.Sort(new DueDateComparer());
            UpdatePage();
        }

        private void SearchPic_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (_searchChoice == "Title")
                {
                    _affectedTasksList = _affectedTasksList.Where(task => task.Title.StartsWith(SearchTxt.Text)).ToList();

                }
                else
                {
                    _affectedTasksList = _affectedTasksList.Where(task => task.Description.StartsWith(SearchTxt.Text)).ToList();

                }

                UpdatePaginationLimits();

                UpdatePage();

            }
            else if (e.Button == MouseButtons.Right)
            {
                CustomMBoxForm messagebox = new CustomMBoxForm(true);
                messagebox.Show(this);
            }
        }

        private void FilterPic_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                _affectedTasksList = _affectedTasksList.Where(task => task.Status==_filterChoice).ToList();

                UpdatePaginationLimits();

                UpdatePage();

            }
            else if (e.Button == MouseButtons.Right)
            {
                CustomMBoxForm messagebox = new CustomMBoxForm(false);
                messagebox.Show(this);
            }
        }

        // called from the custom message to pass the value of the choice
        internal void SetChoice(bool searchPurpose, string choice)
        {
            if (searchPurpose == true)
                _searchChoice = choice;
            else
                _filterChoice = Enum.Parse<StatusEnum>(choice);
        }

        private void CancelOperationPic_Click(object sender, EventArgs e)
        {
            _affectedTasksList = new List<TaskItem>(_localTasksList);
            UpdatePaginationLimits();
            UpdatePage();
            TaskGridView.Columns["DueDate"].DefaultCellStyle.BackColor = default;
            TaskGridView.Columns["Priority"].DefaultCellStyle.BackColor = default;
        }

        private void UpdatePaginationLimits()
        {
            if (_affectedTasksList.Count > 0)
                PageUpDown.Maximum = Convert.ToInt32(Math.Ceiling(_affectedTasksList.Count / (double)_takenEntries));
            else
                PageUpDown.Maximum = 1;
        }

        private void GroupButton_Click(object sender, EventArgs e)
        {
            var groupingResult = _affectedTasksList.GroupBy(task => task.Priority);
            _affectedTasksList = groupingResult.SelectMany(result => result).ToList();
            UpdatePage();
            TaskGridView.Columns["Priority"].DefaultCellStyle.BackColor = Color.Aqua;
        }

        private void TrackPic_Click(object sender, EventArgs e)
        {
            _affectedTasksList = _affectedTasksList.Where(task => task.DueDate.CompareTo(DateTime.Now) <= 0).ToList();
            UpdatePaginationLimits();
            UpdatePage();
            TaskGridView.Columns["DueDate"].DefaultCellStyle.BackColor = Color.Red;
        }

        private void ReportPic_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm(_localTasksList);
            reportForm.Show(this);

        }


        //private void MainForm_Load(object sender, EventArgs e)
        //{
        //    UpdateView();
        //}
    }

    class DueDateComparer : IComparer<TaskItem>
    {
        public int Compare(TaskItem x, TaskItem y)
        {
            if (x.DueDate.CompareTo(y.DueDate) > 0)
                return 1;
            else if (x.DueDate.CompareTo(y.DueDate) < 0)
                return -1;
            else
                return 0;
            
        }
    }

}
