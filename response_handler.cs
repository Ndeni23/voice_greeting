using System;
using System.Collections.Generic;

public class ResponseHandler
{
    private readonly Dictionary<string, List<string>> _responses = new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase)
    {
        {"password", new List<string> {
            "Strong passwords are essential for online security.  Use a mix of uppercase and lowercase letters, numbers, and symbols. Aim for at least 12 characters.",
            "Avoid using easily guessable passwords like your name, birthday, or pet's name.",
            "Don't reuse passwords across different accounts.  If one account is compromised, you don't want all your other accounts at risk.",
            "Consider using a password manager to generate and securely store strong, unique passwords for each of your accounts."
        }},
        {"phishing", new List<string> {
            "Phishing is a type of online fraud where criminals attempt to trick you into giving up sensitive information like usernames, passwords, or credit card details.",
            "Be wary of suspicious emails or text messages that ask for personal information or contain unexpected links.",
            "Legitimate organizations will almost never ask for your password or financial information via email.",
            "Always verify the sender's email address and check for any spelling errors or unusual formatting in emails or messages.",
            "Never click on links in suspicious emails or messages.  Instead, go directly to the website yourself using a known, trusted URL."
        }},
        {"virus", new List<string> {
            "Computer viruses are malicious software programs that can infect your computer and cause damage or steal your data.",
            "Keep your antivirus software up-to-date and run regular scans.",
            "Be cautious about downloading files from untrusted sources, especially file-sharing websites or email attachments.",
            "Avoid clicking on pop-up ads that promise unrealistic benefits.",
            "Regularly back up your important files to an external drive or cloud storage service to minimize data loss in case of infection."
        }},
        {"safe browsing", new List<string> {
            "Safe browsing practices are crucial for protecting yourself from online threats.",
            "Be cautious about clicking on links from unknown sources.  Hover your mouse over a link to preview the URL before clicking.",
            "Only download files from trusted websites. Check website security certificates (the padlock icon in the address bar).",
            "Keep your browser and its extensions up-to-date. Software updates often include security patches.",
            "Use strong passwords and don't reuse them across multiple websites.",
            "Be aware of phishing attempts, where criminals try to trick you into providing personal information."
        }},
        {"how are you", new List<string> {
            "I'm doing well, thank you for asking! How can I assist you today?",
           
        }},
        {"what is your purpose", new List<string> {
            "My purpose is to educate users about cybersecurity best practices and help them stay safe online.",
            "I'm designed to provide information on topics such as password security, phishing, and safe browsing.",
            "I aim to increase cybersecurity awareness and help users avoid common online threats."
        }},
        {"what can i ask you about", new List<string> {
            "You can ask me about various aspects of cybersecurity.  I have information on password security, phishing scams, safe browsing, and more.",
            "Feel free to ask me any questions related to online safety and security.",
            "I can provide guidance on protecting your personal information and devices from online threats."
        }},
        {"online safety", new List<string> {
            "Online safety involves protecting yourself and your information while using the internet.",
            "Key aspects of online safety include using strong passwords, being wary of phishing attempts, and practicing safe browsing habits.",
            "It's also important to be aware of scams, malware, and other online threats."
        }},
        {"cybersecurity", new List<string> {
            "Cybersecurity encompasses the technologies, processes, and practices designed to protect networks, computers, programs, and data from attack, damage, or unauthorized access.",
            "It's a broad field covering various aspects of online safety and security.",
            "Key areas of cybersecurity include network security, data security, application security, and incident response."
        }},
        {"default", new List<string> { "I'm still under development. Could you rephrase your question?", "I didn't quite understand that.  Could you ask in a different way?", "I'm not sure I understand your question.  Please try rephrasing it." }}
    };

    private readonly Random _random = new Random();

    public string GetResponse(string userInput)
    {
        if (string.IsNullOrWhiteSpace(userInput))
        {
            return "Please enter a question or command.";
        }

        string normalizedInput = userInput.Trim().ToLowerInvariant();

        foreach (KeyValuePair<string, List<string>> kvp in _responses)
        {
            if (normalizedInput.Contains(kvp.Key))
            {
                try
                {
                    return kvp.Value[_random.Next(kvp.Value.Count)];
                }
                catch (ArgumentOutOfRangeException)
                {
                    return "An error occurred. Please try again later.";
                }
            }
        }

        return _responses["default"][_random.Next(_responses["default"].Count)];
    }
}