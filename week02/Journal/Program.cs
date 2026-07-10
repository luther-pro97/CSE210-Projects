using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator prompts = new PromptGenerator();

        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine();
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");

            Console.Write("Choose an option: ");

            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Entry entry = new Entry();

                entry._date = DateTime.Now.ToShortDateString();

                entry._prompt = prompts.GetRandomPrompt();

                Console.WriteLine(entry._prompt);

                Console.Write("> ");

                entry._response = Console.ReadLine();

                journal.AddEntry(entry);
            }

            else if (choice == 2)
            {
                journal.DisplayJournal();
            }

            else if (choice == 3)
            {
                Console.Write("Filename: ");

                string filename = Console.ReadLine();

                journal.SaveToFile(filename);
            }

            else if (choice == 4)
            {
                Console.Write("Filename: ");

                string filename = Console.ReadLine();

                journal.LoadFromFile(filename);
            }

            else if (choice == 5)
            {
                Console.WriteLine("Goodbye!");
            }

            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }
}