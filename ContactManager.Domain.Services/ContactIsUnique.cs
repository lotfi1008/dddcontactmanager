using ContactManager.Domain.Entites;
using System.Linq;

namespace ContactManager.Domain.Services
{
    public class ContactIsUnique
    {
        public bool IsContactUnique(Person person, string contactName)
        {
            return person.Contacts.All(c=>c.Name==contactName);
        }
    }
}
