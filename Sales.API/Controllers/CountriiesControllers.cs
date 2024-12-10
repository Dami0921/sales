using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sales.API.Data;
using Sales.Shared.Entities;

namespace Sales.API.Controllers
{
    // cacteristicas de un controlador  
    [ApiController]
    [Route("api/countries")]
    public class CountriiesControllers : ControllerBase
    {
        private readonly DataContext _context;

        // context es toda la base de datos, abajo esta el constructor.
        public CountriiesControllers(DataContext context)
        {
            _context = context;
        }

        // obtener registros por medio de http : Get

        [HttpGet]

        public async Task< ActionResult> GetAsync()
        {
            return Ok(await _context.countries.ToListAsync());
        }

        // insertar registros por medio de protocolo http : post

        [HttpPost]

        public async Task<ActionResult> PostAsync(Country country)
        {
            _context.Add(country);
            await _context.SaveChangesAsync();
            return Ok(country);
        }

    }
}
