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
            // dataset....
            string[] nameArr = { "Sue", "Saam", "Samantha", "samanthar", "Brit", "Rick" };
            // LINQ - length of 3
            IEnumerable<string> results = nameArr.Where(n => n.Length <= 3);
            // LINQ - to check is name contains XYZ
            //var MyArrayLower = nameArr.Select(s => s.ToLowerInvariant()).ToArray();
            IEnumerable<string> results2 = nameArr
                .Select(n => n.ToUpper())
                .Where(n => n.Contains("AM"))
                .OrderBy(n => n);

            // a collection...
            //Console.WriteLine(results);
            // loop through each string
            foreach (string str in results2)
            {
                //Console.WriteLine(str);
            }

            // List of TODOS
            List<Todo> tList = new List<Todo>
            {
                new Todo("Rick",    "Burn couch", false, DateTime.Now.AddDays(-10),DateTime.Now.AddDays(-5) ),
                new Todo("Sam",     "Bring Sodas", false, DateTime.Now.AddDays(-9), DateTime.Now),
                new Todo("Mike",    "Bring Chip", false, DateTime.Now.AddDays(-6), DateTime.Now),
                new Todo("Sue",     "Bring Beer", true, DateTime.Now.AddDays(-5), DateTime.Now),
                new Todo("Ricky",   "Bring Pizza", true, DateTime.Now.AddDays(-5), DateTime.Now)

            };

            Console.WriteLine("yadayd");
            List<Todo> todoResults = tList.Where(t => t.isCompleted == true).ToList();

            foreach (var obj in todoResults)
            {
                Console.WriteLine("Name: {0}", obj.User);
                Console.WriteLine(obj.Name);
            }



            Console.ReadLine();
        }
    }
    // TODO Class
    public class Todo
    {

        public Todo(string p1, string p2, bool p3, DateTime dateTime1, DateTime dateTime2)
        {
            // TODO: Complete member initialization
            this.User = p1;
            this.Name = p2;
            this.isCompleted = p3;
            this.dateCreated = dateTime1;
            this.dateModified = dateTime2;
        }
        // person TODO is assigned to
        public string User { get; set; }
        // Task that needs to be done
        public string Name { get; set; }
        // if the Task has been completed
        public bool isCompleted { get; set; }
        // the creation date
        public DateTime dateCreated { get; set; }
        // the date it was modifed
        public DateTime dateModified { get; set; }

    }
}
