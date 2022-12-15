namespace MASFlightBookingApp.Models
{
    public class Register
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }    
        public string ConfirmPassword { get; set; }
        public bool RememberMe { get; set; }


    }
}
