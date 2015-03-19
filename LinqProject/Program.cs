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
            IEnumerable<string> results2 = nameArr
                .Where(n => n.Contains("M"))
                .OrderBy(n => n.Length)
                .Select(n => n.ToUpper());
            //a collection...

            //loop through strings
            
            foreach (string str in results2)
            {
                Console.WriteLine(str);
            }
            Console.ReadLine();
        }
    }
}
