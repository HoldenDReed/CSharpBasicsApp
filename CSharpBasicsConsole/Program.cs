using CSharpBasicsConsole.Classes;

namespace CSharpBasicsConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             * Name: Leroy J
             * Favorite day of the week: Wednesday
             * Least favorite school subject: English
             * 
             * 
             

            object userInput = new
            {
                Name = "Test",
                FavoriteDay = "Testday",
                LeastFavoriteSubject = "TestSubject"
            };
            */
            UserInput userInput = new UserInput();
         
            Console.Write("Enter your name: ");
            userInput.Name = Console.ReadLine();
            
            while (String.IsNullOrWhiteSpace(userInput.Name))
            {
                Console.WriteLine("Please enter a name: ");
                userInput.Name = Console.ReadLine();
            }

            Console.Write("Enter your day of the week: ");
            userInput.FavoriteDay = Console.ReadLine();
           
            while (String.IsNullOrWhiteSpace(userInput.FavoriteDay))
            {
                Console.WriteLine("Please enter a valid day of the week: ");
                userInput.FavoriteDay = Console.ReadLine();
            }

            Console.Write("Enter your least favorite school subject: ");
            userInput.LeastFavoriteSubject = Console.ReadLine();

            while (String.IsNullOrWhiteSpace(userInput.LeastFavoriteSubject))
            {
                Console.WriteLine("Please enter a valid school subject: ");
                userInput.LeastFavoriteSubject = Console.ReadLine();
            }
            Console.Clear();

            // @ - string verbatim yo
           

            Console.Write(userInput);

            Console.ReadLine();


            //string input = "";

            //while (input == "" || input.StartsWith("QQ"))
            //{
            //    //Console.WriteLine("You need a name 4head.");
            //    Console.WriteLine("Enter your name: ");
            //    input = Console.ReadLine();
            //}

            //Console.WriteLine($"Hello, {input}!");
        }

    }
}