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
        public int Id { get; private set; }
        public string Position { get; set; }
        public int JerseyNumber { get; set; }

        private static int lastId = 0;

        public Contract PlayerContract { get; set; }
        public Player(string name, int age, string position, int jerseyNumber, Contract playerContract)
            : base(name, age)
        {
            Position = position;
            JerseyNumber = jerseyNumber;
            PlayerContract = playerContract;
            Id = ++lastId;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"{Id}-Name: {Name}, Age: {Age}, Position: {Position}, Jersey Number: {JerseyNumber}");
        }
    }
}
