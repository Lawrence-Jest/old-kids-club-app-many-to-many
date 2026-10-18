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
    [Route("api/[controller]")]
    [ApiController]
    public class ChildrenController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ChildrenController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: /Children
        [HttpGet]
        public async Task<IActionResult> GetChildren()
        {
            var Children = await _unitOfWork.Children.GetAll();
            return Ok(Children);
        }

        // GET: /Child/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetChild(int id)
        {
            var Children = await _unitOfWork.Children.Get(q => q.ChildId == id);

            if (Children == null)
            {
                return NotFound();
            }

            return Ok(Children);
        }

        // PUT: /Child/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChild(int id, Child Child)
        {
            if (id != Child.ChildId)
            {
                return BadRequest();
            }

            _unitOfWork.Children.Update(Child);


            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await ChildExists(id))
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

        // POST: /Children
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Child>> PostChild(Child Child)
        {
            await _unitOfWork.Children.Insert(Child);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetChild", new { id = Child.ChildId }, Child);
        }

        // DELETE: /Children/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChild(int id)
        {
            var Child = await _unitOfWork.Children.Get(q => q.ChildId == id);
            if (Child == null)
            {
                return NotFound();
            }

            await _unitOfWork.Children.Delete(id);
            await _unitOfWork.Save(HttpContext);


            return NoContent();
        }

        private async Task<bool> ChildExists(int id)
        {
            var Child = await _unitOfWork.Children.Get(q => q.ChildId == id);
            return Child != null;
        }
    }
}
