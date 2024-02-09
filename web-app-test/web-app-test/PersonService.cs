using web_app_test.Models;

namespace web_app_test
{
    public class PersonService
    {
        public List<Person> GeneratePersons()
        {
            var persons = new List<Person>();

            for (int i = 1; i <= 50; i++)
            {
                var person = new Person
                {
                    Name = "Person " + i,
                    Age = new Random().Next(20, 60), // Generate random age between 20 and 60
                    Address = $"{i} Elm St" // Address based on index
                };

                persons.Add(person);
            }

            return persons;
        }
    }
}
