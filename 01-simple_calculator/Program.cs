using System;

namespace ComplexCalc
{
    class Calc
    {
        /**
        * Add - Double typed method implementation
        * @a: double
        * @b: double
        */

        public static void Main(string[] args)
        {
            double x, y;

            Console.Write("Enter first number: ");
            string? input = Console.ReadLine();

            if (input != null)
            {
                x = Convert.ToDouble(input);
            }
            else
            {
                Console.WriteLine("Invalid input for first number.");
                return;
            }

            Console.Write("Enter second number: ");
            string? input2 = Console.ReadLine();

            if (input2 != null)
            {
                y = Convert.ToDouble(input2);
            }
            else
            {
                Console.WriteLine("Invalid input for second number.");
                return;
            }

            Console.Write("Enter an operator: [+,-,*,/, %]: ");
            string? input3 = Console.ReadLine();

            if (input3 != null && input3.Length > 0)
            {
                char op = input3[0];

                switch (op)
                {
                    case '+':
                        Console.WriteLine(x + y);
                        break;
                    case '-':
                        Console.WriteLine(x - y);
                        break;
                    case '*':
                        Console.WriteLine(x * y);
                        break;
                    case '/':
                        try
                        {
                            Console.WriteLine(x / y);
                        }
                        catch (DivideByZeroException e)
                        {
                            Console.WriteLine("Cannot divide by zero" + e);
                        }
                        break;
                    case '%':
                        Console.WriteLine(x % y);
                        break;
                    default:
                        Console.WriteLine("Invalid operator");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input for operator.");
            }
        }
    }
}
