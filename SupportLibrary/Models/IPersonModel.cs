namespace SupportLibrary.Models;

public interface IPersonModel
{
    int Id { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
    DateTime DateOfBirth { get; set; }
}