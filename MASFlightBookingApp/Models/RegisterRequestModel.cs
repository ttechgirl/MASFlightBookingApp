namespace MASFlightBookingApp.Models
{
    public class RegisterRequestModel
    {
        public bool Success { get; set; }
        public string Error { get; set; }
        public FLWData MakePayment { get; set; }
    }

    public class FLWData
    {
        public string link { get; set; }
    }

}
