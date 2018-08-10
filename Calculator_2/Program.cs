using System;

namespace Calculator_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt user for input
            Console.WriteLine("This program is a simple calculator which can add, subtract, multiply, or divide two numbers.");
            Console.WriteLine("Please enter your first number:");
            //acquire input from user
            double numberFirst = double.Parse(Console.ReadLine());

            //prompt user for input
            Console.WriteLine("Please enter your second number:");
            //acquire input from user
            double numberSecond = double.Parse(Console.ReadLine());

            //prompt user for input
            Console.WriteLine("Please enter add, subtract, multiply, or divide to choose your mathematical operation:");
            //acquire input from user
            string operation = Console.ReadLine();

            //set a boolean to false for the do-while loop
            bool finishedCalculations = false;
            //set a value to solution as a placeholder

            //start a do-while loop
            do
            {
                if (operation == "add")
                {
                    //create a double called solution using the method Addnumbers,
                    //by passing the value of numberFirst and numberSecond into addFirst and addSecond
                    double solution = AddNumbers(numberFirst, numberSecond);

                    Console.WriteLine("Your solution is: " + solution);

                    //close the do-while loop
                    finishedCalculations = true;
                }
                else if (operation == "subtract")
                {
                    //create a double called solution using the method Addnumbers,
                    //by passing the value of numberFirst and numberSecond into subFirst and subSecond
                    double solution = SubtractNumbers(numberFirst, numberSecond);

                    Console.WriteLine("Your solution is: " + solution);

                    //close the do-while loop
                    finishedCalculations = true;
                }
                else if (operation == "multiply")
                {
                    //create a double called solution using the method Addnumbers,
                    //by passing the value of numberFirst and numberSecond into multFirst and multSecond
                    double solution = MultiplyNumbers(numberFirst, numberSecond);

                    Console.WriteLine("Your solution is: " + solution);

                    //close the do-while look
                    finishedCalculations = true;
                }
                else if (operation == "divide")
                {
                    //create a double called solution using the method Addnumbers,
                    //by passing the value of numberFirst and numberSecond into divFirst and divSecond
                    double solution = DivideNumbers(numberFirst, numberSecond);

                    Console.WriteLine("Your solution is: " + solution);

                    //close the do-while loop
                    finishedCalculations = true;
                }
                else
                {
                    Console.WriteLine("Please enter a valid operation type.");
                    operation = Console.ReadLine();
                }
            } while (finishedCalculations == false);

            //keep the program open until enter is pressed
            Console.ReadLine();
        }
        /// <summary>
        ///     Adds the two numbers entered by the user
        /// </summary>
        /// <param name="addFirst">The first number</param>
        /// <param name="addSecond">The second number</param>
        /// <returns>A sum</returns>
        private static double AddNumbers(double addFirst, double addSecond)
        {
            double methodSolution = addFirst + addSecond;
            //pass the value of solution back to Main
            return methodSolution;
        }
        /// <summary>
        ///     Subtracts the two numbers entered by the user
        /// </summary>
        /// <param name="subFirst">The first number</param>
        /// <param name="subSecond">The second number</param>
        /// <returns>A difference</returns>
        private static double SubtractNumbers(double subFirst, double subSecond)
        {
            //pass the value of solution back to Main
            double methodSolution = subFirst - subSecond;
            return methodSolution;
        }
        /// <summary>
        /// Multiplies the two numbers entered by the user
        /// </summary>
        /// <param name="multFirst">The first number</param>
        /// <param name="multSecond">The second number</param>
        /// <returns>A product</returns>
        private static double MultiplyNumbers(double multFirst, double multSecond)
        {
            //pass the value of solution back to Main
            double methodSolution = multFirst * multSecond;
            return methodSolution;
        }
        /// <summary>
        /// Divides the two numbers entered by the user
        /// </summary>
        /// <param name="divFirst">The first number</param>
        /// <param name="divSecond">The second number</param>
        /// <returns>A quotient</returns>
        private static double DivideNumbers(double divFirst, double divSecond)
        {
            //pass the value of solution back to Main
            double methodSolution = divFirst / divSecond;
            return methodSolution;
        }
    }
}
