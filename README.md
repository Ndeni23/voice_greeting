Cybersecurity Awareness Chatbot

This project is a simple command-line chatbot designed to provide basic information about cybersecurity topics.  The chatbot responds to user queries related to passwords, phishing, viruses, safe browsing, and more.

Features:

Interactive Command-Line Interface: Users interact with the chatbot through the console.
Cybersecurity Information: Provides answers to common cybersecurity questions.
Audio Welcome Message (Optional): Plays a welcome sound file (`greeting.wav`).
ASCII Art Logo (Optional): Displays a logo at startup by converting a JPG image (`robots.jpg`) to ASCII art.
Robust Error Handling: Gracefully handles missing files and other potential errors.

Requirements:

.NET 6.0 (or later): The project is built using .NET 6.0. You'll need the .NET SDK installed.
(Optional) `greeting.wav`: A WAV audio file for the welcome sound.  Place this in the same directory as the executable.
(Optional) `robots.jpg`: A JPG image file for the ASCII art logo. Place this in the same directory as the executable. A smaller image (e.g., 120x50 pixels) will improve ASCII art quality and reduce processing time.

Getting Started:

1. Clone the repository:`git clone <repository_url>` (replace `<repository_url>` with your repo URL)
2. Navigate to the project directory: `cd <project_directory>` (replace `<project_directory>` with your project directory)
3. Build the project: `dotnet build`
4. Run the application: `dotnet run`

How to Use:

1. The chatbot will display a welcome message (and optionally play a sound and display a logo).
2. You will be prompted to enter your name.
3. Type your cybersecurity-related questions. The chatbot will respond based on keywords.
4. Type 'exit' to quit.

Technical Details:

Programming Language: C#
.NET Framework: .NET 6.0 (or later)
Data Structures: Uses arrays to store error messages and a more efficient dictionary to store keyword-response pairs for faster lookups.
File Handling: Uses `System.IO` for file operations (loading audio and potentially the image).
Image Processing:  Converts a JPG image to ASCII art for display.
Error Handling: Includes `try-catch` blocks for robust error management.
Object-Oriented Programming: Uses classes (`Program`, `ResponseHandler`, `welcome_message`, `Logo`) for better code organization.

Future Improvements:

More Robust NLP: Implement more sophisticated natural language processing to improve understanding of user input.
Expanded Knowledge Base: Add more cybersecurity topics and responses.
GUI: Develop a graphical user interface for a more user-friendly experience.
Database Integration: Store responses in a database for easier management.
