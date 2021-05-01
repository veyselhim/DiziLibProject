namespace Core.Entities.Concrete
{
    public class User:IEntity
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string TelephoneNumber { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public bool Status { get; set; }
        

    }
}
