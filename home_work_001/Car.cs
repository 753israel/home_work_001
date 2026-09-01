using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_work_001
{
    public class Car
    {
        public string Color { get; set; }
        public int Speed { get; set; }
        public Car(string color, int speed)
        {
            Color = color;
            Speed = speed;
        }
        public void Drive()
        {
            Console.WriteLine($"The {Color} car is driving at {Speed} km/h.");
        }



    }

}
