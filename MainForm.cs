using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskTimeTracker.Services;

namespace TaskTimeTracker.Forms
{
    public partial class MainForm : Form
    {
        private TaskManager taskManager;
        private System.Windows.Forms.Timer timer;
        private DateTime taskStartTime;

        public MainForm()
        {
            InitializeComponent();
            btnStop.Enabled = false;

            // Initialize TaskManager with the specified file
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tasks.json");
            taskManager = new TaskManager(filePath);

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1 saniye
            timer.Tick += Timer_Tick;
        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = DateTime.Now - taskStartTime;
            lblTimer.Text = elapsed.ToString(@"hh\:mm\:ss");
        }

        private void RefreshTaskHistory()
        {
            lstTaskHistory.Items.Clear();
            foreach (var task in taskManager.AllTasks)
            {
                lstTaskHistory.Items.Add(task.ToString());
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnShowHistory_Click(object sender, EventArgs e)
        {
            var historyForm = new TaskHistoryForm(taskManager.AllTasks.ToList());
            historyForm.ShowDialog();
        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            string taskName = txtTaskName.Text.Trim();

            if (string.IsNullOrEmpty(taskName))
            {
                MessageBox.Show("Lütfen bir görev adı girin.");
                return;
            }

            taskManager.StartTask(taskName);
            taskStartTime = DateTime.Now;

            btnStart.Enabled = false;
            btnStop.Enabled = true;
            txtTaskName.Enabled = false;

            timer.Start();
        }

        private void btnStop_Click_1(object sender, EventArgs e)
        {
            taskManager.EndTask();
            timer.Stop();

            btnStart.Enabled = true;
            btnStop.Enabled = false;
            txtTaskName.Enabled = true;

            lblTimer.Text = "00:00:00";

            RefreshTaskHistory();

        }
    }
}
