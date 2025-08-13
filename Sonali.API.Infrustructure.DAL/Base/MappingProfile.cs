using AutoMapper;
using Sonali.API.Domain.DTOs;
using Sonali.API.Domain.Entities;
using Sonali.API.Infrustructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonali.API.Infrustructure.DAL.Base
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserDTO, AppUser>();
            CreateMap<AppUser, UserDTO>();

            CreateMap<LoginDTO, AdmLogin>();
            CreateMap<AdmLogin, LoginDTO>();

            CreateMap<VoucherReferralDTO, AccVoucherReferral>();
            CreateMap<AccVoucherReferral, VoucherReferralDTO>();
            CreateMap<VoucherUpdateDTO, Accgl2025>();
        }
    }
}
