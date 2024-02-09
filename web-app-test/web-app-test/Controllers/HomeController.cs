using Microsoft.AspNetCore.Mvc;
using web_app_test.Models;

namespace web_app_test.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Person> _people;

        public HomeController()
        {
            _people = GeneratePeople();
        }

        public IActionResult Index()
        {
            return View(_people);
        }

        [HttpGet]
        public IActionResult GetPersonDetails(string name)
        {
            var person = _people.FirstOrDefault(p => p.Name == name);
            if (person == null)
            {
                return NotFound();
            }

            return Ok(new { Name = person.Name, Age = person.Age, Address = person.Address });
        }

        private List<Person> GeneratePeople()
        {
            var people = new List<Person>();

            for (int i = 1; i <= 50; i++)
            {
                var person = new Person
                {
                    Name = "Person " + i,
                    Age = new Random().Next(20, 60), // Generate random age between 20 and 60
                    Address = $"{i} Elm St" // Address based on index
                };

                people.Add(person);
            }

            return people;
        }
    }
}
