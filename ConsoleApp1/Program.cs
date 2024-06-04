using System.Drawing;
using System.Numerics;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Types();
            CheckDrinkingAge();
            ArrayOfNumersAndLetters();
            DictionaryAreLikeObject();
            loops();
        }

        /*
         I wrote all of the data types that i know then use ai to learn some of the other that i didn't know about.
         */
        static void Types() {
            // Integral types
            byte    ByteNumber = 0;  // 8-bit unsigned integer (0 to 255)
            short   ShortNumber = 0;  // 16-bit signed integer (-32,768 to 32,767)
            int     IntNumber = 0;  // 32-bit signed integer (-2,147,483,648 to 2,147,483,647)
            long    LongNumber = 0;

            // Floating-point types
            float FloatNumber = 0; // 32-bit single-precision floating-point type
            double  DoubleNumber = 0; // 64 - bit double-precision floating - point type
            decimal DecimalNumber = 0.0m; // 128-bit high precision decimal type

            // Arbitrary precision integer        
            BigInteger bigInteger = 0; // Represents an arbitrarily large signed integer

            // Other types
            char charLetter = 'a'; // Represents a Unicode character
            string  stringWords = "new Words"; // Represents a sequence of character
            bool true_false = false; // Represents a Boolean value (true or false)

            
            // These type i didn't know about that i learn about from chat gpt 
            /*
             DateTime: Used for representing dates and times.
             */
            DateTime currentDate = DateTime.Now; // Represents the current date and time
            /*
             TimeSpan: Represents a time interval.
             */
            TimeSpan duration = new TimeSpan(1, 30, 0); // Represents 1 hour and 30 minutes
            /*
               Nullable Types: Allow variables to have the additional value of null in addition to their usual value ranges. 
               You can make any value type nullable by appending a ? after its type.
            */
            int? nullableInt = null; // Nullable integer
        }
 
        /* 
           this is a function in c# im return nothing by using the key void. 
           I still don't know what is static means.
           I call this function ArrayOfNumersAndLetters.
           It this not take any input. 
         */
        static void ArrayOfNumersAndLetters()
        {
            int[] numberArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            string[] lettersArr = { "a", "b", "c", "d", "e", "f" };
            /*
              In c# we can not do is add create a array then add to it by push because the array is not dynamic. 
              We can use a list which is like a array but it is dynamic.  
             */
            List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<string> Letters = new List<string> { "a", "b", "c", "d", "e", "f" };
            Letters.Add("g");
            Numbers.Add(11);
        }

        /*
          in c# object are not like javascript they are different    

          static void ListOfObject() { 
            var obj = {
                string life = "new";
                int luckNumber = 12;
             }
        }*/
        /*
         We use Dictionary as like javascript object they have a key Value Pairs but lot of differents bettwen them
         frist we have to define the types we are using like int , flot, double ,char , string then give it a name 
         then create a new intsta.. of it  then we can difine the value and key of it.
         Dictionary requires 2 type of arguments first for the key and the secound for value. 
         */
        static void DictionaryAreLikeObject()
    {
        Dictionary<string,int> keyValuePairs = new Dictionary<string,int>();

        // Adding key-value pairs
        keyValuePairs["apple"] = 7;
        keyValuePairs["banana"] = 5;
        keyValuePairs["orange"] = 8;
            // foreach is loop thougth each of the keys and values then print it out to the console
            foreach (var pair in keyValuePairs)
            {
                Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
            }

        }

        /*
        I create this function to test the age of the user to see if he can drink by using the if statement and user input by
        Readline and i conver the int to a string because c# is a strongly typed language 
        */
        static void CheckDrinkingAge()
        {
            Console.WriteLine("Please enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("here you go ");
            }
            else if (age < 18 && age >= 0)
            {
                Console.WriteLine("please go away");
            }
            else
            {
                Console.WriteLine("how can i help you ");
            }
        }

        /*
         write diferent types loops 
         */
        static void loops() {
            for (int i = 0; i < 10; i++) {
                Console.WriteLine(i);
            }
            /* 
               In c#  we don't have for in or for of like in javascript
               we use a froeach to loop thought a object like  in javascript.
               this was take from chat gpt to learn about it. 
             */
            int[] numbers = { 1, 2, 3, 4, 5 };
            var evenNumbers = numbers.Where(n => n % 2 == 0);
            foreach (var number in evenNumbers)
            {
                Console.WriteLine(number);
            }
            int age = 18;
            while (age >= 18) {
                Console.WriteLine("Print here is a while loop");
            };
            do
            {
                Console.WriteLine("Print here is a do while loop");
            } while (age <= 10);

        }
    }

}
