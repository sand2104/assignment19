//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assignment19

//part1


//{
//    delegate int ArithmeticOperation(int num1, int num2);
//    class Program
//    {
//        static int Add(int num1, int num2)
//        {
//            return num1 + num2;
//        }

//        static int Subtract(int num1, int num2)
//        {
//            return num1 - num2;
//        }

//        static int Multiply(int num1, int num2)
//        {
//            return num1 * num2;
//        }

//        static int Divide(int num1, int num2)
//        {
//            if (num2 != 0)
//                return num1 / num2;
//            else
//            {
//                Console.WriteLine("Error: Division by zero is not allowed.");
//                return 0;
//            }
//        }

//        static void Main(string[] args)
//        {
//            ArithmeticOperation addDelegate = Add;
//            ArithmeticOperation subtractDelegate = Subtract;
//            ArithmeticOperation multiplyDelegate = Multiply;
//            ArithmeticOperation divideDelegate = Divide;


//            Console.Write("Enter the first integer: ");
//            int num1 = int.Parse(Console.ReadLine());

//            Console.Write("Enter the second integer: ");
//            int num2 = int.Parse(Console.ReadLine());


//            Console.WriteLine("Choose an arithmetic operation:");
//            Console.WriteLine("1. Addition");
//            Console.WriteLine("2. Subtraction");
//            Console.WriteLine("3. Multiplication");
//            Console.WriteLine("4. Division");
//            Console.Write("Enter your choice (1/2/3/4): ");
//            int choice = int.Parse(Console.ReadLine());


//            int result = 0;
//            switch (choice)
//            {
//                case 1:
//                    result = addDelegate(num1, num2);
//                    break;
//                case 2:
//                    result = subtractDelegate(num1, num2);
//                    break;
//                case 3:
//                    result = multiplyDelegate(num1, num2);
//                    break;
//                case 4:
//                    result = divideDelegate(num1, num2);
//                    break;
//                default:
//                    Console.WriteLine("Invalid choice!");
//                    return;
//            }

//            Console.WriteLine($"Result: {result}");
//        }
//    }
//}



//Part2


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment19
{
    delegate T Operation<T>(T num1, T num2);

    class Program
    {

        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        static int Divide(int num1, int num2)
        {
            if (num2 != 0)
                return num1 / num2;
            else
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                return 0;
            }
        }


        static T GetUserInput<T>(string prompt)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();

            try
            {
                return (T)Convert.ChangeType(input, typeof(T));
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input format.");
                return default(T);
            }
        }

        static void Main(string[] args)
        {

            Operation<int> addDelegate = Add;
            Operation<int> subtractDelegate = Subtract;
            Operation<int> multiplyDelegate = Multiply;
            Operation<int> divideDelegate = Divide;


            int num1 = GetUserInput<int>("Enter the first integer: ");
            int num2 = GetUserInput<int>("Enter the second integer: ");


            Console.WriteLine("Choose an arithmetic operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.Write("Enter your choice (1/2/3/4): ");
            int choice = int.Parse(Console.ReadLine());


            int result = 0;
            switch (choice)
            {
                case 1:
                    result = addDelegate(num1, num2);
                    break;
                case 2:
                    result = subtractDelegate(num1, num2);
                    break;
                case 3:
                    result = multiplyDelegate(num1, num2);
                    break;
                case 4:
                    result = divideDelegate(num1, num2);
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    return;
            }

            Console.WriteLine($"Result: {result}");
        }
    }
}