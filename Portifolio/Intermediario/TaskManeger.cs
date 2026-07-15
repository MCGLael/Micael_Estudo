using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portifolio.Intermediario
{
    public class Task
    {
        int Id { get; set; }
        string Title { get; set; }
        bool Complete { get; set; }

        public Task(int id, string title, bool complete)
        {
            Id = id;
            Title = title;
            Complete = complete;

        }
        public void AddTask(string title, List<Task> taskList)
        {
            int LastId = taskList.Any() ? taskList.Max(t => t.Id) + 1 : 1;
            taskList.Add(new Task(LastId, title, false));
        }
        public void ReturnList(List<Task> taskList)
        {
            foreach (var Task in taskList)
            {
                Console.WriteLine($"Id: {Task.Id} Title: {Task.Title} Complete: {Task.Complete}");
            }
        }
        public void CompleteTask(int id, List<Task> taskList)
        {
            Task task = taskList.FirstOrDefault(t => t.Id == id);
            if (task != null)
            {
                if (task.Complete = true)
                {
                    Console.WriteLine("Task Already complete");
                }
                else
                {
                    task.Complete = true;
                }
            }
            else
            {
                Console.WriteLine("Task not found");
            }
        }
        
        public void RemoveTask(int Id, List<Task> taskList)
        {
            ReturnList(taskList);

            Task task = taskList.FirstOrDefault(t => t.Id == Id);

            if(task != null)
            {
                taskList.Remove(task);
            }
            else
            {
                Console.WriteLine("Task Not Found.");
            }
        }

    } 
    internal class TaskManeger
    {
        static List<Task> TaskList = new List<Task>();
        public static void Executar()
        {
            Console.WriteLine("Task Maneger...");
            bool i = false;
            while (i = false){
                Console.WriteLine("1 - List all Tasks\n2 - Add Task\n3 - Mark Task as Complete\n 4 - Delete Task\n0 - Exit");
                if(!int.TryParse(Console.ReadLine(), out int option)) { Console.WriteLine("Invalid."); continue; }
            } }
    }
}
