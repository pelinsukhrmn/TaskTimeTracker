using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskTimeTracker.Models;
using TaskTimeTracker.Data;

namespace TaskTimeTracker.Services
{
    public class TaskManager
    {
        private List<TaskItem> tasks;
        private TaskItem? currentTask;
        private FileDataAccess dataAccess;

        public IReadOnlyList<TaskItem> AllTasks => tasks;

        public TaskManager(string dataFilePath)
        {
            dataAccess = new FileDataAccess(dataFilePath);
            tasks = dataAccess.LoadTasks();
        }

        public void StartTask(string name)
        {
            if (currentTask != null) EndTask();

            currentTask = new TaskItem
            {
                Name = name,
                StartTime = DateTime.Now
            };
        }

        public void EndTask()
        {
            if (currentTask != null)
            {
                currentTask.EndTime = DateTime.Now;
                tasks.Add(currentTask);
                currentTask = null;
                dataAccess.SaveTasks(tasks); // Kaydet
            }
        }
    }
}
