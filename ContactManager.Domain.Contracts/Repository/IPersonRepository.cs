using ContactManager.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContactManager.Domain.Contracts.Repository
{
    public interface IPersonRepository
    {
        List<Person> GetPeople();
        void AddPerson(Person person);
        void AddContact(string name,string number,int personId);
        void RemoveContact(string name,int personId);
        Person Find(int Id);
    }
}
