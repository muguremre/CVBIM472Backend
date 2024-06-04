using muguremreCVBackend.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace muguremreCVBackend.DataAccess
{
    public class UserDal
    {
        private readonly MuguremrecvContext _context;

        public UserDal(MuguremrecvContext context)
        {
            _context = context;
        }

        public async Task<User> GetUserByUsernameAndPasswordAsync(string email, string password)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Email == email && u.Password == password);
        }
    }
}
