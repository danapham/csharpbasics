using System;

namespace MyFirstConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name");
            var input = Console.ReadLine();

            //strings
            string name = "Dana"; /*declare variable*/
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
        }
    }
}
