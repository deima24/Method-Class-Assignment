using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class_Assignment
{
    internal class Program
    {
        static void Main()
        {
            // Create an instance of the MathOperations class
            MathOperations mathOps = new MathOperations();
            // Call the Add method and print the result
            int sum = mathOps.Add(5, 10);
            Console.WriteLine("Sum: " + sum);
            // Call the Subtract method and print the result
            int difference = mathOps.Subtract(15, 5);
            Console.WriteLine("Difference: " + difference);
            // Call the Multiply method and print the result
            int product = mathOps.Multiply(4, 6);
            Console.WriteLine("Product: " + product);
            // Call the Divide method and print the result
            double quotient = mathOps.Divide(20, 4);
            Console.WriteLine("Quotient: " + quotient);
            // Wait for user input before closing the console window
            Console.ReadLine();
        }

        class MathOperations
        {
            // Method to add two integers
            public int Add(int a, int b)
            {
                return a + b;
            }
            // Method to subtract two integers
            public int Subtract(int a, int b)
            {
                return a - b;
            }
            // Method to multiply two integers
            public int Multiply(int a, int b)
            {
                return a * b;
            }
            // Method to divide two integers and return a double
            public double Divide(int a, int b)
            {
                if (b == 0)
                {
                    throw new DivideByZeroException("Cannot divide by zero.");
                }
                return (double)a / b;
            }
        }
    }
}
