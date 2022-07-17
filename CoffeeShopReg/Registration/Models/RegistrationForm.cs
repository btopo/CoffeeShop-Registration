namespace Registration.Models
{
    public partial class RegistrationForm
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public GenderEnum Gender{ get; set; }

    }
}
