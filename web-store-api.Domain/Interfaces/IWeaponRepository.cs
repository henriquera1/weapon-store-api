using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using web_store_api.Domain.Entities;
using web_store_api.Domain.Pagination;

namespace web_store_api.Domain.Interfaces
{
    public interface IWeaponRepository
    {
        Task<IEnumerable<Weapon>> GetWeaponsAsync(WeaponsParameters weaponsParameters);
        Task<IEnumerable<Weapon>> GetWeaponsByTypeAsync(string type);
        Task<IEnumerable<Weapon>> GetWeaponsByYearAsync();
        Task<Weapon> GetWeaponByIdAsync(int? id);
        Task<Weapon> CreateAsync(Weapon weapon);
        Task<Weapon> UpdateAsync(Weapon weapon);
        Task<Weapon> RemoveAsync(Weapon weapon);
    }
}
