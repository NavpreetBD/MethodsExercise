using System.Diagnostics.CodeAnalysis;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            MethodName();
            Console.WriteLine(Add(5, 6));
            Console.WriteLine(Subtract(10, 8));
            Console.WriteLine(Multiply(2, 2));
            Console.WriteLine(Divide(6, 3));
            Console.WriteLine(Modulus(4,2));
        }
        public static void MethodName()
        {
            Console.WriteLine("========  Exercise 1 ========");

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("what is your favorite color");
            string color = Console.ReadLine();

            Console.WriteLine("what is your favourite animal");
            string animal = Console.ReadLine();

            Console.WriteLine("what is your favourite band");
            string band = Console.ReadLine();

            Console.WriteLine($"{name}likes {color} and love {animal}. i like {band} band");
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static int Divide(int a, int b)
        {
            if (b != 0)
                return a / b;
            else
            {
                Console.WriteLine("Cannot divide by zero.");
                return 0; 
            }
        }

        public static int Modulus(int a, int b)
        {
            if (b != 0)
                return a % b;
            else
            {
                Console.WriteLine("Cannot perform modulus with zero divisor.");
                return 0; 
            }
        }
    }
}
