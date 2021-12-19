using System;
using ChallengeRunner;

namespace InputManagement
{
    public static class InputHelpers
    {
        //Input parsing
        public static UserAction RequestInput()
        {
            bool inputIsValid = false;
            UserAction validatedInput = UserAction.Exit;
            while (!inputIsValid)
            {
                WriteInstructionsToScreen();

                var unvalidatedInput = Console.ReadLine();

                inputIsValid = ValidateInput(unvalidatedInput, out validatedInput);

                if (!inputIsValid)
                {
                    Console.WriteLine($"Sorry, I didn't understand {unvalidatedInput}...");
                }                
            }

            return validatedInput;
        }

        public static bool ValidateInput(string unvalidatedInput, out UserAction validatedInput)
            => Enum.TryParse<UserAction>(unvalidatedInput, true, out validatedInput);

        //exit
        public static bool IsExitCode(string input)
            => input.ToLower() == "X";

        public static void Exit()
        {
            Console.WriteLine("Bye! The application will now exit.");
            System.Threading.Thread.Sleep(2000);
            System.Environment.Exit(0);
        }

        //Generic helpers
        public static void WriteInstructionsToScreen()
        {
            Console.WriteLine($"Please select a task to run by typing the task name. Or, to exit, type 'Exit'");
            Console.WriteLine($"The list of valid tasks is as follows:");
            foreach (var action in Enum.GetValues<UserAction>())
            {
                Console.WriteLine($"-> {action}");
            }
        }

    }
}