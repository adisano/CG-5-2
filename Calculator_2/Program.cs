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
            double solution = 0;

            //start a do-while loop
            do
            {
                if (operation == "add")
                {
                    //pass the value of numberFirst and numberSecond into addFirst and addSecond
                    AddNumbers(numberFirst, numberSecond);
                    Console.WriteLine("Your solution is: " + solution);
                    //close the do-while loop
                    finishedCalculations = true;
                }
                else if (operation == "subtract")
                {
                    //pass the value of numberFirst and numberSecond into subFirst and subSecond
                    SubtractNumbers(numberFirst, numberSecond);
                    Console.WriteLine("Your solution is: " + solution);
                    //close the do-while loop
                    finishedCalculations = true;
                }
                else if (operation == "multiply")
                {
                    //pass the value of numberFirst and numberSecond into multFirst and multSecond
                    MultiplyNumbers(numberFirst, numberSecond);
                    Console.WriteLine("Your solution is: " + solution);
                    //close the do-while look
                    finishedCalculations = true;
                }
                else if (operation == "divide")
                {
                    //pass the value of numberFirst and numberSecond into divFirst and divSecond
                    DivideNumbers(numberFirst, numberSecond);
                    Console.WriteLine("Your solution is: " + solution);
                    //close the do-while loop
                    finishedCalculations = true;
                }
                else
                {
                    Console.WriteLine("Please enter a valid operation type.");
                }
            } while (finishedCalculations == false);



            
            //keep the program open until enter is pressed
            Console.ReadLine();
        }
        private static double AddNumbers(double addFirst, double addSecond)
        {
            solution = addFirst + addSecond;
            //pass the value of solution back to Main
            return solution;
        }
        private static double SubtractNumbers(double subFirst, double subSecond)
        {
            //pass the value of solution back to Main
            solution = subFirst - subSecond;
            return solution;
        }
        private static double MultiplyNumbers(double multFirst, double multSecond)
        {
            //pass the value of solution back to Main
            solution = multFirst * multSecond;
            return solution;
        }
        private static double DivideNumbers(double divFirst, double divSecond)
        {
            //pass the value of solution back to Main
            solution = divFirst / divSecond;
            return solution;
        }
    }
}
