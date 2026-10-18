using KidsClubApp.Server.IRepository;
using KidsClubApp.Shared.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KidsClubApp.Server.Data;

namespace KidsClubApp.Server.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AddressesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public AddressesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: /Addresses
        [HttpGet]
        public async Task<IActionResult> GetAddresses()
        {
            var addresses = await _unitOfWork.Addresses.GetAll();
            return Ok(addresses);
        }

        // GET: /Addresses/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAddress(int id)
        {
            var address = await _unitOfWork.Addresses.Get(q => q.AddressId == id);

            if (address == null)
            {
                return NotFound();
            }

            return Ok(address);
        }

        // PUT: /Addresses/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAddress(int id, Address address)
        {
            if (id != address.AddressId)
            {
                return BadRequest();
            }

            _unitOfWork.Addresses.Update(address);


            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await AddressExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: /Addresses
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Address>> PostAddress(Address address)
        {
            await _unitOfWork.Addresses.Insert(address);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetAddress", new { id = address.AddressId }, address);
        }

        // DELETE: /Addresses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAddress(int id)
        {
            var address = await _unitOfWork.Addresses.Get(q => q.AddressId == id);
            if (address == null)
            {
                return NotFound();
            }

            await _unitOfWork.Addresses.Delete(id);
            await _unitOfWork.Save(HttpContext);


            return NoContent();
        }


        private async Task<bool> AddressExists(int id)
        {
            var address = await _unitOfWork.Addresses.Get(q => q.AddressId == id);
            return address != null;
        }
    }
}
