using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web_store_api.Application.DTOs;
using web_store_api.Application.Interfaces;

namespace web_store_api.Controllers
{
    [ApiConventionType(typeof(DefaultApiConventions))]
    [Produces("application/json")]
    [Route("api/v1/[controller]")]
    [ApiController]
    public class WeaponsController : ControllerBase
    {
        private readonly IWeaponService _ws;

        public WeaponsController(IWeaponService ws)
        {
            _ws = ws;
        }

        /// <summary>
        /// Retorna todas as armas do banco de dados
        /// </summary>
        /// <returns>Lista de Armas</returns>
        [HttpGet]
        [ProducesResponseType(typeof(WeaponDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<WeaponDTO>>> GetWeapons()
        {
            var weapons = await _ws.GetWeapons();

            if (weapons == null)
                return NotFound("Não foi encontrada nenhuma arma no banco de dados.");

            return Ok(weapons);
        }

        /// <summary>
        /// Retorna uma lista de armas pelo seu tipo
        /// </summary>
        /// <param name="type">Tipo da arma</param>
        /// <returns>Lista de Armas de um determinado tipo</returns>
        [HttpGet("type/{type}")]
        [ProducesResponseType(typeof(WeaponDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<WeaponDTO>>> GetWeaponsByType(string type)
        {
            var weapons = await _ws.GetWeaponsByType(type);

            if (weapons == null)
                return NotFound("Não foi encontrada nenhuma arma desse tipo no banco de dados.");

            return Ok(weapons);
        }

        /// <summary>
        /// Retorna uma lista de armas ordenadas pelo Ano de fabricação
        /// </summary>
        /// <returns>Lista de Armas por Ano</returns>
        [HttpGet]
        [Route("Year")]
        [ProducesResponseType(typeof(WeaponDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<WeaponDTO>>> GetWeaponsByYear()
        {
            var weapons = await _ws.GetWeaponsByYear();

            if (weapons == null)
                return NotFound("Não foi encontrada nenhuma arma no banco de dados.");

            return Ok(weapons);
        }

        /// <summary>
        /// Retorna uma arma com id específico
        /// </summary>
        /// <param name="id">id da arma</param>
        /// <returns>Uma arma com id informado</returns>
        [HttpGet("{id}",Name = "GetWeaponById")]
        [ProducesResponseType(typeof(WeaponDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<WeaponDTO>> GetWeaponById(int id)
        {
            var weapon = await _ws.GetWeaponById(id);

            if (weapon == null)
                return NotFound($"Não foi encontrada nenhuma arma com id: {id} no banco de dados.");

            return Ok(weapon);

        }

        /// <summary>
        /// Adiciona ao banco de dados uma nova arma
        /// </summary>
        /// <remarks>
        /// Exemplo de request:
        /// <para>
        ///     POST api/v1/Weapons
        /// </para>
        /// <para>
        /// {
        /// </para>
        /// <para>
        ///     "id": 1,
        /// </para>
        /// <para>
        ///     "name": "M4A1",
        /// </para>
        /// <para>
        ///     "brand":"FN Herstal",
        /// </para>
        /// <para>
        ///     "image":"http://www.imagens/m4a1.png",
        /// </para>
        /// <para>
        ///     "type":"Carabina",
        /// </para>
        /// <para>
        ///     "caliber":"5,56mm",
        /// </para>
        /// <para>
        ///     "year": 1984,
        /// </para>
        /// <para>
        /// }
        /// </para>
        /// </remarks>
        /// <param name="weaponDto">Objeto da Arma</param>
        /// <returns>O objeto criado</returns>
        [HttpPost]
        [ProducesResponseType(typeof(WeaponDTO), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Post([FromBody] WeaponDTO weaponDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _ws.Add(weaponDto);

            return new CreatedAtRouteResult("GetWeaponById",
                new { id = weaponDto.Id }, weaponDto);
        }

        /// <summary>
        /// Atualiza uma arma existente de acordo com o id informado
        /// </summary>
        /// <param name="id">Id da arma que queira atualizar</param>
        /// <param name="weaponDto">Novo corpo atualizado</param>
        /// <returns>O Objeto atualizado</returns>
        [HttpPut("{id}")]
        [ApiConventionMethod(typeof(DefaultApiConventions),
                                    nameof(DefaultApiConventions.Put))]
        public async Task<ActionResult> Put(int id, [FromBody] WeaponDTO weaponDto)
        {
            if (id != weaponDto.Id)
            {
                return BadRequest("Id do corpo deve ser o mesmo do parâmetro");
            }

            await _ws.Update(weaponDto);

            return Ok(weaponDto);
        }

        /// <summary>
        /// Remove do banco de dados uma arma com id informado
        /// </summary>
        /// <param name="id">Id da arma</param>
        /// <returns>A arma removida</returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(WeaponDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<WeaponDTO>> Delete(int id)
        {
            var produtoDto = await _ws.GetWeaponById(id);
            if (produtoDto == null)
            {
                return NotFound($"Arma com id: {id} não foi encontrada no banco de dados.");
            }
            await _ws.Remove(id);
            return Ok(produtoDto);
        }


    }
}
