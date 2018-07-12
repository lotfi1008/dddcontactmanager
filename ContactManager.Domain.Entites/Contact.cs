namespace ContactManager.Domain.Entites
{
    public class Contact
    {
        public int ContactId { get; set; }
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
    }


}
