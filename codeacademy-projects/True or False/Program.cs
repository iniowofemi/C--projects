using System;

namespace TrueOrFalse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Do not edit these lines
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();
            Tools.SetUpInputStream(entry);

            // Type your code below
            string[] questions = new string[] { "Question 1", "Question 2", "Question 3", "Question 4", "Question 5" };
            bool[] answers = new bool[] { true, true, false, false, true };
            bool[] responses = new bool[answers.Length];

            if (answers.Length != responses.Length)
            {
                Console.WriteLine("The arrays are not of equal length");
            }

            int askingIndex = 0;
            foreach (string question in questions)
            {
                string input;
                bool isBool;
                bool inputBool;
                Console.WriteLine(question);
                Console.WriteLine("True of False? \n");
                input = Console.ReadLine();
                isBool = Boolean.TryParse(input, out inputBool);

                while (!isBool)
                {
                    Console.WriteLine("Please respond with 'true' or 'false'.");
                    Console.WriteLine(question);
                    Console.WriteLine("True of False? \n");
                    input = Console.ReadLine();
                    isBool = Boolean.TryParse(input, out inputBool);
                }

                responses[askingIndex] = inputBool;
                askingIndex += 1;

            }

            Console.WriteLine("\n");

            foreach (bool response in responses)
            {
                Console.WriteLine(response);
            }

            int scoringIndex = 0;
            int score = 0;

            foreach (bool answer in answers)
            {
                bool responseCheck = responses[scoringIndex];
                Console.WriteLine($"Input: {responseCheck} | Answer: {answers[scoringIndex]}");
                if (responseCheck == answers[scoringIndex])
                {
                    score += 1;
                }
                scoringIndex += 1;
            }
            Console.WriteLine($"You got {score} out of {questions.Length} correct!");
        }
    }
}
