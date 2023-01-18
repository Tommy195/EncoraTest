using EncoraTest.DTOs;
using EncoraTest.Entity;
using EncoraTest.Services;
using System.Text.RegularExpressions;
using WebApi.Helpers;

public class MainClass
{
    static void Main()
    {
        try
        {
            var instance = new StringService();

            var input = new Input();
            input.Phrases = new List<string>();
            var output = new Output();
            output.Phrases = new List<string>();

            Console.WriteLine("Hello, friend.");
            Console.WriteLine("Please enter a number: ");
            var inputNumber = Console.ReadLine();
            
            if (!inputNumber.All(char.IsDigit))
                throw new AppException("Input was not a number. Goodbye!");

            input.Quantity = Int32.Parse(inputNumber);

            Console.WriteLine($"Now please enter: {inputNumber} phrases.");

            var aux = 0;

            while (aux < input.Quantity)
            {
                var inputString = Console.ReadLine();
                inputString.ToLower();
                input.Phrases.Add(inputString);
                aux++;
                Console.WriteLine($"{input.Quantity - aux} phrases remaining.");
            }

            Console.Clear();
            Console.WriteLine("Ok. Let me do the magic...");
            Console.WriteLine();
            Console.WriteLine("Result:");
            Console.WriteLine();

            var result = instance.SortingOperation(input.Phrases);

            foreach (var phrase in result.Phrases)
            {
                Console.WriteLine(phrase);
            }

            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
        catch (AppException ex)
        {

            Console.WriteLine(ex.Message);
        }
    }
}
