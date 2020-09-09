using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInputDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName;
            string userFood;
            string userGame;
            string userBestFriend;
            Console.WriteLine("What is your name?");
            Console.ForegroundColor = ConsoleColor.Cyan;
            userName = Console.ReadLine(); //Name input
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Welcome " + userName + "!");

            Console.WriteLine("What is your favorite food?");
            Console.ForegroundColor = ConsoleColor.Cyan;
            userFood = Console.ReadLine(); //Food input
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("What is your favorite video game?");
            Console.ForegroundColor = ConsoleColor.Cyan;
            userGame = Console.ReadLine(); //Game input
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("What is the name of your best friend?");
            Console.ForegroundColor = ConsoleColor.Cyan;
            userBestFriend = Console.ReadLine(); //Friend name input
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Your name is " + userName.Length + " letters long.");

            Console.WriteLine(" "); //provides space between lines

            Console.WriteLine("Your name is " + (userName.Length - userBestFriend.Length) + " letters longer than " + userBestFriend + "'s name.");

            Console.WriteLine(" "); //provides space between lines

            Console.WriteLine("Does " + userBestFriend.ToUpper() + " like to eat " + userFood.ToUpper() + " and play " + userGame.ToUpper() + " too?");

            Console.WriteLine(" "); //provides space between lines

            Console.WriteLine("Generating Secret Code Name . . .");

            Console.WriteLine(" "); //provides space between lines

            Console.WriteLine("Secret code name is: " + userName.ToUpper()[0] + userName.ToLower()[1] + userFood.ToLower().Substring(0 , 2) + userGame.ToLower().Substring(0, 2) + userBestFriend.ToLower().Substring(0, 2));

        }
    }
}
