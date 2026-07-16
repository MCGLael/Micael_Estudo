using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portifolio.Intermediario
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
       public bool Complete { get; set; }

        public Task(int id, string title, bool complete)
        {
            Id = id;
            Title = title;
            Complete = complete;

        }
        

    } 

    class TaskManager
    {
        private List<Task> taskList = new List<Task>();
        //TaskManager manager = new TaskManager();
        public void AddTask(string title)
        {
            int LastId = taskList.Any() ? taskList.Max(t => t.Id) + 1 : 1;
            taskList.Add(new Task(LastId, title, false));
        }
        void ReturnList()
        {
            foreach (var Task in taskList)
            {
                Console.WriteLine($"Id: {Task.Id}\nTitle: {Task.Title}\nComplete: {Task.Complete}");
            }
        }
        public void CompleteTask(int id)
        {
            Task task = taskList.FirstOrDefault(t => t.Id == id);
            if (task != null)
            {
                if (task.Complete == true)
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

        public void RemoveTask(int Id)
        {
            ReturnList();

            Task task = taskList.FirstOrDefault(t => t.Id == Id);

            if (task != null)
            {
                taskList.Remove(task);
            }
            else
            {
                Console.WriteLine("Task Not Found.");
            }
        }
        public void choice(int opt)
        {
            switch (opt)
            {
                case 1:
                    Console.WriteLine("Task List");
                    ReturnList();
                    break;
                case 2:
                    Console.WriteLine("adding Task");
                    Console.WriteLine("Insert the title of your new Task:");
                    string title = Console.ReadLine();
                    if (title != null){
                        AddTask(title);
                    }
                    else
                    {
                        Console.WriteLine("Invalid");
                    }

                        break;
                case 3:
                    Console.WriteLine("Insert Task ID");
                    if(!int.TryParse(Console.ReadLine(), out int choice)){ Console.WriteLine("Invalid"); return; }
                    CompleteTask(choice);
                    
                    break;
                case 4:
                    Console.WriteLine("Insert Task ID you want to delete");
                    if (!int.TryParse(Console.ReadLine(), out int option)) { Console.WriteLine("Invalid"); return; }
                    RemoveTask(option);
                    break;
                default:
                    if(opt == 0)
                    {
                        Console.WriteLine("Exiting...");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input, try again");
                    }
                        break;
            }

        }

        
        public static void Executar()
        {
            //List<Task> TaskList = new List<Task>();
            TaskManager manager = new TaskManager();
            Console.WriteLine("Task Manager...");
            int i = 1;
            while (i != 0){
                
                Console.WriteLine("1 - List all Tasks\n2 - Add Task\n3 - Mark Task as Complete\n4 - Delete Task\n0 - Exit");
                if(!int.TryParse(Console.ReadLine(), out int option)) { Console.WriteLine("Invalid."); continue; }
                manager.choice(option);
                i = option;
            } }
    }
}
