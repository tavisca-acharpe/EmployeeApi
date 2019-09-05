using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebDemo.Model
{
    public class Employee
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int salary { get; set; }
        public int Age { get; set; }
        public string Designation { get; set; }
        public int DesignationId { get; set; }
    }
}
