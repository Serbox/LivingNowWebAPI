// Elimina los using innecesarios
using LivingNowWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LivingNowWebAPI.Controllers
{

    #region usuarios
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly LivingNowContext _context;

        public UsuariosController(LivingNowContext context)
        {
            _context = context;
        }

        // GET: api/Usuarios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuario>>> GetUsuarios()
        {
            return await _context.Usuarios.ToListAsync();
        }

        //login 
        [HttpGet("{nombreUsuario},{contraseña}")]
        public async Task<ActionResult<Usuario>> GetLogin(string nombreUsuario, string contraseña)
        {

            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(u => u.nombre == nombreUsuario);


            if (usuario == null)
            {
                return NotFound("Usuario no encontrado.");
            }


            if (usuario.contraseña != contraseña)
            {
                return Unauthorized("Contraseña incorrecta.");
            }


            return Ok(usuario);
        }



        // GET: api/Usuarios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Usuario>> GetUsuario(int id)
        {
            var usuario = await _context.Usuarios.FindAsync(id);

            if (usuario == null)
            {
                return NotFound();
            }

            return usuario;
        }

        // POST: api/Usuarios
        [HttpPost]
        public async Task<ActionResult<Usuario>> PostUsuario(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetUsuario), new { id = usuario.idUsuario }, usuario);
        }

        // PUT: api/Usuarios/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUsuario(int id, Usuario usuario)
        {
            if (id != usuario.idUsuario)
            {
                return BadRequest();
            }

            _context.Entry(usuario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsuarioExists(id))
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

        private bool UsuarioExists(int id)
        {
            return _context.Usuarios.Any(e => e.idUsuario == id);
        }

        // DELETE: api/Usuarios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUsuario(int id)
        {
            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }

            _context.Usuarios.Remove(usuario);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
    #endregion

    #region Tipo Accion
    [Route("api/[controller]")]
    [ApiController]
    public class TipoAccionController : ControllerBase
    {
        private readonly LivingNowContext _context;

        public TipoAccionController(LivingNowContext context)
        {
            _context = context;
        }

        // GET: api/TipoAccion
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoAccion>>> GetTipoAcciones()
        {
            return await _context.TiposAccion.ToListAsync();
        }

        // GET: api/TipoAccion/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TipoAccion>> GetTipoAccion(int id)
        {
            var accion = await _context.TiposAccion.FindAsync(id);
            if (accion == null)
            {
                return NotFound();
            }
            return accion;
        }

        // POST: api/TipoAccion
        [HttpPost]
        public async Task<ActionResult<TipoAccion>> PostTipoAccion(TipoAccion tipoAccion)
        {
            _context.TiposAccion.Add(tipoAccion);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTipoAccion), new { id = tipoAccion.idTipoAccion }, tipoAccion);
        }

        // PUT: api/TipoAccion/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTipoAccion(int id, TipoAccion tipoAccion)
        {
            if (id != tipoAccion.idTipoAccion)
            {
                return BadRequest();
            }

            _context.Entry(tipoAccion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipoAccionExists(id))
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

        private bool TipoAccionExists(int id)
        {
            return _context.TiposAccion.Any(e => e.idTipoAccion == id);
        }

        // DELETE: api/TipoAccion/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTipoAccion(int id)
        {
            var tipoAccion = await _context.TiposAccion.FindAsync(id);
            if (tipoAccion == null)
            {
                return NotFound();
            }

            _context.TiposAccion.Remove(tipoAccion);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }

    #endregion

    #region rol

    [Route("api/[controller]")]
    [ApiController]
    public class RolController : ControllerBase
    {
        private readonly LivingNowContext _context;

        public RolController(LivingNowContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Rol>>> GetRoles()
        {
            return await _context.Roles.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Rol>> GetRol(int id)
        {
            var rol = await _context.Roles.FindAsync(id);
            if (rol == null)
            {
                return NotFound();
            }

            return rol;
        }

        [HttpPost]
        public async Task<ActionResult<Rol>> PostRol(Rol rol)
        {
            _context.Roles.Add(rol);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetRol), new { id = rol.idRol }, rol);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutRol(int id, Rol rol)
        {
            if (id != rol.idRol)
            {
                return BadRequest();
            }

            _context.Entry(rol).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RolExists(id))
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

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRol(int id)
        {
            var rol = await _context.Roles.FindAsync(id);
            if (rol == null)
            {
                return NotFound();
            }

            _context.Roles.Remove(rol);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RolExists(int id)
        {
            return _context.Roles.Any(e => e.idRol == id);
        }
    }

    #endregion

    #region Propiedad
    [Route("api/[controller]")]
    [ApiController]
    public class PropiedadController : ControllerBase
    {
        private readonly LivingNowContext _context;

        public PropiedadController(LivingNowContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Propiedad>>> GetPropiedades()
        {
            return await _context.Propiedades.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Propiedad>> GetPropiedad(int id)
        {
            var propiedad = await _context.Propiedades.FindAsync(id);
            if (propiedad == null)
            {
                return NotFound();
            }

            return propiedad;
        }

        [HttpPost]
        public async Task<ActionResult<Propiedad>> PostPropiedad(Propiedad propiedad)
        {
            _context.Propiedades.Add(propiedad);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPropiedad), new { id = propiedad.idPropiedad }, propiedad);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutPropiedad(int id, Propiedad propiedad)
        {
            if (id != propiedad.idPropiedad)
            {
                return BadRequest();
            }

            _context.Entry(propiedad).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PropiedadExists(id))
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

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePropiedad(int id)
        {
            var propiedad = await _context.Propiedades.FindAsync(id);
            if (propiedad == null)
            {
                return NotFound();
            }

            _context.Propiedades.Remove(propiedad);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PropiedadExists(int id)
        {
            return _context.Propiedades.Any(e => e.idPropiedad == id);
        }
    }
    #endregion

    #region Permisos

    [Route("api/[controller]")]
    [ApiController]
    public class PermisoController : ControllerBase
    {
        private readonly LivingNowContext _context;

        public PermisoController(LivingNowContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Permiso>>> GetPermisos()
        {
            return await _context.Permisos.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Permiso>> GetPermiso(int id)
        {
            var permiso = await _context.Permisos.FindAsync(id);
            if (permiso == null)
            {
                return NotFound();
            }

            return permiso;
        }

        [HttpPost]
        public async Task<ActionResult<Permiso>> PostPermiso(Permiso permiso)
        {
            _context.Permisos.Add(permiso);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPermiso), new { id = permiso.idPermiso }, permiso);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutPermiso(int id, Permiso permiso)
        {
            if (id != permiso.idPermiso)
            {
                return BadRequest();
            }

            _context.Entry(permiso).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PermisoExists(id))
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

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePermiso(int id)
        {
            var permiso = await _context.Permisos.FindAsync(id);
            if (permiso == null)
            {
                return NotFound();
            }

            _context.Permisos.Remove(permiso);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PermisoExists(int id)
        {
            return _context.Permisos.Any(e => e.idPermiso == id);
        }
    }

    #endregion

    #region Localidad

    [Route("api/[controller]")]
    [ApiController]
    public class LocalidadController : ControllerBase
    {
        private readonly LivingNowContext _context;

        public LocalidadController(LivingNowContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Localidad>>> GetLocalidades()
        {
            return await _context.Localidades.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Localidad>> GetLocalidad(int id)
        {
            var localidad = await _context.Localidades.FindAsync(id);
            if (localidad == null)
            {
                return NotFound();
            }

            return localidad;
        }

        [HttpPost]
        public async Task<ActionResult<Localidad>> PostLocalidad(Localidad localidad)
        {
            _context.Localidades.Add(localidad);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetLocalidad), new { id = localidad.idLocalidad }, localidad);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutLocalidad(int id, Localidad localidad)
        {
            if (id != localidad.idLocalidad)
            {
                return BadRequest();
            }

            _context.Entry(localidad).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LocalidadExists(id))
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

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLocalidad(int id)
        {
            var localidad = await _context.Localidades.FindAsync(id);
            if (localidad == null)
            {
                return NotFound();
            }

            _context.Localidades.Remove(localidad);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LocalidadExists(int id)
        {
            return _context.Localidades.Any(e => e.idLocalidad == id);
        }
    }

    #endregion

    #region Departamento

    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentoController : ControllerBase
    {
        private readonly LivingNowContext _context;

        public DepartamentoController(LivingNowContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Departamento>>> GetDepartamentos()
        {
            return await _context.Departamentos.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Departamento>> GetDepartamento(int id)
        {
            var departamento = await _context.Departamentos.FindAsync(id);
            if (departamento == null)
            {
                return NotFound();
            }

            return departamento;
        }

        [HttpPost]
        public async Task<ActionResult<Departamento>> PostDepartamento(Departamento departamento)
        {
            _context.Departamentos.Add(departamento);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetDepartamento), new { id = departamento.idDepartamento }, departamento);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutDepartamento(int id, Departamento departamento)
        {
            if (id != departamento.idDepartamento)
            {
                return BadRequest();
            }

            _context.Entry(departamento).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DepartamentoExists(id))
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

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDepartamento(int id)
        {
            var departamento = await _context.Departamentos.FindAsync(id);
            if (departamento == null)
            {
                return NotFound();
            }

            _context.Departamentos.Remove(departamento);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DepartamentoExists(int id)
        {
            return _context.Departamentos.Any(e => e.idDepartamento == id);
        }
    }

    #endregion

    #region Ciudad

    [Route("api/[controller]")]
    [ApiController]
    public class CiudadController : ControllerBase
    {
        private readonly LivingNowContext _context;

        public CiudadController(LivingNowContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ciudad>>> GetCiudades()
        {
            return await _context.Ciudades.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Ciudad>> GetCiudad(int id)
        {
            var ciudad = await _context.Ciudades.FindAsync(id);
            if (ciudad == null)
            {
                return NotFound();
            }

            return ciudad;
        }

        [HttpPost]
        public async Task<ActionResult<Ciudad>> PostCiudad(Ciudad ciudad)
        {
            _context.Ciudades.Add(ciudad);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCiudad), new { id = ciudad.idCiudad }, ciudad);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCiudad(int id, Ciudad ciudad)
        {
            if (id != ciudad.idCiudad)
            {
                return BadRequest();
            }

            _context.Entry(ciudad).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CiudadExists(id))
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

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCiudad(int id)
        {
            var ciudad = await _context.Ciudades.FindAsync(id);
            if (ciudad == null)
            {
                return NotFound();
            }

            _context.Ciudades.Remove(ciudad);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CiudadExists(int id)
        {
            return _context.Ciudades.Any(e => e.idCiudad == id);
        }
    }
    #endregion

    #region Barrio

    [Route("api/[controller]")]
    [ApiController]
    public class BarrioController : ControllerBase
    {
        private readonly LivingNowContext _context;

        public BarrioController(LivingNowContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Barrio>>> GetBarrios()
        {
            return await _context.Barrios.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Barrio>> GetBarrio(int id)
        {
            var barrio = await _context.Barrios.FindAsync(id);
            if (barrio == null)
            {
                return NotFound();
            }

            return barrio;
        }

        [HttpPost]
        public async Task<ActionResult<Barrio>> PostBarrio(Barrio barrio)
        {
            _context.Barrios.Add(barrio);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetBarrio), new { id = barrio.idBarrio }, barrio);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutBarrio(int id, Barrio barrio)
        {
            if (id != barrio.idBarrio)
            {
                return BadRequest();
            }

            _context.Entry(barrio).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BarrioExists(id))
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

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBarrio(int id)
        {
            var barrio = await _context.Barrios.FindAsync(id);
            if (barrio == null)
            {
                return NotFound();
            }

            _context.Barrios.Remove(barrio);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BarrioExists(int id)
        {
            return _context.Barrios.Any(e => e.idBarrio == id);
        }
    }
    #endregion

    #region Accion Venta
    [Route("api/[controller]")]
    [ApiController]
    public class AccionVentaController : ControllerBase
    {
        private readonly LivingNowContext _context;

        public AccionVentaController(LivingNowContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AccionVenta>>> GetAccionesVenta()
        {
            return await _context.AccionesVenta.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AccionVenta>> GetAccionVenta(int id)
        {
            var accionVenta = await _context.AccionesVenta.FindAsync(id);
            if (accionVenta == null)
            {
                return NotFound();
            }

            return accionVenta;
        }

        [HttpPost]
        public async Task<ActionResult<AccionVenta>> PostAccionVenta(AccionVenta accionVenta)
        {
            _context.AccionesVenta.Add(accionVenta);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAccionVenta), new { id = accionVenta.idAccionVenta }, accionVenta);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAccionVenta(int id, AccionVenta accionVenta)
        {
            if (id != accionVenta.idAccionVenta)
            {
                return BadRequest();
            }

            _context.Entry(accionVenta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AccionVentaExists(id))
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

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAccionVenta(int id)
        {
            var accionVenta = await _context.AccionesVenta.FindAsync(id);
            if (accionVenta == null)
            {
                return NotFound();
            }

            _context.AccionesVenta.Remove(accionVenta);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AccionVentaExists(int id)
        {
            return _context.AccionesVenta.Any(e => e.idAccionVenta == id);
        }
    }

    #endregion

}
