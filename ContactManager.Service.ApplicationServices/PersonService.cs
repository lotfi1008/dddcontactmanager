using ContactManager.Domain.Contracts.Repository;
using ContactManager.Domain.Services;

namespace ContactManager.Service.ApplicationServices
{
    public class PersonService
    {
        private readonly IPersonRepository _personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }
        public bool AddContnact(string number, string name, int personId)
        {
            ContactIsUnique contactIsUnique = new ContactIsUnique();
            var person = _personRepository.Find(personId);
            if (person==null)
            {
                return false; 
            }
            if (contactIsUnique.IsContactUnique(person,name))
            {
                _personRepository.AddContact(name, number, personId);
                return true;
            }
            return false;
        }
        
    }
}
