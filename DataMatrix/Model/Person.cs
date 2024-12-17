namespace DataMatrix.Model
{
    public record Person(int Id, Gender Gender, string FirstName, string LastName, DateOnly Birthday);
}