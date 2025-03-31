using System;
using System.Media;
using System.IO;

namespace voice_greeting
{
    public class welcome_message
    {
        public void Play()
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string wavFilePath = Path.Combine(baseDirectory, "greeting.wav");

            try
            {
                using (SoundPlayer player = new SoundPlayer(wavFilePath))
                {
                    player.Load();
                    player.PlaySync();
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Warning: Greeting audio file ('greeting.wav') not found. Continuing without audio.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error playing voice greeting: {ex.Message}");
            }
        }
    }
}