using System;
using System.Collections.Generic;
using System.Media;
using System.IO;
using System.Threading;

namespace voice_greeting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            welcome_message welcome = new welcome_message();
            welcome.Play();

          
            Logo myLogo = new Logo(GetLogoArt());
            myLogo.Display();

            
            Console.Write("Chatbot: Hello! What's your name? ");
            string userName = Console.ReadLine()?.Trim();

            if (string.IsNullOrEmpty(userName))
            {
                userName = "User";
            }

            Console.WriteLine($"\nChatbot: Welcome, {userName}! I'm here to help you learn about cybersecurity.  I can answer your questions about passwords, phishing, safe browsing, and more. Type 'exit' to quit.\n");


            
            ResponseHandler responseHandler = new ResponseHandler();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green; 
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
                    Console.WriteLine("Chatbot: Please enter a question or command.");
                    continue;
                }

                try
                {
                    Console.WriteLine("\nChatbot: Processing your request..."); 
                    Thread.Sleep(500); //Simulate typing delay

                    string response = responseHandler.GetResponse(userInput);

                    
                    foreach (char c in response)
                    {
                        Console.Write(c);
                        Thread.Sleep(20); // Adjust delay as needed
                    }
                    Console.WriteLine();


                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Chatbot: Oops! An error occurred: {ex.Message}");
                }
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }


        // ASCII Art Logo
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
