namespace ContactsAPI.Model
{
    public class AddContactRequest
    {
        public string OwnerName { get; set; }
        public string Roomdescription { get; set; }
        public double Rent { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }
        public string Address { get; set; }
    }
}
