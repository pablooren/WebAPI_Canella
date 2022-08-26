using Microsoft.EntityFrameworkCore;

using webapi.Models;

namespace webapi;

public class VehiculosContext: DbContext
{
    public DbSet<Vehiculos> Vehiculo {get; set;}

    public VehiculosContext(DbContextOptions<VehiculosContext> options) :base(options) { }
    

}