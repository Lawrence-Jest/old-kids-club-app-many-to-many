using KidsClubApp.Server.IRepository;
using KidsClubApp.Shared.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KidsClubApp.Server.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class SignInSheetEntriesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public SignInSheetEntriesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: /SignInSheetEntries
        [HttpGet]
        public async Task<IActionResult> GetSignInSheetEntries()
        {
            var signInSheetEntries = await _unitOfWork.SignInSheetEntries.GetAll();
            return Ok(signInSheetEntries);
        }

        // GET: /SignInSheetEntries/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSignInSheetEntry(int id)
        {
            var signInSheetEntry = await _unitOfWork.SignInSheetEntries.Get(q => q.SignInSheetEntryId == id);

            if (signInSheetEntry == null)
            {
                return NotFound();
            }

            return Ok(signInSheetEntry);
        }

        // PUT: /SignInSheetEntries/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSignInSheetEntry(int id, SignInSheetEntry signInSheetEntry)
        {
            if (id != signInSheetEntry.SignInSheetEntryId)
            {
                return BadRequest();
            }

            _unitOfWork.SignInSheetEntries.Update(signInSheetEntry);


            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await SignInSheetEntryExists(id))
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

        // POST: /SignInSheetEntries
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Parent>> PostSignInSheetEntry(SignInSheetEntry signInSheetEntry)
        {
            await _unitOfWork.SignInSheetEntries.Insert(signInSheetEntry);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetSignInSheetEntry", new { id = signInSheetEntry.SignInSheetEntryId }, signInSheetEntry);
        }

        // DELETE: /SignInSheetEntries/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSignInSheetEntry(int id)
        {
            var signInSheetEntry = await _unitOfWork.SignInSheetEntries.Get(q => q.SignInSheetEntryId == id);
            if (signInSheetEntry == null)
            {
                return NotFound();
            }

            await _unitOfWork.SignInSheetEntries.Delete(id);
            await _unitOfWork.Save(HttpContext);


            return NoContent();
        }

        private async Task<bool> SignInSheetEntryExists(int id)
        {
            var signInSheetEntry = await _unitOfWork.SignInSheetEntries.Get(q => q.SignInSheetEntryId == id);
            return signInSheetEntry != null;
        }
    }
}
