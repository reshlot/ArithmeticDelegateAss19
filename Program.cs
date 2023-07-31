using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticDelegate
{
    public delegate int ArithmeticOperation(int a, int b);

    public class Program
    {
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
            return a / b;
        }

        public static void Main(string[] args)
        {

            Console.WriteLine("***Arithmetic Delegate***\n");
            Console.WriteLine("Enter two integers:");

            Console.WriteLine("Enter value1:");
            int value1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter value 2:");
            int value2 = int.Parse(Console.ReadLine());

            ArithmeticOperation addOperation = Add;
            ArithmeticOperation subtractOperation = Subtract;
            ArithmeticOperation multiplyOperation = Multiply;
            ArithmeticOperation divideOperation = Divide;

            bool exit = false;

            do
            {


                Console.WriteLine("Choose an arithmetic operation:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");

                int choice = int.Parse(Console.ReadLine());

                int result = 0;

                switch (choice)
                {
                    case 1:
                        result = addOperation(value1, value2);
                        Console.WriteLine($"Result of addition: {result}");
                        break;
                    case 2:
                        result = subtractOperation(value1, value2);
                        Console.WriteLine($"Result of subtraction: {result}");
                        break;
                    case 3:
                        result = multiplyOperation(value1, value2);
                        Console.WriteLine($"Result of multiplication: {result}");
                        break;
                    case 4:
                        result = divideOperation(value1, value2);
                        Console.WriteLine($"Result of division: {result}");
                        break;
                    case 5:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
                Console.WriteLine();
            }
            while (!exit);
        }
    }
    
}
