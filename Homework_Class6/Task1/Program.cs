using System;
using Task1.Classes;

namespace Task1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            User[] users = new User[] {
             new User(27, "IvanCupic", "chupo", new string[] { "You wiil play only in second half", "I want you to run the fastbreak" }),
             new User(31, "TimurDibirov", "timur", new string[] { "You will take the penalties", "We will use you a lot in 5-1 defence" }),
             new User(5, "StoleStoilov", "stole5", new string[] { "Be aggressive at the beginning", "Don't talk to referees" }),
             new User(20, "StasSkube", "stas", new string[] { "Play a lot with the line player", "Change the pace several times" })
        };

            AskUser(users);
            Console.ReadLine();
        }
           

        static void AskUser(User[] players)
        {
            Console.Clear();
            Console.WriteLine("Choose an option: 1)Login 2)Register ");
            string anwser = Console.ReadLine();
            switch (anwser)
            {
                case "1":
                    Login(players);
                    break;
                case "2":
                    Register(players);
                    break;
                default:
                    AskUser(players);
                    break;
            }
        }

            static void Login(User[] players)
        {
            bool isUser = false;
            Console.Clear();
            Console.Write("Enter your username: ");
            string userName = Console.ReadLine();
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();
            foreach (User player in players)
            {
                if (player.Username == userName && player.Password == password)
                {
                    Console.WriteLine($" Welcome {player.Username}. Here are your messages:");
                    Console.WriteLine($" {player.Messages[0]}!");
                    Console.WriteLine($" {player.Messages[1]}!");
                    isUser = true;
                    break;
                }
            }
            if (isUser == false)
            {
                Console.WriteLine("There is no such user! Please try again.");
                Console.ReadLine();
                Login(players);
            }
        }

        static void Register(User[] players)
        {
            Console.Clear();
            Console.Write("Set your username: ");
            string userName = Console.ReadLine();
            Console.Write("Set your password: ");
            string password = Console.ReadLine();
            Console.Write("Set your Id: ");
            bool isNum = int.TryParse(Console.ReadLine(), out int id);
                if (isNum)
                {
                foreach (User player in players)
                {
                    if (player.Id == id)
                    {
                        Console.WriteLine("There is already a user with that Id. Try again using another Id.");
                        Console.ReadLine();
                        Register(players);
                    }
                }
                Array.Resize(ref players, players.Length + 1);
                players[players.Length - 1] = new User(id, userName, password, new string[] { });
                Console.Clear();
                Console.WriteLine("Registration complete! Users:");
                foreach (User player in players)
                {
                    Console.WriteLine($" {player.Id} { player.Username}");
                }
            } else
            {
                Console.WriteLine("Your Id has to be a number! Try again.");
                Console.ReadLine();
                Register(players);
            }
            
    
            
        }
    }
}