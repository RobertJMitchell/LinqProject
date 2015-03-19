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
                new Todo("Rick", "Burn Couch", false, DateTime.Now.AddDays(-10), DateTime.Now.AddDays(-5) );
            };


            Console.ReadLine();

        }
    }

    // Todo Class
    public class Todo 
    {
        private string p1;
        private string p2;
        private bool p3;
        private DateTime dateTime1;
        private DateTime dateTime2;

        public Todo(string p1, string p2, bool p3, DateTime dateTime1, DateTime dateTime2)
        {
            // TODO: Complete member initialization
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.dateTime1 = dateTime1;
            this.dateTime2 = dateTime2;
        }
        //User - Person that Todo is Assigned to
        public string User { get; set; }
        // Name - Name of the Task to be completed
        public string Name { get; set; }
        //Completed - boolean whether task has been completed
        public bool isCompleted { get; set; }
        //dateCreated - timestamp when time has been created
        public DateTime dateCreated { get; set; }
        //dateModifed - timestamp of last edit of Todo task
        public DateTime dateModified { get; set; }


    }
}
