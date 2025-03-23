using System;

namespace epaTerminal
{
    class Program
    {
        public enum Commands
        {
            help,
            documentIvor, 
            clear
        }

        public static string GenerateOutput(Commands cmd)
        {
            string output = "";
            

            switch (cmd)
            {
                case Commands.help:
                    output = "EPA Console Command List:\n\n1. help - Displays this page.\n2. documentIvor - [REDACTED]\n3. clear - Clears the console.";
                    break;
                case Commands.documentIvor:
                    output = "";
                    break;
            }

            return output;
        }

        public static void GenerateAction(Commands cmd)
        {
            switch(cmd)
            {
                case Commands.clear:
                    Console.Clear();
                    break;
            }
        }

        public static void EnterCommand()
        {
            Console.Write("> ");
            string? input = Console.ReadLine();

            if (Enum.TryParse(input, true, out Commands cmd))
            {
                Console.WriteLine(GenerateOutput(cmd) + "\n ");
                GenerateAction(cmd);
            }
            else
            {
                Console.WriteLine("Invalid command.");
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                EnterCommand();
            }
        }
    }
}

