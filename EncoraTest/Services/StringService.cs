using EncoraTest.DTOs;
using EncoraTest.Entity;
using EncoraTest.Services.Interfaces;
using System.Text.RegularExpressions;
using WebApi.Helpers;

namespace EncoraTest.Services
{
    public class StringService : IStringService
    {
        public StringService() { }

        public Output SortingOperation(List<string> phrases)
        {
            var orderedStringsToReturn = new Output();
            orderedStringsToReturn.Phrases = new List<string>();

            foreach (var phrase in phrases)
            {
                if (!Regex.IsMatch(phrase, @"^[a-zA-Z]+$"))
                    throw new AppException($"Invalid character, {phrase} contains a character is not an a-z letter. Goodbye!");

                var phraseToOrder = phrase.GroupBy(x => x).OrderByDescending(x => x.Count()).ThenBy(x => x.Key).SelectMany(x => x).ToList();
                
                orderedStringsToReturn.Phrases.Add(string.Join("", phraseToOrder.Select(x => x)));
            }


            return orderedStringsToReturn;
        }
    }
}
