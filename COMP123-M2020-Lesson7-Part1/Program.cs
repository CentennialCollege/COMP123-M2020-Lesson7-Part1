using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_M2020_Lesson7_Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numerator = 0;
            int denominator = 0;
            bool isNotCorrectUserInput = true;

            Vector2D position = new Vector2D();

            int[] numbers = {3, 5, 7, 9, 15};

            while (isNotCorrectUserInput)
            {
                Console.Write("Enter the Numerator: ");
                string numeratorString = Console.ReadLine();

                Console.WriteLine();

                Console.Write("Enter the Denominator: ");
                string denominatorString = Console.ReadLine();

                if ((int.TryParse(numeratorString, out numerator)) && (int.TryParse(denominatorString, out denominator)))
                {
                    isNotCorrectUserInput = false;
                }
                else
                {
                    Console.WriteLine("You must enter numbers");
                    Console.WriteLine();
                }

                //numerator = Convert.ToInt16(numeratorString);
                //denominator = Convert.ToInt16(denominatorString);
            }




            try
            {
                var result = numerator / denominator;


                if (numerator < 0)
                {
                    NegativeIndexException negativeIndex = new NegativeIndexException();
                    throw (negativeIndex);
                }

                Console.WriteLine("The array value of the numerator as index is: " + numbers[numerator]);

                Console.WriteLine();

                Console.WriteLine("The Result is: " + result);

                Console.WriteLine("The position vector is: " + position.ToString());


            }
            catch (DivideByZeroException divideByZeroException)
            {
                Console.WriteLine();
                Console.WriteLine("Your denominator cannot be zero");
                Console.WriteLine(divideByZeroException.Message);
            }
            catch (FormatException formatException)
            {
                Console.WriteLine();
                Console.WriteLine("You must enter numbers");
                Console.WriteLine(formatException.Message);
            }
            catch (OverflowException overflowException)
            {
                Console.WriteLine();
                Console.WriteLine("Your numbers were too big or too small");
                //Console.WriteLine(overflowException.Message);
            }
            catch (IndexOutOfRangeException indexOutOfRangeException)
            {
                Console.WriteLine();
                Console.WriteLine("You must enter a numerator between 0 and 4");
                Console.WriteLine(indexOutOfRangeException.Message);
            }
            catch (NegativeIndexException negativeIndexException)
            {
                Console.WriteLine();
                Console.WriteLine(negativeIndexException.Message);
            }

            catch (Exception exception)
            {
                // catch all
                // catches all exceptions
                Console.WriteLine();
                Console.WriteLine("Something went wrong...");
                Console.WriteLine(exception.Message);
            }
            finally
            {
                // always triggers
                Console.WriteLine("This always executes!!");

            }





            // wait for any key
            Console.ReadLine();
        }
    }
}
