using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portifolio.Intermediario
{
    public class Task
    {
        int Id{ get; set; }
        string Title{ get; set; }
        bool Complete{ get; set; }

        public Task(int id, string title, bool complete) 
        {
            Id = id;
            Title = title;
            Complete = complete;
        
        }
        public void AddTask(string title, List<Task> TaskList)
        {
            int LastId = TaskList.Any() ? TaskList.Max(t => t.Id) + 1 : 1;
            TaskList.Add(new Task ( LastId, title, false ));
        }
        public bool CompleteTask()
        {
            return Complete = true;
        }

    }
    internal class TaskManeger
    {
        static List<Task> TaskList = new List<Task>();
        public static void Executar()
        {

        }
    }
}
