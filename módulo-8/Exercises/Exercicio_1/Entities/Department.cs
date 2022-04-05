using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1.Entities
{
    class Department
    {
        public string Name { get; set; }

        public Department(string dPname)
        {
            Name = dPname;
        }
    }
}
