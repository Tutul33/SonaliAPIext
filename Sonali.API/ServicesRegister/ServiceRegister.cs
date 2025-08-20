using Sonali.API.Domain.Interface;
using Sonali.API.DomainService.DataService;
using Sonali.API.DomainService.Interface;
using Sonali.API.DomainService.Repository;
using Sonali.API.Infrustructure.DAL.Repository;
using Sonali.API.Middlewares;
using Sonali.API.Utilities.FileManagement;

namespace Sonali.API.ServicesRegister
{
    public static class ServiceRegister
    {
        public static void Register(WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IFileManager, FileManager>();
            builder.Services.AddScoped(typeof(IGenericFactoryMSSQL<>), typeof(GenericFactoryMSSQL<>));
            builder.Services.AddScoped<IJwtTokenService, JwtTokenService>();

            builder.Services.AddScoped<ILoginRepository, LoginRepository>();
            builder.Services.AddScoped<IUserRepository, UserRepository>();
            builder.Services.AddScoped<IUserDomainService, UserDomainService>();
            builder.Services.AddScoped<IAccountingDomainService, AccountingDomainService>();
            builder.Services.AddScoped<IVoucherRepository, VoucherRepository>();
            builder.Services.AddScoped<IDemoRepository, DemoRepository>();

        }
    }
}
