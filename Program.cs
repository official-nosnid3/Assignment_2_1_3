using System.Net.NetworkInformation;

namespace Assignment_2_1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Assignment 2.1.3
             * 
             * 3. Overloading: Write a simple Maths class ( don’t use the keyword Math, it will be a conflict with standard class from system). 
             * Write overloaded methods with logic and give choice to user to call different methods :
             * 
             * a. Add(int num1, int num2)
             * b. Add(decimal num1, decimal num2, decimal num3)
             * c. Multiply(float num1, float num2)
             * d. Multiply( float num1, float num2, float num3)
             * Declare these methods as public and static.
             */
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static decimal Add(decimal a, decimal b, decimal c)
        {
            return a + b + c;
        }

        public static float Multiply(float a, float b)
        {
            return a * b;
        }

        public static float Multiply(float a, float b, float c)
        {
            return a * b * c;
        }
    }
}
