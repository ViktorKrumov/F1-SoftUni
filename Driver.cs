using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1
{
    class Driver
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public float TotalTime { get; set; }

        public float Speed { get; set; }

        

        public Driver(string name, int age, float totaltime, float speed)
        {
            Name = name;
            Age = age;
            TotalTime = totaltime;
            Speed = speed;
            
        }

        
    }
}
