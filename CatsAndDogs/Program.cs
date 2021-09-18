using System;

namespace CatsAndDogs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Are you more like a cat or adog?");
            string userChoise = Console.ReadLine().ToLower();

            if (userChoise == "cat") 
            {
                Console.WriteLine("You are a home-lover.");
            }
            else if(userChoise == "dog") 
            {
                Console.WriteLine("You are a partygoer.");
            }
            else
            {
                Console.WriteLine($"You are a {userChoise} friend.");
            }
        }
    }
}
