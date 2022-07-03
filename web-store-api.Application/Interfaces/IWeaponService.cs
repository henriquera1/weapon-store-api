using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using web_store_api.Application.DTOs;
using web_store_api.Domain.Entities;

namespace web_store_api.Application.Interfaces
{
    public interface IWeaponService
    {
        Task<IEnumerable<WeaponDTO>> GetWeapons();
        Task<IEnumerable<WeaponDTO>> GetWeaponsByYear();
        Task<IEnumerable<WeaponDTO>> GetWeaponsByType(string type);
        Task<WeaponDTO> GetWeaponById(int? id);
        Task Add(WeaponDTO weaponDto);
        Task Update(WeaponDTO weaponDto);
        Task Remove(int? id);
    }
}
