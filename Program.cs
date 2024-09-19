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

        public static void feladat3()
        {
            foreach (var item in employers)
            {
                Console.WriteLine(item.Name);
            }
        }

        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("tulajdonsagok_100sor.txt");

            

            for (int i = 0; i < 100; i++)
            {
                Employer emp = new Employer(sr.ReadLine());
                employers.Add(emp);
            }

            feladat3();

        }
    }
}
