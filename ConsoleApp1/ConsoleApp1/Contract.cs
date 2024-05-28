using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Contract : IContract
    {
        public DateTime SigningDate { get; set; }
        public int Salary { get; set; }

       

        

        public Contract(DateTime signingDate, int salary)
        {
            SigningDate = signingDate;
            Salary = salary;
           
           
        }

        public void SignContract()
        {
           
            Console.WriteLine($"Contract signed on {SigningDate.ToShortDateString()}");
        }

        public void TerminateContract()
        {
            
            Console.WriteLine("Contract terminated.");
        }
    }
}
