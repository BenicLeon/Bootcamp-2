using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class Coach : Person
    {
        public string Role { get; set; }

        public Coach(string name, int age, string role)
            : base(name, age)
        {
            Role = role;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Role: {Role}");
        }
    }
}