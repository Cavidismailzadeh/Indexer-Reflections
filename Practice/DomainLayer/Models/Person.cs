using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class Person : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public double Salary { get; set; }

    }
}
