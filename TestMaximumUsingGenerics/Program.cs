using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaximumUsingGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for maximum number at 1st position
            MaxNumber maxNumber=new MaxNumber();
            int val = maxNumber.PrintMaxNumber(30, 10, 20);
            Console.WriteLine("Maximum number is "+val);

            //for maximum number at 2nd position
            MaxNumber maxNumber1 = new MaxNumber();
            int val1 = maxNumber1.PrintMaxNumber(4 , 5, 3);
            Console.WriteLine("Maximum number is " + val1);
           
            //for maximum number at 3rd position
            MaxNumber maxNumber2 = new MaxNumber();
            int val2 = maxNumber2.PrintMaxNumber(8, 9,10);
            Console.WriteLine("Maximum number is " + val2);


            Console.ReadLine();

        }
    }
}
