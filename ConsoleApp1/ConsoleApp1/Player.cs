using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    public class Player : Person
    {
        public string Position { get; set; }
        public int JerseyNumber { get; set; }

  

        public Player(string name, int age, string position, int jerseyNumber)
            : base(name, age)
        {
            Position = position;
            JerseyNumber = jerseyNumber;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Position: {Position}, Jersey Number: {JerseyNumber}");
        }
    }
}
