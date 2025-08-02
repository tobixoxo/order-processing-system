namespace OrderProcessingSystem
{
    public class User
    {
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }

        public User( string name, string email, string contactNumber)
        {
            UserId = Guid.NewGuid().ToString();
            Name = name;
            Email = email;
            ContactNumber = contactNumber;
        }
    }
    
}