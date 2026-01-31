using backend.DTOs;
using backend.Data;
using backend.Models;
namespace backend.Services
{
    public class AuthService : IAuthService
    {
        private readonly AppDbContext _context;
        public AuthService(AppDbContext context)
        {
            _context = context;
        }
        public User? Login(LoginRequest request) {
            var user = _context.Users.FirstOrDefault(u =>
                u.Username == request.Username && u.Role == request.Role);

            if (user == null) return null;

            if (user.PasswordHash == request.Password)
            {
                return user;
            }

            return null;
        }
        
    }
}
