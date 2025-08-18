using Xunit;
using Moq;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Sonali.API.Infrustructure.DAL.Repository;
using Sonali.API.Infrustructure.Data.Data;
using Sonali.API.Domain.DTOs;
using System.Threading.Tasks;
using System.Collections.Generic;
using Sonali.API.Infrustructure.Data.Models;
namespace Sonali.API.Tests.UnitTests.Repository
{
    public class VoucherRepositoryTests
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly VoucherRepository _repository;

        public VoucherRepositoryTests()
        {
            // Setup in-memory DbContext
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDb")
                .Options;

            _dbContext = new AppDbContext(options);

            // Setup AutoMapper
            var mockMapper = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<VoucherUpdateDTO, Accgl2025>().ReverseMap();
            });
            _mapper = mockMapper.CreateMapper();

            _repository = new VoucherRepository(_dbContext, _mapper);
        }

        [Fact]
        public async Task UpdateVoucher_ShouldAddNewVoucher()
        {
            // Arrange
            var voucherList = new List<VoucherUpdateDTO>
        {
            new VoucherUpdateDTO
            {
                Id = 0,
                Tag = EntityState.Added,
                Damount = 100,
                Camount = 100
            }
        };

            // Act
            var result = await _repository.UpdateVoucher(voucherList);

            // Assert
            Assert.Single(result);
            Assert.Single(_dbContext.Accgl2025s);
            Assert.Equal(100, _dbContext.Accgl2025s.First().Damount);
        }
    }
}