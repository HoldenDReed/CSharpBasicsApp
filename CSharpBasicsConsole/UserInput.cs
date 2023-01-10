using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicsConsole.Classes
{
    //class -- a bluepring to represent something in your application
    //all code in a class will be related
    public class UserInput
    {
        /* 
             * Name: Leroy J
             * Favorite day of the week: Wednesday
             * Least favorite school subject: English
             * 
             * object userInput = new
            {
                Name = "Test",
                FavoriteDay = "Testday",
                LeastFavoriteSubject = "TestSubject"
            };
             * 
             * 
             */
        public string Name { get; set; }
        public string FavoriteDay { get; set; }
        public string LeastFavoriteSubject { get; set; }

        public override string ToString()
        {
            return @$"
Name: {Name}
Favorite day of the week: {FavoriteDay}
Least favorite school subject: {LeastFavoriteSubject}";
        }
    }
}
