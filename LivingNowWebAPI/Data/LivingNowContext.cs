using Microsoft.EntityFrameworkCore;
using System.Threading;
using LivingNowWebAPI.Models;

public class LivingNowContext : DbContext
{
    public LivingNowContext(DbContextOptions<LivingNowContext> options) : base(options) { }

    public DbSet<Departamento> Departamentos { get; set; }
    public DbSet<Ciudad> Ciudades { get; set; }
    public DbSet<Localidad> Localidades { get; set; }
    public DbSet<Barrio> Barrios { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Rol> Roles { get; set; }
    public DbSet<Permiso> Permisos { get; set; }
    public DbSet<TipoAccion> TiposAccion { get; set; }
    public DbSet<Propiedad> Propiedades { get; set; }
    public DbSet<AccionVenta> AccionesVenta { get; set; }
}
