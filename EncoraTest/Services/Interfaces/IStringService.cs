using EncoraTest.DTOs;
using EncoraTest.Entity;

namespace EncoraTest.Services.Interfaces
{
    public interface IStringService
    {
        Output SortingOperation(List<string> phrases);
    }
}
