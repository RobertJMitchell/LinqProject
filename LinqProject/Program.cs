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
            string[] nameArr = {"Sue", "Kelly", "John Footpenis", "RJ", "Corinne"}; // array of strings for LINQ IENumerable example
            IEnumerable<string> results = nameArr.Where(n => n.Length >= 3); 
            foreach (string str in results)
            {
                Console.WriteLine(str);
            }
            Console.ReadLine();
        }
    }
}
