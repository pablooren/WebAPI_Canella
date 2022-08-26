using webapi;
using webapi.Models;

public class VehiculosService : IVehiculosService 
{

VehiculosContext context;
    
    public VehiculosService(VehiculosContext dbcontext){
        context = dbcontext;

    }

    public IEnumerable<Vehiculos> Get(){
        return context.Vehiculo;

    }

    public async Task Save(Vehiculos Vehiculos){
        context.Add(Vehiculos);
        await context.SaveChangesAsync();

    }
    
    public async Task Update(Guid id, Vehiculos Vehiculos){
        var VehiculosActual = context.Vehiculo.Find(id);
        if(VehiculosActual !=null){
           

            await context.SaveChangesAsync();
        }        
        

    }

    public async Task Delete(Guid id){
        var VehiculosActual = context.Vehiculo.Find(id);
        if(VehiculosActual !=null){
            context.Remove(VehiculosActual);
            await context.SaveChangesAsync();
        }

}


}

public interface IVehiculosService
{
      Task Delete(Guid id);
      Task Update(Guid id, Vehiculos Vehiculos);

      Task Save(Vehiculos Vehiculos);
        IEnumerable<Vehiculos> Get();

}