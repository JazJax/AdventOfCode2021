using System;
using ChallengeRunner;
using static InputManagement.InputHelpers;

namespace AdventOfCode2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to Advent Of Code 2021!");

            //Program loop
            while (true)
            {
                var userInput = RequestInput(); //replace with proper menu method

                if (userInput == UserAction.Exit)
                {
                    Exit();
                }

                Console.WriteLine($"You chose task {userInput}!");

                //Instantiate the class we've selected
                string qualifiedChallengeName = $"{userInput.ToString()}.{userInput.ToString()}";
                Type challengeType = Type.GetType(qualifiedChallengeName) ?? null;
                try
                {
                    var challenge = (Challenge)Activator.CreateInstance(challengeType);                    
                    Console.WriteLine($"Task description: {challenge.ChallengeDescription}");
                    Console.WriteLine($"Answer: {challenge.Answer}");
                }
                catch
                {
                    Console.WriteLine("Error instantiating type or running challenge code...");
                }
                Console.WriteLine("Press any key to continue");
                Console.ReadLine();
            }
        }
    }    
}
