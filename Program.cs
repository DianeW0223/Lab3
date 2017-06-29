using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            bool run = true;
            int input = 0;
            Console.WriteLine("Welcome Class");
            Console.WriteLine("Please enter a whole number to find the square and cubed dimensions from 1 to your input number");
            input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number\t" + "Square\t" + "Cube" + "\n======================");

            while ((run == true) && (input >= number))
            {
                int square = number * number;
                int cube = number * number * number;
                Console.WriteLine(number + "\t" + square + "\t" + cube);
                number++;
            }
            
        }
     
    }
}   



            
    

