using backend.Models;
using backend.DTOs;

namespace backend.Services
{
    public interface IAuthService
    {
        User? Login(LoginRequest request);
    }
}
