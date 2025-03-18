using LiveCharts;
using LiveCharts.Wpf;
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
    public partial class ReportForm : Form
    {
        List<TaskItem> _importedList;

        public ReportForm(List<TaskItem> importedList)
        {
            InitializeComponent();
            _importedList = importedList;
        }

        Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} Tasks\nPercentage of {1:P}", chartPoint.Y, chartPoint.Participation);

        private void ReportForm_Load(object sender, EventArgs e)
        {
            SeriesCollection series = new SeriesCollection();

            var tasksBasedOnStatus = _importedList.GroupBy(task => task.Status);

            foreach (var status in tasksBasedOnStatus)
            {
                series.Add(new PieSeries() { Title = status.Key.ToString() + " Tasks", Values = new ChartValues<int> { status.Count() }, DataLabels=true, LabelPoint=labelPoint });
            }
            pieChart1.Series = series;

            pieChart1.LegendLocation = LegendLocation.Bottom;

            DateTime startDateTime = new DateTime(2025, 2, 27, 1, 1, 1);

            double avgCompletionTime = _importedList.Where(task => task.Status == StatusEnum.Completed).Average(task => task.DueDate.Ticks - startDateTime.Ticks);

            TimeSpan avgSpan = new TimeSpan((long) avgCompletionTime);


            AvgLbl.Text = $"The average task completion time is {avgSpan.Days} days, {avgSpan.Hours} hours and {avgSpan.Minutes} minutes";
        }
    }
}
