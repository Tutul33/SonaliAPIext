using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Sonali.API.Domain.DTOs;
using Sonali.API.Domain.Entities;
using Sonali.API.Domain.Interface;
using Sonali.API.Infrustructure.Data.Data;
using Sonali.API.Infrustructure.Data.Models;
using System;
using System.Threading.Tasks;

namespace Sonali.API.Infrustructure.DAL.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;

        public UserRepository(AppDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<UserDTO> CreateUser(UserDTO userDTO)
        {
            try
            {
                if (userDTO == null)
                {
                    throw new ArgumentNullException(nameof(userDTO), "User data cannot be null");
                }

                var user = _mapper.Map<AppUser>(userDTO);

                _dbContext.AppUsers.Add(user);
                await _dbContext.SaveChangesAsync();

                userDTO.Id = user.Id; // Assuming Id is auto-generated
                await CreateLogin(userDTO);
                return userDTO;
            }
            catch (Exception)
            {

                throw;
            }
        }
        private async Task CreateLogin(UserDTO admUserDTO)
        {
            try
            {
                //AdmLogin login = new AdmLogin
                //{
                //    UserName = admUserDTO.UserName,
                //    Password = admUserDTO.Password,
                //    UserId = admUserDTO.Id,
                //    CreateDate = DateTime.Now,
                //    IsActive = true
                //};
                //_dbContext.AdmLogins.Add(login);
                //await _dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
