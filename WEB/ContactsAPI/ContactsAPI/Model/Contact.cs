namespace ContactsAPI.Model
{
    public class Contact
    {
        public Guid Id { get; set; }
        public string OwnerName { get; set; }
        public string Roomdescription { get; set; }
        public double Rent { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }
        public string Address { get; set; }


    }
}
