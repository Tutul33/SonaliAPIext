using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using Sonali.API.Domain.DTOs;
using Sonali.API.Infrustructure.DAL.Repository;
using Sonali.API.Infrustructure.Data.Data;
using Sonali.API.Infrustructure.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
namespace Sonali.API.Tests.UnitTests.Repository
{
    public class VoucherRepositoryTests
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly VoucherRepository _repository;

        public VoucherRepositoryTests()
        {
            // Setup isolated service provider for InMemory database
            var services = new ServiceCollection();
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseInMemoryDatabase("TestDb");
            });
            var serviceProvider = services.BuildServiceProvider();
            _dbContext = serviceProvider.GetRequiredService<AppDbContext>();

            // Setup AutoMapper
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<VoucherUpdateDTO, Accgl2025>().ReverseMap();
            });
            _mapper = config.CreateMapper();

            _repository = new VoucherRepository(_dbContext, _mapper);
        }

        [Fact]
        public async Task UpdateVoucher_ShouldAddNewVoucher()
        {
            var voucherList = new List<VoucherUpdateDTO>
            {
                new VoucherUpdateDTO
                {
                    Id = 0,
                    Tag = EntityState.Added,
                    Damount = 100,
                    Camount = 100,
                    UpdateType = "referral-pending" // important
                }
            };
            var result = await _repository.UpdateVoucher(voucherList);

            Assert.Single(result);
            Assert.Single(_dbContext.Accgl2025s);
            Assert.Equal(100, _dbContext.Accgl2025s.First().Damount);
        }
    }

}