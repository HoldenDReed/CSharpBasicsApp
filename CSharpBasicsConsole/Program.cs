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
             */

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            
            while (String.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Please enter a name: ");
                name = Console.ReadLine();
            }

            Console.Write("Enter your day of the week: ");
            string day = Console.ReadLine();
           
            while (String.IsNullOrWhiteSpace(day))
            {
                Console.WriteLine("Please enter a valid day of the week: ");
                day = Console.ReadLine();
            }

            Console.Write("Enter your least favorite school subject: ");
            string subject = Console.ReadLine();

            while (String.IsNullOrWhiteSpace(subject))
            {
                Console.WriteLine("Please enter a valid school subject: ");
                subject = Console.ReadLine();
            }
            Console.Clear();

            // @ - string verbatim
            string displayText = @$"
Name: {name}
Favorite day of the week: {day}
Least favorite school subject: {subject}";

            Console.Write(displayText);

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