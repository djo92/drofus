using Microsoft.AspNetCore.Mvc;

namespace drofus_web_app.Controllers
{
    public class PersonController : Controller
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        public IActionResult Index()
        {
            var people = _personService.GetPeople();
            Person test = new Person();
            test.Name = "Test";
            test.Id = 1;
            people.Add(test);
            return View(people);
        }

        public IActionResult Details(int id)
        {
            var person = _personService.GetPersonById(id);
            return View(person);
        }
    }
}
