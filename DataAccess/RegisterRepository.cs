using muguremreCVBackend.Entities;
using System.Threading.Tasks;

namespace muguremreCVBackend.DataAccess
{
    public interface IRegisterRepository
    {
        Task<int> AddRegisterAsync(User user);
    }

    public class RegisterRepository : IRegisterRepository
    {
        private readonly MuguremrecvContext _context;

        public RegisterRepository(MuguremrecvContext context)
        {
            _context = context; // MuguremrecvContext enjekte ediliyor
        }

        public async Task<int> AddRegisterAsync(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return user.Id;
        }
    }

}
