using Microsoft.AspNetCore.Mvc;
using webapi.Models;
//using webapi.Services;

namespace webapi.Controllers;

[Route("api/[Controller]")]
public class VehiculosController : ControllerBase{
    IVehiculosService VehiculosService;

    public VehiculosController(IVehiculosService service){
        VehiculosService = service;

    }

    [HttpGet]
    public IActionResult Get(){
        return Ok(VehiculosService.Get());
    }

     [HttpPost]
    public IActionResult Post([FromBody] Vehiculos Vehiculos){
        VehiculosService.Save(Vehiculos);
        return Ok();

    }

    [HttpPut("{id}")]
    public IActionResult Put(Guid id,[FromBody] Vehiculos Vehiculos){
        VehiculosService.Update(id,Vehiculos);
        return Ok();

    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id){
        VehiculosService.Delete(id);
        return Ok();
    }
    


}