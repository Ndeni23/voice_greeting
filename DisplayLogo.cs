using System;
using System.Drawing;
using System.IO;

namespace voice_greeting
{
    public class DisplayLogo
    {
        public void RunChatbot()
        {
            string paths = AppDomain.CurrentDomain.BaseDirectory;
            string newPath = paths.Replace("bin\\Debug\\", "");
            string fullPath = Path.Combine(newPath, "robots.jpg");

            try
            {
                // Ensure the image exists before proceeding
                if (File.Exists(fullPath))
                {
                    Bitmap logo = new Bitmap(fullPath);
                    logo = new Bitmap(logo, new Size(120, 50)); // Resizing the logo to fit the console

                    // Converts image pixels to ASCII characters and prints to the console
                    for (int height = 0; height < logo.Height; height++)
                    {
                        for (int width = 0; width < logo.Width; width++)
                        {
                            Color pixelColor = logo.GetPixel(width, height);
                            int gray = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                            char asciiChar = gray > 250 ? '.' : gray > 150 ? '*' : gray > 100 ? 'o' : gray > 50 ? '#' : '@';
                            Console.Write(asciiChar);
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Error: Image file not found at " + fullPath);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error displaying logo: " + ex.Message);
            }
        }
    }
}
