using EncoraTest.DTOs;
using EncoraTest.Entity;
using EncoraTest.Services;
using System.Text.RegularExpressions;
using WebApi.Helpers;

public class MainClass
{
    static void Main()
    {
        var instance = new StringService();

        var input = new Input();
        input.Phrases = new List<string>();
        var output = new Output();
        output.Phrases = new List<string>();

        Console.WriteLine("Hello, friend.");
        Console.WriteLine("Please enter a number: ");
        var inputNumber = Console.ReadLine();
        if (inputNumber.All(char.IsDigit))
        {
            input.Quantity = Int32.Parse(inputNumber);
        }
        else
        {
            throw new AppException("Input was not a number. Goodbye!");
        }

        Console.WriteLine($"Now please enter: {input.Quantity} phrases.");

        var aux = 0;

        while (aux < input.Quantity)
        {
            var inputString = Console.ReadLine();
            if (Regex.IsMatch(inputString, @"^[a-zA-Z]+$"))
            {
                inputString.ToLower();
                input.Phrases.Add(inputString);
                aux++;
                Console.WriteLine($"{input.Quantity - aux} phrases remaining.");
            }
            else
            {
                throw new AppException("Invalid character was not a number. Goodbye!");
            }
        }

        Console.WriteLine("Ok. Let me do the magic...");

        var result = instance.SortingOperation(input);

        foreach (var phrase in result.Phrases)
        {
            Console.WriteLine(phrase);
        }

        Console.WriteLine("Press enter to close...");
        Console.ReadLine();
    }
}
