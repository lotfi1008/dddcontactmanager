using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactManager.Domain.Contracts.Repository;
using ContactManager.Domain.Entites;
using ContactManager.Service.ApplicationServices;
using Microsoft.AspNetCore.Mvc;

namespace ContactManager.Endpoint.WebUi.Controllers
{
    public class PersonController : Controller
    {
        private readonly PersonService personService;
        private readonly IPersonRepository personRepository;

        public PersonController(PersonService personService,IPersonRepository personRepository)
        {
            this.personService = personService;
            this.personRepository = personRepository;
        }
        public IActionResult Index()
        {
            return View(personRepository.GetPeople());
        }
        public IActionResult AddContact(int id)
        {
            personService.AddContnact("09185605324","mohammad "+DateTime.Now.Ticks,id);
            
            return View("index");
        }
        public IActionResult Create()
        {
            Person person = new Person()
            {
                Name = $"Name {DateTime.Now.Ticks}",
                LastName = $"LastName {DateTime.Now.Ticks}"
            };
            personRepository.AddPerson(person);
            return View(person); 
        }
        public IActionResult Contacts(int id)
        {
            var person=personRepository.Find(id);

            return View(person.Contacts);
        }
    }
}