using System;
using System.Collections.Generic;

namespace F1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var list = new List<Driver>();
            float b = 0;

            for(int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");

                string name = input[0] +" "+ input[1];
                int age = int.Parse(input[2]);
                float totalTime = float.Parse(input[3]);
                float speed = float.Parse(input[4]);



                var driver = new Driver(name, age, totalTime, speed);
                list.Add(driver);


            }

            foreach(var item in list)
            {
                if(item.Speed > b)
                {
                    b = item.Speed;
                }
            }

            var fr = list.Find(x => x.Speed == b);

            Console.WriteLine("DriverName: " + fr.Name);
            Console.WriteLine(" DriverAge: " + fr.Age);
            Console.WriteLine("  Time: " + fr.TotalTime);
            Console.WriteLine("  Speed: " + fr.Speed);



        }

        
    }
}
