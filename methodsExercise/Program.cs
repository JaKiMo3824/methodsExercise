using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodsExercise
{
    class Program
    {

        //Methods exercises 1-3

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a whole number and I will do a few operations to it and return the results..");
            int num1 = Convert.ToInt32(Console.ReadLine());

            int answer1 = Methods.DivideNums(num1);
            Console.WriteLine("Your number " + num1 + " divided by 2 = " + answer1);

            int answer2 = Methods.MultiplyNums(num1);
            Console.WriteLine("Your number " + num1 + " multiplied by 2 = " + answer2);

            int answer3 = Methods.AddNums(num1);
            Console.WriteLine("Your number " + num1 + " plus 2 " + answer3);

            Console.ReadLine();


        }
    }
}
