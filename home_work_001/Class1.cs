using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace home_work_001
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }


        public void Introduce()
        {
            Console.WriteLine($"my name is {Name} i am {Age} yers old ");
        }
    }
}
