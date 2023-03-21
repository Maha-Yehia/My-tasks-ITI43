using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class Employee
    {
        public int id { get; set; }
        public int salary { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public override string ToString()
        {
            return $"Name is {name}";
        }
    }
}
