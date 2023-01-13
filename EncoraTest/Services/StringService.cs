using EncoraTest.DTOs;
using EncoraTest.Entity;
using EncoraTest.Services.Interfaces;

namespace EncoraTest.Services
{
    public class StringService : IStringService
    {
        public StringService() { }

        public Output SortingOperation(Input inputObject)
        {
            var orderedStringsToReturn = new Output();
            orderedStringsToReturn.Phrases = new List<string>();

            foreach (var phrase in inputObject.Phrases)
            {
                var phraseToOrder = phrase.GroupBy(x => x).OrderByDescending(x => x.Count()).ThenBy(x => x.Key).SelectMany(x => x).ToList();
                
                orderedStringsToReturn.Phrases.Add(string.Join("", phraseToOrder.Select(x => x)));
            }


            return orderedStringsToReturn;
        }
    }
}
