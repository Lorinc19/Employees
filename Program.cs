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

        public static void feladat4()
        {
            int max = employers[0].Salary;
            int id = 0;
            foreach (var item in employers) 
            {
                if (item.Salary> max)
                {
                    max = item.Salary;
                    id= item.Id;
                }    
            }
            Console.WriteLine($"a LEGJOBBASN KERESŐ DOLGOZÓ ID:{id}, NEVE: {employers[id-1].Name}");
        }

        public static void feladat5()
        {
            foreach (var item in employers)
            {
                if (item.Age == 55)
                {
                    Console.WriteLine($"Név: {item.Name} Kor: {item.Age}");
                }
            }
        }

        public static int feladat6()
        {
            int count = 0;

            foreach (var item in employers)
            {
                if(item.Salary > 50000)
                {
                    count++;
                }
            }

            return count;
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
            feladat4();
            feladat5();
            Console.WriteLine($"Összesen {feladat6()} keresnek többet mint 50000.");

        }
    }
}
