using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using web_store_api.Application.DTOs;
using web_store_api.Application.DTOs.WeaponDto;
using web_store_api.Domain.Entities;
using web_store_api.Domain.Pagination;

namespace web_store_api.Application.Interfaces
{
    public interface IWeaponService
    {
        Task<IEnumerable<ReadWeaponDto>> GetWeapons(WeaponsParameters weaponsParameters);
        Task<IEnumerable<ReadWeaponDto>> GetWeaponsByIlegal();
        Task<IEnumerable<ReadWeaponDto>> GetWeaponsByType(string type);
        Task<ReadWeaponDto> GetWeaponById(int? id);
        Task Add(CreateWeaponDto weaponDto);
        Task Update(UpdateWeaponDto weaponDto);
        Task Remove(int? id);
    }
}
