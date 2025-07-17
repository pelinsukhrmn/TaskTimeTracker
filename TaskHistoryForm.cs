using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskTimeTracker.Models;

namespace TaskTimeTracker.Forms
{
    public partial class TaskHistoryForm : Form
    {
        public TaskHistoryForm(List<TaskItem> tasks)
        {
            InitializeComponent();
            LoadHistory(tasks);
        }
        private void LoadHistory(List<TaskItem> tasks)
        {
            lstHistory.Items.Clear();
            foreach (var task in tasks)
            {
                lstHistory.Items.Add($"{task.Name} | Başlangıç: {task.StartTime} | Süre: {task.Duration}");
            }
        }


        private void TaskHistoryForm_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
