using System;
using System.Collections.Generic;
using System.Media;
using System.IO;

namespace voice_greeting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 1. Handle Welcome Elements
            HandleWelcome();

            // 2. Get User Name
            string userName = GetUserName();

            // 3. Run Main Chatbot Interaction Loop
            RunChatbot(userName);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        // Method to handle welcome message and logo display
        static void HandleWelcome()
        {
            // Play welcome message (with improved error handling)
            welcome_message welcome = new welcome_message();
            welcome.Play();

            // Display logo
            Logo myLogo = new Logo(GetLogoArt());
            myLogo.Display();

            Console.WriteLine("\nWelcome to the Cybersecurity Awareness Chatbot!\n");
        }

        // Method to get user's name, handling null/empty input
        static string GetUserName()
        {
            Console.Write("Chatbot: Hello! What's your name? ");
            string userName = Console.ReadLine()?.Trim() ?? "User";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nChatbot: Welcome, {userName}! I'm here to help you learn about cybersecurity. I can answer your questions about passwords, phishing, safe browsing, and more. Just type 'exit' to quit.\n");
            Console.ResetColor();
            return userName;
        }

        // Method to handle main chatbot interaction loop
        static void RunChatbot(string userName)
        {
            ResponseHandler responseHandler = new ResponseHandler();
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"{userName}: ");
                Console.ResetColor();

                string userInput = Console.ReadLine();

                if (userInput.ToLowerInvariant() == "exit")
                {
                    Console.WriteLine($"Chatbot: Goodbye, {userName}! Stay safe online.");
                    break;
                }

                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Chatbot: Please ask a question.");
                    Console.ResetColor();
                    continue;
                }

                string response = responseHandler.GetResponse(userInput);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\nChatbot: {response}\n");
                Console.ResetColor();
            }
        }

        // Method to get ASCII art for logo
        static string GetLogoArt()
        {
            return @"
  ____ _           _   ____        _   
 / ___| |__   __ _| |_| __ )  ___ | |_ 
| |   | '_ \ / _` | __|  _ \ / _ \| __|
| |___| | | | (_| | |_| |_) | (_) | |_ 
 \____|_| |_|\__,_|\__|____/ \___/ \__|
";
        }
    }
}