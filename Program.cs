using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Pedro Marchante
 * MSSA cohort 2
 * 
 * Syntactic sugar is the lazy mans method of short handing code. it can be benefitial and help save keystrokes, but sometimes it can make the code harder to read if someone junior
 * is analyzing the code.
 */
namespace HW_2C
{
    class Program
    {
        void student(String name = "default", int age = 0)
        {
            Console.WriteLine($"my name is {name} and i am {age} years old");
        }

        static void Main(string[] args)
        {
            Program test = new Program();
            //no parameters are passed for the student method, so it will print the hard coded default values
            test.student();

            //now it will print the name and age we passed it

            test.student("pedro", 29);
        }
    }
}
