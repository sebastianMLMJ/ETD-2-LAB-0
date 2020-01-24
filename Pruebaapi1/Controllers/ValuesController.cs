using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Pruebaapi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        /*Nombres: Edgar Sebastian Milian Mejia carnet 1161918
                   Alejandra Samayoa 1278817
          
         Alejandra no tiene commit porque mi otra pareja anterior me cambio 
         a ultimo momento.
                
         Si utilizando postman el metodo post no realiza nada 
         desactivar la autentificacion sll en la configuracion
         de postman, si usa talend api tester no deberi aproducir
         problema
             */

        static Pila<Movie> NuevaPila = new Pila<Movie>();
        
        // GET api/values
        [HttpGet]
        public Pila<Movie> Get()
        {
            return  NuevaPila;
        }

        // POST api/values
        [HttpPost]
        public void Post(Movie nueva)
        {
            NuevaPila.Insertar(nueva);
        }

        

        
    }
}
