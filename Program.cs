using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    internal class Program
    {
        public static List<Employer> employers = new List<Employer>();

        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("tulajdonsagok_100sor.txt");

            Employer emp =new Employer(sr.ReadLine());

            Console.WriteLine(emp.Name);
        }
    }
}
