using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    public static class Exercises
    {
        // Example Exercise:
        // Create a method called HelloWorld that returns the following string - "Hello World!"
        public static string HelloWorld() {
            return "Hello World!";
        }

        /* Alright - your turn now! */

        // 1. Create a method called SayHello that accepts a string representing a name and returns a welcome message (E.g. "Hello John!")
        public static string SayHello(string name) {
            return ($"Hello {name}!");
        }
        // 2. Create a method called Sum that accepts two integers and returns their sum.
        public static int Sum(int number1, int number2) {
            return (number1 + number2);
        }
        // 3. Create a method called Divide that accepts two decimals and returns the result of dividing the two numbers as a decimal.
        public static decimal Divide(decimal number1, decimal number2) {
            return (number1 / number2);
        }
        // 4. Create a method called CanOpenCheckingAccount that accepts an integer representing a customers age, returning true if the age is greater than or equal to 18, or false if the argument is less than 18.
        public static Boolean CanOpenCheckingAccount(int age) {
            if (age >= 18) {
                return true;
            } else {
                return false;
            }
        }
        // 5. Create a method called GetFirstName that accepts a string representing a full name (e.g. "John Smith"), and returns only the first name.
        public static string GetFirstName(string name) {
            var firstWord = name.Substring(0, name.IndexOf(" "));
            return firstWord;
        }
        // 6. Create a method called ReverseStringHard that accepts a string and returns the string in reverse. (No built in functions allowed)
        public static string ReverseStringHard(string stringToReverse) {
            string reversedString = ""; // to store the value of the reversed string
            int length; // for counting the length of the given string
            length = stringToReverse.Length - 1; // stores the length of the given string

            while (length >= 0) { // loops the given string's length
        
                reversedString = reversedString + stringToReverse[length];
                length--;
            }

            return reversedString;

        }
        // 7. Create a method called ReverseStringEasy that accepts a string and returns the string in reverse. (Using only built in functions)
        public static string ReverseStringEasy (string stringToReverse) {
            char[] charArray = stringToReverse.ToCharArray(); // the .ToCharArray method will convert a string to an array of characters
            Array.Reverse(charArray); // the Array.Reverse method is a built-in of C# that reverses the order of an array
            return new string(charArray); // new string is a way to construct a string from an array of characters
        }

        // 8. Create a method called PrintTimesTable that accepts an integer and returns the times table as a string for that number up to the 10th multiplication.
        /* e.g. 10 should return
         * 10 * 1 = 10
         * 10 * 2 = 20
         * 10 * 3 = 30
         * 10 * 4 = 40
         * 10 * 5 = 50
         * 10 * 6 = 60
         * 10 * 7 = 70
         * 10 * 8 = 80
         * 10 * 9 = 90
         * 10 * 10 = 10 */

        public static string PrintTimesTable(int number) {
            int multiplier, product;
            string timesTableString;
            string[] timesTableArrayOfStrings = new String[10]; //initializes an empty array of strings that is 10 elements large
            
            for (multiplier = 0; multiplier < 10; multiplier++) {
                product = (multiplier + 1) * number; // calculate product of multiplier and multipicant
                timesTableArrayOfStrings[multiplier] = $"{number} * {multiplier + 1} = {product}"; // store the complete equation in string format into the appropriate element of the array
            }
            timesTableString = string.Join("\r\n", timesTableArrayOfStrings); //join the timeTables array of strings into one string and append a \r\n between each element. 
            return timesTableString;
        }

        // 9. Create a method called ConvertKelvinToFahrenheit that accepts a double representing a temperature in kelvin and returns a double containing the temperature in Fahrenheit.
        public static double ConvertKelvinToFahrenheit(double tempInKelvin) {
            double tempInFarenheit;
            tempInFarenheit = ((tempInKelvin * 9 / 5) - 459.67);
            return tempInFarenheit;
        }
        // 10. Create a method called GetAverageHard that accepts an array of integers and returns the average value as a double. (No built in functions allowed)
        public static double GetAverageHard(int[] integers) {
            int index = 0; 
            double result = 0;

            while (index < integers.Length) { // iterates through the integers array
            
                result += integers[index]; // adds the value within the current element of the integer array into a running total (result)
                index++;
            }

            return result/(integers.Length); // returns the average 
        }
        // 11. Create a method called GetAverageEasy that accepts an array of integers and returns the average value as a double. (Using only built in functions)
        public static double GetAverageEasy (int[] integers) {
            double average = integers.Average();
            Console.WriteLine(average);
            return average;
        }

        // 12. Create a method called DrawTriangle that accepts two integers - number and width and returns a string containing a drawn triangle using the number parameter.
        /* e.g. Number: 8, Width: 8 should return
         * 88888888
         * 8888888
         * 888888
         * 88888
         * 8888
         * 888
         * 88
         * 8 */

        // use number 5 with width of 4

        public static string DrawTriangle(int number, int width) {

            string triangleToDisplay = ""; // string that will hold the final string output to be displayed
            string triangleRow = ""; // string that will hold the current row that will be added to the final string output
            int counter = width; // counter to add each row to the final output
            int counter2 = width; // counter to build up each row

            for (counter = width; counter > 0; counter--) {

                counter2 = counter;

                // build up each row by concatenating the number "counter2" times.
                while (counter2 > 0) { 
                    triangleRow += $"{number}";
                    counter2--;
                }

                // adds latest row to the final string output. Check to see if it is the last row. If so, do not add a \r\n.
                if (counter > 1) {
                    triangleToDisplay += triangleRow + "\r\n";
                } else {
                    triangleToDisplay += triangleRow;
                }

                triangleRow = ""; //empties row value so we can build up the next row value
            }
            return triangleToDisplay;
        }

        // 13. Create a method called GetMilesPerHour that accepts a double representing distance and three integers representing hours, minutes and seconds. The method should return the speed in MPH rounded to the nearest whole number as a string. (e.g. "55MPH")
        public static string GetMilesPerHour(double distance, int hours, int minutes, int seconds) {

            double minutesInHourFormat = (double)minutes / 60; // cast minutes to be a double and then convert minutes to hours
            double secondsInHourFormat = (double)seconds / 3600; // cast seconds to be a double and then convert seconds to hours
            double totalTimeInHourFormat = (double)hours + minutesInHourFormat + secondsInHourFormat; // cast hours to a double and then add to it the minutes and seconds, both in hour form 
            double milesPerHour = Math.Ceiling(distance / totalTimeInHourFormat); // round up the miles per hour result
            string milesPerHourInStringForm = $"{milesPerHour}" + "MPH"; // create the string message to be outputted
            return milesPerHourInStringForm;
        }

        // 14. Create a method called IsVowel that accepts a char parameter and returns true if the parameter is a vowel or false if the parameter is a consonant.
        public static bool IsVowel (char character) {
            bool isVowel = "aeiouAEIOU".IndexOf(character) >= 0; // checks to see if aeiouAEIOU is within the character passed into this function
            return isVowel;
        }
        // 15. Create a method called IsConsonant that accepts a char parameter and returns true if the parameter is a consonant or false if the parameter is a vowel.
        public static bool IsConsonant(char character) {
            bool isConsontant = "aeiouAEIOU".IndexOf(character) < 0; // checks to see if aeiouAEIOU is within the character passed into this function
            return isConsontant;
        }

        // 16. The Collatz conjecture, named after Lothar Collatz of Germany, proposed the following conjecture in 1937. 
        // Beginning with an integer n > 1, repeat the following until n == 1. If n is even, halve it. If n is odd, triple it and add 1. Following these steps, the function will always arrive at the number 1.
        // Create a method called CollatzConjecture that accepts an integer and returns the number of steps required to get to n == 1 as an integer.
        public static int CollatzConjecture (int integer) {

            int numberofSteps = 0;

            while (integer > 1) // loops through until integer = 1
            {
                if (integer % 2 == 0) { // if number is even, divide it by 2
                    integer = integer / 2;
                    numberofSteps++;
                }
                else { // if number is odd, multiply it by 3 and add 1
                    integer = (3 * integer) + 1;
                    numberofSteps++;
                }
            }
            return numberofSteps;
        }
        // 17. Create a method called GetNext7Days that accepts a DateTime object and returns an array of DateTime objects containing the next 7 days (including the given day).
        public static DateTime [] GetNext7Days(DateTime dateAndTime) {
         
            DateTime [] next7Days = new DateTime[7]; // creates a DateTime array of length 7
            
            for (int i = 0; i < 7; i++) { // each iteration adds the next day to the next7Days array
                next7Days[i] = dateAndTime.AddDays(i);
            }
            return next7Days;
        }
        // 18. Create a method called IsInLeapYear that accepts a DateTime object and returns true if the date falls within a leap year and false if not. (No built in functions allowed)
        public static bool IsInLeapYear(int year) {

            if (year % 400 == 0) { // first check if year is divisible by 400. If so, it is a leap year.
                return true;
            } else if (year % 100 == 0) { // then check if year is divisible by 100. If so, then it is not a leap year.
                return false;
            } else if (year % 4 == 0) { // If year is not divisible by 400 or 100, then check if year is divisible by 4. If yes, then it is a leap year.
                return true;
            } else { // if year is not divisible by 400, 100, or 4, then it is not a leap year.
                return false;
            }

        }

        // 19. Create a method called MortgageCalculator that accepts 2 decimals representing loan balance and interest rate, an integer representing loan term in years, and an integer representing the payment period.
        /* Payment periods: 1 - Monthly, 2 - Bi-Monthly (Every 2 months) */

        public static double MortgageCalculator(double loanBalance, double interestRate, int loanTermInYears, int paymentPeriod) {
            
            double mortgagePayment = 0;
            double something = 0;
            double yearlyInterestRateInPercentageForm = interestRate / 100;
            double monthlyInterestRateInPercentageForm = yearlyInterestRateInPercentageForm / 12;
            int numberOfMonthlyPaymentsOverLoanTerm = loanTermInYears * paymentPeriod;

            something = Math.Pow((1 + monthlyInterestRateInPercentageForm), numberOfMonthlyPaymentsOverLoanTerm);

            // payment = loanBalance * (Math.Pow((1 + monthlyInterestRate), loanTermInMonths) * yearlyInterestRate)/(12 * (Math.Pow((1 + monthlyInterestRate), loanTermInMonths) - 1));
            mortgagePayment = (loanBalance * yearlyInterestRateInPercentageForm * something) / (12 * (something - 1));
            return Math.Round(mortgagePayment, 2); // round the payment to decimal points
        }
        // 20. Create a method called DuckGoose that accepts an integer. Iterate from 1 to this integer, building a string along the way.
        public static string DuckGoose(int number) {

            string stringToOutput = ""; // initialize final string output

            // iterates from 1 to the number in question, building the final string along the way
            for (int i = 1; i < number + 1; i++) {

                if (i % 3 == 0 && i % 5 == 0)
                {
                    stringToOutput += "DuckGoose";
                } else if (i % 3 == 0) {
                    stringToOutput += "Duck";
                    
                } else if (i % 5 == 0) {
                    stringToOutput += "Goose";
                } else {
                    stringToOutput += i;
                }

                if (i < number) // adds a newline to each string that is added, except for the very last string
                {
                    stringToOutput += Environment.NewLine;
                }
            }

            return stringToOutput;
        }
        // If the current number in the iteration:
        //   Is divisible by 3, append "Duck" + Environment.NewLine; to the string.
        //   Is divisible by 5, append "Goose" + Environment.NewLine; to the string.
        //   Is divisible by both 3 and 5, append "DuckGoose" + Environment.NewLine; to the string.
        //   Is none of the above, append the number as a string + Environment.NewLine; to the string.
        /* Example - if the input to this method is 20, the following string should be returned
         * 1
         * 2
         * Duck
         * 4
         * Goose
         * Duck
         * 7
         * 8
         * Duck
         * Goose
         * 11
         * Duck
         * 13
         * 14
         * DuckGoose
         * 16
         * 17
         * Duck
         * 19
         * Goose
         */

        // If you've finished all these challenges, sign up for CodeWars.com and try to complete a few C# challenges there!
    }
}