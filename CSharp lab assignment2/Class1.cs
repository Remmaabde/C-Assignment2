using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CSharp_lab_assignment2
{
    internal class Class1
    {
        static void main(String[] args)
        {
            int age;
            String name;
            WriteLine("Welcome to AGP contest: Please Enter your age: >>");
            age = Convert.ToInt32(ReadLine());
            if (age == 0 || age > 100)
            {
                for (int i = 0; i < 100; i++)
                    Write(i);
                WriteLine("Please Enter A valid age");
            }
            else if (age < 18)
                WriteLine("Sorry You are underage!");
            else if (age < 21)
                WriteLine("you need a parental consent");
            else
            {
                WriteLine("Congratulations! You may sign up for the contest");

            }

            }
        }
    }
}
