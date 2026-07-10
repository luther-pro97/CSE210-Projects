
using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord today?",
        "What was the strongest emotion I felt today?",
        "If I could do one thing over today, what would it be?"
    };

    Random random = new Random();

    public string GetRandomPrompt()
    {
        int number = random.Next(_prompts.Count);

        return _prompts[number];
    }
}