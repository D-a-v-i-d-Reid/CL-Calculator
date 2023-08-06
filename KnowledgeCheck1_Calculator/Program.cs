using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");

            var input = Console.ReadLine();
            var calculator = new Calculator();


            switch (input)
            {
                case "1":
                    Console.WriteLine("Enter 2 integers to add");
                    var addNumber1 = UserInput("Enter the first number:");
                    var addNumber2 = UserInput("Enter the second number:");

                    Console.Write($"{addNumber1} + {addNumber2} = ");
                    Console.Write(calculator.Add(addNumber1, addNumber2));

                    break;

                case "2":
                    Console.WriteLine("Enter 2 integers to subtract");
                    var subtractNumber1 = UserInput("Enter the first number:");
                    var subtractNumber2 = UserInput("Enter the second number:");

                    Console.Write($"{subtractNumber1} - {subtractNumber2} = ");
                    Console.Write(calculator.Subtract(subtractNumber1, subtractNumber2));

                    break;

                case "3":
                    Console.WriteLine("Enter 2 integers to multiply");
                    var multiplyNumber1 = UserInput("Enter the first number:");
                    var multiplyNumber2 = UserInput("Enter the second number:");

                    Console.Write($"{multiplyNumber1} * {multiplyNumber2} = ");
                    Console.Write(calculator.Multiply(multiplyNumber1, multiplyNumber2));

                    break;

                case "4":
                    Console.WriteLine("Enter 2 integers to divide");
                    var divideNumber1 = UserInput("Enter the first number:");
                    var divideNumber2 = UserInput("Enter the second number:");

                    if (divideNumber2 != 0)
                    {
                        Console.Write($"{divideNumber1} / {divideNumber2} =  ");
                        Console.Write(calculator.Divide(divideNumber1, divideNumber2));
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero.");
                    }
                    break;


                default:
                    Console.WriteLine("Unknown input");
                    break;
            }



            static int UserInput(string prompt)
            {
                int inputNumber;
                bool isValidInput = false;

                do
                {
                    Console.Write(prompt + "  ");
                    string input = Console.ReadLine();
                    isValidInput = int.TryParse(input, out inputNumber);

                    if (!isValidInput)
                    {
                        Console.WriteLine("Invalid input. Please enter an integer.");
                    }
                } while (!isValidInput);

                return inputNumber;


            }

        }
    }
}




