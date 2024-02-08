namespace drofus_web_app
{ 
using System.Collections.Generic;
using System.Linq;

public interface IPersonService
{
    List<Person> GetPeople();
    Person GetPersonById(int id);
}

public class PersonService : IPersonService
{
    private readonly List<Person> _people;

    public PersonService()
    {
        _people = new List<Person>
        {
            new Person { Id = 1, Name = "John Doe" },
            new Person { Id = 2, Name = "Jane Smith" }
            // Add more sample data as needed
        };
    }

    public List<Person> GetPeople()
    {
        return _people;
    }

    public Person GetPersonById(int id)
    {
        return _people.FirstOrDefault(p => p.Id == id);
    }
}
}