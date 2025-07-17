using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using TaskTimeTracker.Models;

namespace TaskTimeTracker.Data
{
    public class FileDataAccess
    {
        private readonly string filePath;

        public FileDataAccess(string filePath)
        {
            this.filePath = filePath;
        }

        public void SaveTasks(List<TaskItem> tasks)
        {
            var json = JsonSerializer.Serialize(tasks);
            File.WriteAllText(filePath, json);
        }

        public List<TaskItem> LoadTasks()
        {
            if (!File.Exists(filePath))
                return new List<TaskItem>();

            var json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<TaskItem>>(json) ?? new List<TaskItem>();
        }
    }
}
