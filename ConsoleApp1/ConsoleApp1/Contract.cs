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
        public decimal Salary { get; set; }

        public bool IsSigned { get; set; }

        public Contract(DateTime signingDate, decimal salary)
        {
            SigningDate = signingDate;
            Salary = salary;
            IsSigned = false;
        }

        public void SignContract()
        {
            IsSigned = true;
            Console.WriteLine($"Contract signed on {SigningDate.ToShortDateString()} with a salary of {Salary:C}.");
        }

        public void TerminateContract()
        {
            IsSigned = false;
            Console.WriteLine("Contract terminated.");
        }
    }
}
