using AutoMapper;
using Sonali.API.Domain.DTOs;
using Sonali.API.Domain.Interface;
using Sonali.API.Infrustructure.Data.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonali.API.Infrustructure.DAL.Repository
{
    public class LoginRepository : ILoginRepository
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;
        public LoginRepository(AppDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public Task<UserDTO> Login(LoginDTO loginDTO)
        {
            try
            {
                if (loginDTO == null)
                {
                    throw new ArgumentNullException(nameof(loginDTO), "Login data cannot be null");
                }
                string hashToStoreInDatabase = BCrypt.Net.BCrypt.HashPassword(loginDTO.Password, BCrypt.Net.BCrypt.GenerateSalt());
                var user = _dbContext.AppUsers
                    .FirstOrDefault(u => u.UserName == loginDTO.UserName.ToString().Trim());
                if (user == null)
                {
                    throw new UnauthorizedAccessException("Invalid username or password");
                }

                if (!BCrypt.Net.BCrypt.Verify(loginDTO.Password, user.Password))
                {
                    throw new UnauthorizedAccessException("Invalid username or password");
                }
                user.Password = loginDTO.Password;
                return Task.FromResult(_mapper.Map<UserDTO>(user));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
