using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //dataset...
            string[] nameArr = {"Sue", "Mancy", "Michelle", "John Footpenis", "RJ", "Corinne"}; // array of strings for LINQ IENumerable example
            //LINQ - Length of Characters Greater/Equal to 3
            IEnumerable<string> results = nameArr.Where(n => n.Length >= 3); 
            //LINQ - Check if name contains XYZ
            var MyArrayLower = nameArr.Select(s => s.ToLowerInvariant()).ToArray();
            IEnumerable<string> results2 = nameArr
                .Select(n => n.ToUpper())
                .Where(n => n.Contains("M"))
                .OrderBy(n => n);
                
            //a collection...

            //loop through strings
            
            foreach (string str in results2)
            {
                Console.WriteLine(str);
            }

            //List of Todos
            List<Todo> tList = new List<Todo>
            {
                new Todo("Rick", "Burn Couch", false, DateTime.Now.AddDays(-10), DateTime.Now.AddDays(-5) ),
                new Todo("Sam", "Bring Soda", false, DateTime.Now.AddDays(-9), DateTime.Now),
                new Todo("RJ", "Jack It", true, DateTime.Now.AddDays(-3), DateTime.Now ),
                new Todo("River Phoenix", "Bring Cocaine", true, DateTime.Now.AddDays(-2), DateTime.Now ),
                new Todo("Jack", "Bring Dip", false, DateTime.Now.AddDays(-10), DateTime.Now ),


            };

            List<Todo> todoResults = tList.Where(t => t.isCompleted == true).ToList();
            foreach (var obj in todoResults)
            {
                Console.WriteLine();
            }


            Console.ReadLine();

        }
    }

    // Todo Class
    public class Todo 
    {
        private string name;
        private string task;
        private bool isCompleted;
        private DateTime dateCreated;
        private DateTime dateModified;

        public Todo(string task, string task, bool isCompleted, DateTime dateCreated, DateTime dateModified)
        {
            // TODO: Complete member initialization
            this.name = task;
            this.task = task;
            //this.isCompleted = isCompleted;
            //this.dateCreated = dateCreated;
            //this.dateModified = dateModified;
        }
        //User - Person that Todo is Assigned to
        public string Name { get; set; }
        // Name - Name of the Task to be completed
        public string Task { get; set; }
        //Completed - boolean whether task has been completed
        public bool isCompleted { get; set; }
        //dateCreated - timestamp when time has been created
        public DateTime dateCreated { get; set; }
        //dateModifed - timestamp of last edit of Todo task
        public DateTime dateModified { get; set; }


    }
}
