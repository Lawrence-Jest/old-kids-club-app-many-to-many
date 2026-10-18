using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KidsClubApp.Server.Data;
using KidsClubApp.Shared.Domain;
using KidsClubApp.Server.IRepository;

namespace KidsClubApp.Server.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ParentsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ParentsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: /Parents
        [HttpGet]
        public async Task<IActionResult> GetParents()
        {
            var includes = new List<string> { "Address", "Children"};

            var parents = await _unitOfWork.Parents.GetAll(includes: includes);
            return Ok(parents);
        }

        // GET: /Parents/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetParent(int id)
        {
            var includes = new List<string> { "Address", "Children"};
            var parent = await _unitOfWork.Parents.Get(q => q.ParentId == id, includes);

            if (parent == null)
            {
                return NotFound();
            }

            return Ok(parent);
        }

        // PUT: /Parent/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutParent(int id, Parent parent)
        {
            if (id != parent.ParentId)
            {
                return BadRequest();
            }

            _unitOfWork.Parents.Update(parent);
            

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await ParentExists(id))
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

        // POST: /Parents
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Parent>> PostParent(Parent parent)
        {
            await _unitOfWork.Parents.Insert(parent);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetParent", new { id = parent.ParentId }, parent);
        }

        // DELETE: /Parents/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteParent(int id)
        {
            var parent = await _unitOfWork.Parents.Get(q => q.ParentId == id);
            if (parent == null)
            {
                return NotFound();
            }

            await _unitOfWork.Parents.Delete(id);
            await _unitOfWork.Save(HttpContext);
          
           
            return NoContent();
        }

        private async Task<bool> ParentExists(int id)
        {
            var parent = await _unitOfWork.Parents.Get(q => q.ParentId == id);
            return parent != null;
        }
    }
}
