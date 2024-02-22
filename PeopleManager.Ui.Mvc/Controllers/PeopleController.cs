using Microsoft.AspNetCore.Mvc;
using PeopleManager.Ui.Mvc.Models;

namespace PeopleManager.Ui.Mvc.Controllers
{
public class PeopleManagerController : Controller
{
    // Actie om de lijst van personen op te halen en door te geven aan de Index-weergave
    public ActionResult Index()
    {
        List<Person> people = GetPeople(); // Je kunt deze methode later invullen met je eigen data
        return View(people);
    }

    // Hard-gecodeerde lijst van personen (kan later worden vervangen door een database of externe service)
    private List<Person> GetPeople()
    {
        List<Person> people = new List<Person>
        {
            new Person { Id = 1, FirstName = "John", LastName = "Doe" },
            new Person { Id = 2, FirstName = "Jane", LastName = "Smith" },
            // Voeg meer personen toe indien nodig
        };

        return people;
    }
}