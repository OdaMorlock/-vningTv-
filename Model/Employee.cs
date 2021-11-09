using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Model
{
    public class Employee : IEmployee
    {
        public string FistName { get; set; }
        public string LastName { get; set; }
        public int BaseSalery { get; set; }
        public int TotalSalery { get; set; }
    }
}
