# Word Scrabble

## Table of Contents 
  - [Description](#description)
  - [Requirements](#requirements)
  - [Getting Started](#getting-started)
  - [Usage](#usage)
  - [Additional Resources](#additional-resources)

You can include this table of contents at the beginning of your documentation to help users navigate through it easily.

## Description
This program accepts a sentence from the user and generates a random sentence based on the following criteria: for each word in the sentence, it replaces the word with another word that starts with the same letter and has the same length. If a suitable replacement cannot be found, the original word is retained. Additionally, the program ensures that the same input sentence yields a different output sentence each time, as it selects a random word that fulfills the criteria.

## Requirements
- .Net 6.0
- Git

## Getting Started
To run this program, follow these steps:

1. Install [.Net 6](https://dotnet.microsoft.com/en-us/download/dotnet/6.0).

2. Install [Git](https://git-scm.com/downloads) if not already installed on your system.

3. Clone or download this repository to your local machine using one of the following methods:

   - **Clone with Git:** Run the following command in your terminal to clone the repository:
     ```
     git clone https://github.com/your-username/word-scrabble.git
     ```

   - **Download as ZIP:** Alternatively, you can download the repository as a ZIP file by clicking the "Download" button on the GitHub repository's main page. Once downloaded, extract the ZIP archive to a location of your choice on your local machine.

4. Navigate to the project's root directory (in folder `Word Scrabble`) in your terminal.

5. Run the following commands to build and execute the program:
   ```
   dotnet restore
   dotnet build
   dotnet run
   ```

## Usage
Once the program is running, you can input a sentence followed by the Enter key. The program will then return a scrambled sentence based on the criteria described above.

## Additional Resources
- [Installing .Net 6](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
- [Installing Git](https://git-scm.com/downloads)
- [How to Clone a GitHub Repository](https://docs.github.com/en/repositories/creating-and-managing-repositories/cloning-a-repository)
