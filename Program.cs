using System;

namespace MyFirstConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNumber;

            //defaults to false
            bool isMyNameDayna;
            //defaults to null
            bool? graduatedCollege;
            Nullable<bool> graduatedCollege2;

            string name = null;

            //null conditional access operator - if thing on left is null, don't do the thing on the right
            name?.ToString();
            //null coalescing operator - if thing on left is null, use the thing on the right instead
            name = name ?? "Nathan";

            if (name != null)
            {

            }

            //read input from a user
            Console.WriteLine("What is your first name");
            var input = Console.ReadLine();

            //strings
            name = "Dana"; /*declare variable*/
            char firstLetter = 'N'; /*Single quotes only used for single characters*/

            //let myInterpolatedString = `this stuff ${firstLetter}`;
            var myInterpolatedString = $"My name is {name} and the " + 
                                        $"first letter of my name is {firstLetter}";

            //literally storing the entire string including spaces, returns, tabs
            var stringLiteral = @"This is a paragraph.
                                  It is across multiple lines.
                                  Returns will be honored in the output.";

            Console.WriteLine(myInterpolatedString);
            Console.WriteLine(stringLiteral);

            //Number types
            int number = Int32.MaxValue; /*declare integer called number, set it to the max value for an integer*/

            long bigNumber = Int64.MaxValue; /*maxvalue for long*/

            short littleNumber = Int16.MaxValue; /*maxvalue for short*/

            Console.WriteLine(bigNumber);

            //decimals can be represented by [f]loat(32bit) [d]ouble(64bit) or deci[m]al(128bit)
            var adding = 1 + 1.1;
            //in order to ensure that you get a decimal back from this, you have to add a decimal to one of the numbers you are dividing with
            var division = 3 / 2d;

            var implicitStringThing = "this is an implicitly typed variable.";

            int uninitializedInt;
            //can't do this: var otherThing; 

            var today = DateTime.Today;

            //instantiation
            var bestYear = new DateTime(2020, 1, 1);

            //anonymous type, new object
            object person = new {Name = "Dana"};

            //in c#, everything either is or can be an object
            object weirdStuff = 1234;
            weirdStuff = "More craziness";

            Console.WriteLine(weirdStuff);

            var names = new string[5];
            //array range
            var namesRange = names[1..4];
            //square brackets is an indexer
            var secondName = names[1];
            names[1] = "Jimmy";

            var colors = new string[] { "white", "blue", "black", "yellow", "magenta" };

            if (input == "Nathan")
            {
                Console.WriteLine("Duh");
            }
            else if (input == "blerg")
            {
                Console.WriteLine(input);
            }
            else
            {
                Console.WriteLine("Not Nathan");
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"currently for looping on number {i}");
            }

            while (true)
            {
                var counter = 1;
                Console.WriteLine($"While loop interation {counter}.");

                if (counter <= 5)
                    continue;

                break;
            }

            foreach (var color in colors)
            {
                Console.WriteLine($"Foreach looping on color {color}");
            }
        }
    }
}
