using System;

namespace _06_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op1 = int.Parse(Console.ReadLine());
            int op2 = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();

            int result = 0;
            string modDiv = "";

            switch (operation)
            {
                case "*":
                case "-":
                case "+":
                    switch (operation)
                    {
                        case "-":
                            result = op1 - op2;
                            break;
                        case "+":
                            result = op1 + op2;
                            break;
                        case "*":
                            result = op1 * op2;
                            break;
                    }
                    if (result % 2 == 0)
                        modDiv = "even";
                    else
                        modDiv = "odd";
                    Console.WriteLine($"{op1} {operation} {op2} = {result} - {modDiv}");
                    break;

                case "%":
                case "/":
                    if (op2 != 0)
                    {
                        if (operation == "/")
                        {
                            double dres = (double)op1 / op2;
                            Console.WriteLine($"{op1} / {op2} = {dres:f2}");
                        }
                        else
                            Console.WriteLine($"{op1} % {op2} = {op1 % op2}");
                    }
                    else
                    {
                        Console.WriteLine($"Cannot divide {op1} by zero");
                    }
                    break;


            }

        }
    }
}