using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld1
{
    public class Calculator
    {

        public void AdditionOfTwoNumbers()
        {
            Console.WriteLine("Please provide 2 numbers for add");
            Console.WriteLine("Please enter 1st number");
            int firstNumb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter 2nd number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum:" + (firstNumb + secondNumber));
        }

        public void DifferenceOfTwoNumbers()
        {
            Console.WriteLine("Please provide 2 numbers for Substarct");
            Console.WriteLine("Please enter 1st number");
            int firstNumb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter 2nd number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Diff:" + Math.Abs(firstNumb - secondNumber));
        }
    }
}
