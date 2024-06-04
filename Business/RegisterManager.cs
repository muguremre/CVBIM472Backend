using Microsoft.Win32;
using muguremreCVBackend.DataAccess;
using muguremreCVBackend.Entities;
using System.Threading.Tasks;

namespace muguremreCVBackend.Business
{
    public interface IRegisterManager
    {
        Task<int> RegisterAsync(User user);
    }

    public class RegisterManager : IRegisterManager
    {
        private readonly IRegisterRepository _registerRepository;

        public RegisterManager(IRegisterRepository registerRepository)
        {
            _registerRepository = registerRepository;
        }

        public async Task<int> RegisterAsync(User user)
        {
            return await _registerRepository.AddRegisterAsync(user);
        }
    }
}
