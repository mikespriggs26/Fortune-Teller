using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortune_teller___final_version_update
{
    class Program
    {
        static void Main(string[] args)
        {
            string userFirstName;
            string userLastName;
            string userAge;
            string userBirthMonth;
            string favColor;
            string userSiblings;


            //Gathering information from the user
            Console.WriteLine("I will tell your fortune by asking you a series of questions. \nYou may leave this program at anytime by typing \"quit\". \nWhat is your first name?");
            userFirstName = Console.ReadLine().ToLower();
            if (userFirstName == "quit")
            {
                Console.WriteLine("Nobody likes a quitter...");
                Environment.Exit(0);
            }

            Console.WriteLine("Ok. Thanks. Now give me your last name?");
            userLastName = Console.ReadLine().ToLower();
            if (userLastName == "quit")
            {
                Console.WriteLine("Nobody likes a quitter...");
                Environment.Exit(0);
            }


            Console.WriteLine("Got that. How old are you?");
            userAge = Console.ReadLine().ToLower();
            if (userAge == "quit")
            {
                Console.WriteLine("Nobody likes a quitter...");
                Environment.Exit(0);
            }
            int userAgeInt = int.Parse(userAge);
            int remainder = userAgeInt % 2;  //will be used later to determine odd or even for retirement age


            Console.WriteLine("Please enter the number of the month you were born. For example, enter 1 for January.");
            userBirthMonth = Console.ReadLine().ToLower();
            if (userBirthMonth == "quit")
            {
                Console.WriteLine("Nobody likes a quitter...");
                Environment.Exit(0);
            }
            int userBirthMonthInt = int.Parse(userBirthMonth);//makes the month a usable int type

            //determining the user's favorite color
            string[] ROYGBIV = { "red", "orange", "yellow", "green", "blue", "indigo", "violet" };
            Console.WriteLine("What is your favorite ROYGBIV color? Type \"Help\" for a list of ROYGBIV colors.");
            favColor = Console.ReadLine().ToLower();

            //in case the user needs help
            if (favColor == "help")
            {
                foreach (string color in ROYGBIV)
                {
                    Console.Write(color + " ");
                }

                Console.WriteLine("\nWhich color is your favorite?");
                favColor = Console.ReadLine().ToLower();
            }
            if (favColor == "quit")
            {
                Console.WriteLine("Nobody likes a quitter...");
                Environment.Exit(0);
            } 


            Console.WriteLine("How many siblings do you have?");
            userSiblings = Console.ReadLine().ToLower();
            if (userSiblings == "quit")
            {
                Console.WriteLine("Nobody likes a quitter...");
                Environment.Exit(0);
            }
            int userSiblingsInt = int.Parse(userSiblings);


            //Beging fortune telling with conditional statements
            Console.Write(string.Concat(userFirstName, " ", userLastName, " will retire in "));

            //determine the retirement year from userAge
            if (remainder == 1)
            {
                Console.Write("10 years with");
            }
            else
                Console.Write("20 years with");



            //determining bank account based on number of birth month

            if (userBirthMonthInt <= 0)
            {
                Console.Write(" $0.00 in the bank, a vacation home in ");
            }
            else if (userBirthMonthInt >= 1 && userBirthMonthInt <= 4)
            {
                Console.Write(" $25,000 in the bank, a vacation home in ");
            }
            else if (userBirthMonthInt >= 5 && userBirthMonthInt <= 8)
            {
                Console.Write(" $250,000 in the bank, a vacation home in ");
            }
            else if (userBirthMonthInt >= 9 && userBirthMonthInt <= 12)
            {
                Console.Write(" $1 million in the bank, a vacation home in ");
            }
            else
            {
                Console.Write(" $0.00 in the bank, a vacation home in ");
            }


            //using siblings to determine vacation home location  

            if (userSiblingsInt == 0)
            {
                Console.Write("Aspen and ");
            }
            else if (userSiblingsInt == 1)
            {
                Console.Write("Montana and ");
            }
            else if (userSiblingsInt == 2)
            {
                Console.Write("Naples, FL and ");
            }
            else if (userSiblingsInt == 3)
            {
                Console.Write("Paris and ");
            }
            else if (userSiblingsInt > 3)
            {
                Console.Write("Rehobeth Beach and ");
            }
            else
            {
                Console.Write("Detroit and ");
            }

            //Determining the mode of transportation based on favorite color
            if (favColor == "red")
            {
                Console.Write("a Bentley.");
            }
            else if (favColor == "orange")
            {
                Console.Write("a yacht.");
            }
            else if (favColor == "yellow")
            {
                Console.Write("a helicopter.");
            }
            else if (favColor == "green")
            {
                Console.Write("a Lear jet.");
            }
            else if (favColor == "blue")
            {
                Console.Write("a dinghy.");
            }
            else if (favColor == "indigo")
            {
                Console.Write("a truck.");
            }
            else
            {
                Console.Write("a limousine.");
            }

            Console.WriteLine();


        }
    }
}
