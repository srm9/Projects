using System;
using System.IO;

namespace Calculator
{
    class Program1
    {
        Nullable<double> result1 = null;
        static void Main(string[] args)
        {
            Program1 d = new Program1();

            Nullable<double> num1 = null;
            Nullable<double> num2 = null;
            
            bool div = false;

            Console.WriteLine("CSCI 330 C# Calculator Demo");

            try
            {

                while (!div)
                {
                    Console.WriteLine("Chose an option: ");
                    Console.WriteLine("1 - Add");
                    Console.WriteLine("2 - Subtract");
                    Console.WriteLine("3 - Multiply");
                    Console.WriteLine("4 - Divide");
                    Console.WriteLine("5 - Mod");
                    Console.WriteLine("6 - Close");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            Console.WriteLine("Input a number and press enter: ");
                            while (!num1.HasValue)
                            {
                                try
                                {
                                    num1 = Convert.ToInt32(Console.ReadLine());
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Must enter a number");
                                }
                            }

                            Console.WriteLine("Input another number and press enter: ");
                            while (!num2.HasValue)
                            {
                                try
                                {
                                    num2 = Convert.ToInt32(Console.ReadLine());
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Must enter a number");
                                }
                            }
                            d.result1 = num1 + num2;
                            Console.WriteLine();
                            Console.WriteLine("Answer: " +  d.result1);
                            Console.WriteLine();
                            num1 = null;
                            num2 = null;
                            break;
                        case "2":
                            Console.WriteLine("Input a number and press enter: ");
                            while (!num1.HasValue)
                            {
                                try
                                {
                                    num1 = Convert.ToInt32(Console.ReadLine());
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Must enter a number");
                                }
                            }

                            Console.WriteLine("Input another number and press enter: ");
                            while (!num2.HasValue)
                            {
                                try
                                {
                                    num2 = Convert.ToInt32(Console.ReadLine());
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Must enter a number");
                                }
                            }
                            Console.WriteLine();

                            d.result1 = num1 - num2;
                            Console.WriteLine("Answer: " + d.result1);
                            Console.WriteLine();
                            num1 = null;
                            num2 = null;
                            break;
                        case "3":
                            Console.WriteLine("Input a number and press enter: ");
                            while (!num1.HasValue)
                            {
                                try
                                {
                                    num1 = Convert.ToInt32(Console.ReadLine());
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Must enter a number");
                                }
                            }

                            Console.WriteLine("Input another number and press enter: ");
                            while (!num2.HasValue)
                            {
                                try
                                {
                                    num2 = Convert.ToInt32(Console.ReadLine());
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Must enter a number");
                                }
                            }
                            Console.WriteLine();
                            Console.WriteLine("Answer: " +  num1 * num2);
                            Console.WriteLine();    
                            num1 = null;
                            num2 = null;
                            break;
                        case "4":


                            Console.WriteLine("Input a number and press enter: ");
                            while (!num1.HasValue)
                            {
                                try
                                {
                                    num1 = Convert.ToInt32(Console.ReadLine());
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Must enter a number");
                                }
                            }

                            Console.WriteLine("Input another number and press enter: ");
                            while (!num2.HasValue)
                            {
                                try
                                {
                                    num2 = Convert.ToInt32(Console.ReadLine());
                                    if (num2 == 0)
                                    {
                                        Console.WriteLine("Cannot divide by zero, please enter a valid number: ");
                                        num2 = null;
                                    }
                                        
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Must enter a number");
                                }
                            }

                            Console.WriteLine();
                            d.divide(num1, num2);
                            Console.WriteLine();
                            num1 = null;
                            num2 = null;

                            //Console.WriteLine(num1 / num2);
                            break;
                        case "5":
                            Console.WriteLine("Input a number and press enter: ");
                            while (!num1.HasValue)
                            {
                                try
                                {
                                    num1 = Convert.ToInt32(Console.ReadLine());
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Must enter a number");
                                }
                            }

                            Console.WriteLine("Input another number and press enter: ");
                            while (!num2.HasValue)
                            {
                                try
                                {
                                    num2 = Convert.ToInt32(Console.ReadLine());
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Must enter a number");
                                }
                            }
                            Console.WriteLine();
                            Console.WriteLine("Answer: " + num1 % num2);
                            Console.WriteLine();
                            num1 = null;
                            num2 = null;
                            break;

                        case "6":
                            System.Environment.Exit(1);
                            div = true;
                            break;
                    }
                }
            }

            catch (IOException)
            {
                Console.WriteLine("Exception thrown");
            }
        }
        public void divide(double? n1, double? n2)
        {

            try
            {
                result1 = n1 / n2;
                Console.WriteLine("Answer: " +  result1);
                result1 = null;

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Can not divide by zero (0) " + e);
            }
        }

    }


}
