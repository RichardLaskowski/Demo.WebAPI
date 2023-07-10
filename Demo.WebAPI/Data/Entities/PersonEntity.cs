namespace Demo.WebAPI.Data.Entities;

public class PersonEntity
{
    public int PersonId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public PersonEntity()
    {
        PersonId = 0;
        FirstName = string.Empty;
        LastName = string.Empty;
    }

    public PersonEntity(string firstName, string lastName)
    {
        PersonId = 0;
        FirstName = firstName;
        LastName = lastName;
    }
}
