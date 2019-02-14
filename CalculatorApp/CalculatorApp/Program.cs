using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{

    class Program
    {
        static string option, area_option, basic_option, resume = "";
        static double firstNumber, secondNumber, ans = 0;
        static double pie = Math.PI;

        
        static void Main(string[] args)
        {
            Program.initCalculator();
        }

        public static void initCalculator()
        {
            do
            {

            Console.WriteLine("Hello this is a advanced calculator please enter " + "\n" +
                "(a) for calculating the area of a shape or (b) for basic mathematic calculations");

            option = (Console.ReadLine()).ToLower();

            if (option == "a" || option == "b")
            {
                if (option == "a")
                {
                    Console.WriteLine("Do you want to want to calculate the area of a " +
                        "(s)quare/rectangle, (c)ircle or (t)riangle ");
                    area_option = Console.ReadLine();
                    switch (area_option.ToLower())
                    {
                        case "s":
                            Program.shape(Convert.ToInt32(firstNumber), Convert.ToInt32(secondNumber));
                            break;
                        case "c":
                            Program.calculaton_plus(firstNumber, secondNumber);
                            break;
                        case "t":
                            Program.shape(firstNumber);
                            break;
                        default:
                            Console.WriteLine("Enter a valid input");
                            Console.Read();
                            break;
                    }


                }
                else
                {
                    Console.WriteLine("Please select an operator (+,-,/,*)");
                    basic_option = Console.ReadLine();
                    switch (basic_option)
                    {
                        case "+":
                            Program.calculaton_plus(firstNumber, secondNumber);
                            break;

                        case "-":
                            Program.calculaton_subtract(firstNumber, secondNumber);
                            break;

                        case "/":
                            Program.calculaton_divide(firstNumber, secondNumber);
                            break;

                        case "*":
                            Program.calculaton_multi(firstNumber, secondNumber);
                            break;

                        default:
                            Console.WriteLine("Enter a valid input");
                            Console.Read();
                            break;

                    }

                }

            }
            else
            {
                Console.WriteLine("You have selected an invalid input");
                Console.Read();
            }

                Console.WriteLine("Do you want to perform another calculation,\n" +
                    " press the enter key if not enter (q)");

                resume = (Console.ReadLine()).ToLower();

            } while (resume != "q");

        }


        //calculations
        static void calculaton_plus (double num1, double num2)
        {
            double ans;
            Console.WriteLine("Please enter height");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter width");
            num2 = Convert.ToDouble(Console.ReadLine());
            ans = num1 + num2;
            Console.WriteLine("The area of your shape is: " + ans);
            Console.ReadKey();
        }

        static void calculaton_subtract(double num1, double num2)
        {
            double ans;
            Console.WriteLine("Please enter height");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter width");
            num2 = Convert.ToDouble(Console.ReadLine());
            ans = num1 - num2;
            Console.WriteLine("The area of your shape is: " + ans);
            Console.ReadKey();
        }

        static void calculaton_multi(double num1, double num2)
        {
            double ans;
            Console.WriteLine("Please enter height");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter width");
            num2 = Convert.ToDouble(Console.ReadLine());
            ans = num1 * num2;
            Console.WriteLine("The area of your shape is: " + ans);
            Console.ReadKey();
        }

        static void calculaton_divide(double num1, double num2)
        {
            double ans;
            Console.WriteLine("Please enter height");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter width");
            num2 = Convert.ToDouble(Console.ReadLine());
            ans = num1 / num2;
            Console.WriteLine("The area of your shape is: " + ans);
            Console.ReadKey();
        }

        static void shape(double num1, double num2)
        {
            Console.WriteLine("Please enter height");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter width");
            num2 = Convert.ToDouble(Console.ReadLine());
            ans = (num1 * num2) / 2;
            Console.WriteLine("The area of your shape is: " + ans);
            Console.ReadKey();
        }

        static void shape(int num1, int num2)
        {
            Console.WriteLine("Please enter height");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter width");
            num2 = Convert.ToInt32(Console.ReadLine());
            ans = (num1 * num2) / 2;
            Console.WriteLine("The area of your shape is: " + ans);
            Console.ReadKey();
        }

        static void shape(double num1)
        {
            Console.WriteLine("Please enter the radius");
            num1 = Convert.ToDouble(Console.ReadLine());
            ans = pie*(num1 * num1);
            Console.WriteLine("The area of your shape is: " + ans);
            Console.ReadKey();
        }


        
    }
}

