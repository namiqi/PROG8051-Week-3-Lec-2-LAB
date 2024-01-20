using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                        Currency Converter:
                            Build a currency conversion program that converts an amount from one currency to another. 
                            Allow the user to choose the conversion rates and currencies.
            */

            Console.WriteLine("Please enter a your currency (current): ");
            string currencyhave = Console.ReadLine();
            Console.WriteLine("Please enter the currency you want: ");
            string currencywant = Console.ReadLine();
            Console.WriteLine("Please enter the amount you want to exchange: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            double finalamount=1;

            if (currencyhave == "CAD" && currencywant == "USD") {
                finalamount = amount * 0.74;
            }
            Console.WriteLine(finalamount);

            /* Even or Odd:
             Prompt the user to enter an integer and determine whether it's even or odd. Display an appropriate message.
 */
            Console.WriteLine("Please enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine(number + " is even");
            }
            else {
                Console.WriteLine(number + " is odd");
            }

            // LAB Exercise : Try with Switch Case
            /* Grade Calculator:
             Write a program that takes a numeric grade as input and prints the corresponding letter grade(A, B, C, D, or F) based on a set of grading rules.
             */

            // A - 90 <= grade <= 100 
            // B - 80 <= grade < 90
            // C - 70 <= grade < 80 
            // D - 55 <= grade < 70
            // F - grade < 55 

            // Take numerical input from the user
            Console.WriteLine("Please enter your grade: ");
            double grade = Convert.ToDouble(Console.ReadLine());
            char lettergrade = ' ';


            if (grade > 100) {
                Console.WriteLine("Grade should be between 0 and 100, please try again");
                return;
            }


            if (grade >= 90 && grade <= 100)
            {
                lettergrade = 'A';
            }
            else if (grade >= 80 && grade < 90)
            {
                lettergrade = 'B';
            }

            else if (grade >= 70 && grade < 80) {
                lettergrade = 'C';
            }

            else if (grade >= 55 && grade < 70)
            {
                lettergrade = 'D';
            }
            else
            {
                    Console.WriteLine("unfortunetaly you did not pass the course and your grade is F");
                    return ;
             }

            string output = $"Your grade is {lettergrade}";
            Console.WriteLine(output);

        }
    }
}

/*Simple Calculator:
Create a program that takes two numbers and an operator (+, -, *, /) as input from the user and performs the corresponding arithmetic operation.

Grade Calculator:
Write a program that takes a numeric grade as input and prints the corresponding letter grade (A, B, C, D, or F) based on a set of grading rules.

Temperature Converter:
Develop a program that converts a temperature in Fahrenheit to Celsius or vice versa, based on user input.

Even or Odd:
Prompt the user to enter an integer and determine whether it's even or odd. Display an appropriate message.

Leap Year Checker:
Ask the user for a year as input and determine whether it's a leap year or not, considering leap year rules.

Age Classifier:
Take the user's age as input and categorize it as infant, child, teenager, adult, or senior based on predefined age ranges.

BMI Calculator:
Create a program that calculates the Body Mass Index (BMI) based on the user's weight and height and displays their BMI category (e.g., underweight, normal, overweight, obese).

Currency Converter:
Build a currency conversion program that converts an amount from one currency to another. Allow the user to choose the conversion rates and currencies.

Simple Password Validator:
Implement a program that checks whether a user-entered password meets certain criteria (e.g., length, containing uppercase, lowercase, and numeric characters).

Rock, Paper, Scissors Game:
Create a simple rock, paper, scissors game where the user can input their choice, and the program randomly selects a choice for the computer. Determine the winner based on the game's rules.*/