using ContactManager.Domain.Contracts.Repository;
using ContactManager.Domain.Entites;
using System;
using System.Linq;
using System.Collections.Generic;

namespace ContactManager.Data.InMemory
{
    public class PersonRepositoryInMemory : IPersonRepository
    {
        private static List<Person> db;

        public PersonRepositoryInMemory()
        {
            db = new List<Person>();
        }

        public void AddContact(string name, string number, int personId)
        {
            var person = db.FirstOrDefault(c => c.PersonId == personId);
            person.Contacts.Add(new Contact
            { Name = name, PersonId = personId, PhoneNumber = number });
        }

        public void AddPerson(Person person)
        {
            person.PersonId = db.Count + 1;
            db.Add(person);
        }

        public Person Find(int Id)
        {
            return db.FirstOrDefault(c => c.PersonId == Id);
        }

        public List<Person> GetPeople()
        {
            return db;
        }

        public void RemoveContact(string name, int personId)
        {
            var person = Find(personId);
            var contact = person.Contacts.FirstOrDefault(c => c.Name == name);
            if (contact!=null)
            {
                person.Contacts.Remove(contact);
            }
        }
    }
}
