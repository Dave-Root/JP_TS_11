using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JP_TS_11
{
    internal class Person
    {
        private string Id { get; } =new Random().Next(1,100).ToString();
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public Person(int age)
        {
            Age= age;
        }

        public void TellMeYourAge()
        {
            if(Age>17)
            Console.WriteLine($"I'm adult! I'm {Age}");
            else
            Console.WriteLine($"I'm not adult!  I'm {Age}");
        }

        public string MyIdIs()
        {
            return Id;
        }


    }
}
