using System.Collections.Generic;

namespace ContactManager.Domain.Entites
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public List<Contact> Contacts { get; set; } = new List<Contact>();
    }


}
