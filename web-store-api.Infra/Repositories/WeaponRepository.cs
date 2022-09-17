using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using web_store_api.Domain.Entities;
using web_store_api.Domain.Interfaces;
using web_store_api.Domain.Pagination;
using web_store_api.Infra.Context;

namespace web_store_api.Infra.Repositories
{
    public class WeaponRepository : IWeaponRepository
    {
        private AppDbContext _context;

        public WeaponRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Weapon>> GetWeaponsAsync(WeaponsParameters weaponsParameters)
        {
            return await _context.Weapons.OrderBy(x => x.Name)
                                         .Skip((weaponsParameters.PageNumber - 1) * weaponsParameters.PageSize)
                                         .Take(weaponsParameters.PageSize)
                                         .ToListAsync();
        }

        public async Task<IEnumerable<Weapon>> GetWeaponsByIlegalAsync()
        {
            return await _context.Weapons.OrderBy(x => x.IsIlegal).Where(x => x.IsIlegal == false).ToListAsync();
        }

        public async Task<IEnumerable<Weapon>> GetWeaponsByTypeAsync(string type)
        {
            string typeFormat = char.ToUpper(type[0]) + type.Substring(1);
            return await _context.Weapons.Where(x => x.Type == typeFormat).ToListAsync();
            

        }

        public async Task<Weapon> GetWeaponByIdAsync(int? id)
        {
            return await _context.Weapons.SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Weapon> CreateAsync(Weapon weapon)
        {
            _context.Weapons.Add(weapon);
            await _context.SaveChangesAsync();
            return weapon;
        }
 
        public async Task<Weapon> UpdateAsync(Weapon weapon)
        {
            _context.Weapons.Update(weapon);
            await _context.SaveChangesAsync();
            return weapon;
        }

        public async Task<Weapon> RemoveAsync(Weapon weapon)
        {
            _context.Weapons.Remove(weapon);
            await _context.SaveChangesAsync();
            return weapon;
        }

    }
}