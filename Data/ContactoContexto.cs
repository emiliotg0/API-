using Microsoft.EntityFrameworkCore;
using Proyecto_final_Crud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_final_Crud.Data
{
    public class ContactoContexto : DbContext
    {
        public ContactoContexto(DbContextOptions<ContactoContexto> options):base(options)
        {

        }

        public DbSet<Contacto> ContactoItems { get; set; }
    }
}
