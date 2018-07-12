using ContactManager.Domain.Contracts.Repository;
using ContactManager.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContactManager.Data.EF.Repositories
{
    public class PersonRepository :BaseRepository, IPersonRepository
    {
        public PersonRepository(ContactDBContext contactDBContext) : base(contactDBContext)
        {
        }

        public void AddContact(string name, string number, int personId)
        {
            Contact contact = new Contact
            {
                Name=name,
                PhoneNumber=number,
                PersonId=personId
            };
            _ctx.Contacts.Add(contact);
            _ctx.SaveChanges();
        }

        public void AddPerson(Person person)
        {
            _ctx.Persons.Add(person);
            _ctx.SaveChanges();
        }

        public Person Find(int Id)
        {
            return _ctx.Persons.Include(c => c.Contacts).Where(c => c.PersonId == Id).FirstOrDefault();
        }

        public List<Person> GetPeople()
        {
            return _ctx.Persons.Include(c => c.Contacts).ToList(); 
        }

        public void RemoveContact(string name, int personId)
        {
            var person = Find(personId);
            var contacForRemove = person.Contacts.FirstOrDefault(c => c.Name == name);
            if (contacForRemove!=null)
            {
                _ctx.Contacts.Remove(contacForRemove);
                _ctx.SaveChanges();
            }
        }
    }
}
