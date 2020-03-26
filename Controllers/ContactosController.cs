using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyecto_final_Crud.Data;
using Proyecto_final_Crud.Models;

namespace Proyecto_final_Crud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactosController : ControllerBase
    {
        private readonly ContactoContexto _context;

        public ContactosController(ContactoContexto contexto)
        {
            _context = contexto;
        }
        //get
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Contacto>>> GetContactoItems()
        {
            return await _context.ContactoItems.ToListAsync();
        }

        //get

        [HttpGet("{id}")]
        public async Task<ActionResult<Contacto>> GetContactoItem(int id) {

            var contactoItem = await _context.ContactoItems.FindAsync(id); 

            if (contactoItem == null) 
            { 
                return NotFound(); 
            }

            return contactoItem; 
        }

        //post
        [HttpPost]
        public async Task<ActionResult<Contacto>> PostContactoItem (Contacto item)
        {
            _context.ContactoItems.Add(item);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetContactoItem), new {id=item.Id},item);
        }

        //put

        [HttpPut("{id}")]
        public async Task<IActionResult> PutContactoItem(int id, Contacto item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            _context.Entry(item).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return NoContent();



        }

        //delete
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContactoItem(int id)
        {
            var contactoItem = await _context.ContactoItems.FindAsync(id);

            if (contactoItem == null)
            {
                return NotFound();
            }
            _context.ContactoItems.Remove(contactoItem);
            await _context.SaveChangesAsync();

            return NoContent();

        
        }


    }
}