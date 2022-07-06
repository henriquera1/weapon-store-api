using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using web_store_api.Application.DTOs;
using web_store_api.Application.Interfaces;
using web_store_api.Domain.Entities;
using web_store_api.Domain.Interfaces;
using web_store_api.Domain.Pagination;

namespace web_store_api.Application.Services
{
    public class WeaponService : IWeaponService
    {
        private IWeaponRepository _wr;

        private readonly IMapper _mapper;

        public WeaponService(IMapper mapper, IWeaponRepository wr)
        {
            _wr = wr ?? throw new ArgumentNullException(nameof(wr));
            _mapper = mapper;
        }
    
        public async Task<IEnumerable<WeaponDTO>> GetWeapons(WeaponsParameters weaponsParameters)
        {
            var weaponsEntity = await _wr.GetWeaponsAsync(weaponsParameters);
            return _mapper.Map<IEnumerable<WeaponDTO>>(weaponsEntity);
        }
        
        public async Task<IEnumerable<WeaponDTO>> GetWeaponsByYear()
        {
            var weaponsEntity = await _wr.GetWeaponsByYearAsync();
            return _mapper.Map<IEnumerable<WeaponDTO>>(weaponsEntity);
        }
        
        public async Task<IEnumerable<WeaponDTO>> GetWeaponsByType(string type)
        {
            var weaponsEntity = await _wr.GetWeaponsByTypeAsync(type);
            return _mapper.Map<IEnumerable<WeaponDTO>>(weaponsEntity);
        }

        public async Task<WeaponDTO> GetWeaponById(int? id)
        {
            var weaponEntity = await _wr.GetWeaponByIdAsync(id);
            return _mapper.Map<WeaponDTO>(weaponEntity);
        }

        public async Task Add(WeaponDTO weaponDto)
        {
            var weaponEntity = _mapper.Map<Weapon>(weaponDto);
            await _wr.CreateAsync(weaponEntity);
        }

        public async Task Update(WeaponDTO weaponDto)
        {

            var weaponEntity = _mapper.Map<Weapon>(weaponDto);
            await _wr.UpdateAsync(weaponEntity);
        }

        public async Task Remove(int? id)
        {
            var weaponEntity = _wr.GetWeaponByIdAsync(id).Result;
            await _wr.RemoveAsync(weaponEntity);
        }
    }
}
