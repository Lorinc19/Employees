using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    public class Employer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }

        public Employer(string row)
        {
            string[] darab = row.Split(';');

            Id = int.Parse(darab[0]);
            Name = darab[1];
            Age = int.Parse(darab[2]);
            Salary = int.Parse(darab[3]);
        }
    }
}
