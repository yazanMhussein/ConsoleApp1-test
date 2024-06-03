namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckDrinkingAge();
            ArrayOfNumersAndLetters();
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
    }
}
