using System;

namespace CSharp7
{
    class Program
    {

        static void Main(string[] args)
        {
            #region out variables
            //            The code is easier to read.
            //You declare the out variable where you use it, not on another line above.
            //No need to assign an initial value.
            //By declaring the out variable where it's used in a method call, you can't accidentally use it before it is assigned.
            //example 
            Console.WriteLine("enter number");
            var input = Console.ReadLine();
            if (int.TryParse(input, out var result))
                Console.WriteLine(result);
            else
                Console.WriteLine("Could not parse input");

            #endregion

            #region tuples
            // Tuples are lightweight data structures that contain multiple fields to represent the data members.
            //The fields aren't validated, and you can't define your own methods

            (string Alpha, string Beta) namedLetters = ("a", "b");
            var output = tuples("name rasha ");


            Console.WriteLine($"{namedLetters.Alpha}, {namedLetters.Beta}");
            Console.WriteLine($"{output.firstName} , {output.LastName}");
            #endregion


            #region Discards
            //Discards are supported in the following scenarios:

         //   When deconstructing tuples or user - defined types.
//When calling methods with out parameters.
//In a pattern matching operation with the is and switch statements.
//As a standalone identifier when you want to explicitly identify the value of an assignment as a discard.
            var (_, _, _, pop1, _, pop2) = QueryCityDataForYears("New York City", 1960, 2010);

            Console.WriteLine($"Population change, 1960 to 2010: {pop2 - pop1:N0}");

            #endregion



            Console.ReadLine();
        }
        public static (string firstName , string LastName) tuples (string name)
        {
            return ("rasha ", "sayed");
        }
        private static (string, double, int, int, int, int) QueryCityDataForYears(string name, int year1, int year2)
        {
            int population1 = 0, population2 = 0;
            if (name == "New York City")
            {
                double area = 468.48;
                if (year1 == 1960)
                {
                    population1 = 7781984;
                }
                if (year2 == 2010)
                {
                    population2 = 8175133;
                }
                return (name, area, year1, population1, year2, population2);
            }
            return ("", 0, 0, 0, 0, 0);
        }
    }
}
