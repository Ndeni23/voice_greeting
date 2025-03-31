using System;
using System.Collections.Generic;

namespace voice_greeting
{
    public class ResponseHandler
    {
        private readonly Dictionary<string, string> _responses = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            {"password", "Strong passwords are crucial! Use a mix of uppercase, lowercase, numbers, and symbols.  Avoid easily guessable passwords like birthdays or pet names.  Consider a password manager."},
            {"phishing", "Beware of suspicious emails or messages asking for personal information. Legitimate organizations rarely request login details via email. Verify links and sender addresses before clicking."},
            {"virus", "Keep your antivirus software up-to-date and run regular scans. Be cautious about downloading files from untrusted sources. Avoid clicking on pop-up ads that promise unrealistic benefits."},
            {"safe browsing", "Practice safe browsing habits. Only download files from trusted websites and be cautious of links from unknown sources. Keep your browser and extensions updated."},
            {"how are you", "I'm doing well, thank you for asking!"},
            {"what's your purpose", "My purpose is to help you learn about basic cybersecurity practices."},
            {"what can i ask you about", "You can ask me about passwords, phishing, viruses, safe browsing, or any other cybersecurity topic."},
            {"online safety", "Online safety involves protecting yourself and your information while using the internet.  Key aspects include strong passwords, safe browsing, and awareness of phishing and scams."},
            {"default", "I didn't quite understand that. Could you rephrase your question?"}
        };

        public string GetResponse(string userInput)
        {
            string normalizedInput = userInput.Trim().ToLowerInvariant();
            foreach (KeyValuePair<string, string> kvp in _responses)
            {
                if (normalizedInput.Contains(kvp.Key))
                {
                    return kvp.Value;
                }
            }
            return _responses["default"];
        }
    }
}