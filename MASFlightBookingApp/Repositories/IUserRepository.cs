using MASFlightBookingApp.Models;
using System.Threading.Tasks;

namespace MASFlightBookingApp.Repositories
{
    public interface IUserRepository
    {
        Task<RegisterResponse> Register(RegisterRequestModel model);
        Task<Login> Login();
    }
}
