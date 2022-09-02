using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using web_store_api.Application.DTOs.Weapon;
using web_store_api.Domain.Entities;

namespace web_store_api.Application.Mapping
{
    public class WeaponProfile : Profile
    {
        public WeaponProfile()
        {
            CreateMap<CreateWeaponDto, Weapon>();
            CreateMap<Weapon, ReadWeaponDto>();
            CreateMap<UpdateWeaponDto, Weapon>();
        }
    }
}
