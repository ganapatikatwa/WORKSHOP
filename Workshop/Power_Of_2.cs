using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop
{
    public class Power_Of_2
    {
        public void Pow_2()
        {
            Console.WriteLine("Enter any Positive integer to find the Power of 2");
            int power =Int32.Parse(Console.ReadLine());
            Console.WriteLine("Your find 2 Power {0}, power");
            double pow = 0;

            for (int i=1;i<=power; i++)
            {
                pow = Math.Pow(2, power);
            }

            Console.WriteLine("The power of 2 is"+pow);
        }
    }
}
