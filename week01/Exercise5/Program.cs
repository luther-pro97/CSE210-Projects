using System;

class Program
{
    static void Main(string[] args)

    {

        DisplayWelcome();

        string name = PromptUserName();

        int favoriteNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(favoriteNumber);

        DisplayResult(name, squaredNumber);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine()!;

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine()!);

        return number;
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}.");
    }
}

/*string name = "luther"
int age = "25"

class Student 
{
   public string name ;
   public int age;
}
 class Car
{
 public string model;
 public string color;
 public string speed;   
}

class Book
{
    public string title;
    public string author;
    
}

Student student1 = new Student();

student1.name = "luther";
student1.age = 25;

Console.WriteLine(student1.name);
Console.WriteLine(student1.age);


