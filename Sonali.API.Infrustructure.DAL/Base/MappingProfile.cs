﻿using AutoMapper;
using Sonali.API.Domain.DTOs;
using Sonali.API.Domain.DTOs.DemoDTO;
using Sonali.API.Domain.Entities;
using Sonali.API.Domain.Entities.Demo;
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
            CreateMap<AccUserRoleMap, UserRoleMapDTO>()
                .BeforeMap((src, dest) =>
                {
                    if (src.IsActive == null)
                        src.IsActive = false;
                })
                .AfterMap((src, dest) =>
                {
                    dest.UserRoleMapId = src.Id;
                    dest.RoleName = "Default Role";
                });

            CreateMap<UserRoleMapDTO, AccUserRoleMap>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.UserRoleMapId))
                .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive));
            //For Demo Mapping
            CreateMap<DemoDTO, AccDemo>();
            CreateMap<AccDemo, DemoDTO>();
        }
    }
}
