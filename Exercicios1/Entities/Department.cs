using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios1.Entities
{
    public class Department
    {
        public string Name { get; set; }

        public Department(string departName)
        {
            Name = departName;
        }
    }
}
