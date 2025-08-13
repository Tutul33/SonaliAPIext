using Sonali.API.Domain.DTOs;

namespace Sonali.API.Domain.Interface
{
    public interface IUserRepository
    {
        Task<UserDTO> CreateUser(UserDTO userDTO);
    }
}
