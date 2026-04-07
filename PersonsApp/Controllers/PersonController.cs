using Microsoft.AspNetCore.Mvc;
using PersonsApp.Dtos.Persons;
using PersonsApp.Services.Persons;

namespace PersonsApp.Controllers
{
    [Route("api/person")] //Lo que coloquemos aquí tiene que ser // esto es una decoración
    [ApiController] //La instancia es un controlador 
    public class PersonController : ControllerBase //Los dos puntos indica que va a heredar  todos los atributos de ControllerBase
    {
        /*El método se usa cuando se crea un objeto nuevo*/
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService) //ctor método constructor 
        {
            _personService = personService;
        }
            [HttpGet]
            public async Task<ActionResult> GetPage(string searchTerm = "",int page = 1, int pageSize = 10 )
        {
            var response = await _personService.GetPageAsync(searchTerm,page,pageSize);
            return StatusCode(response.StatusCode,response);

        }
            [HttpGet("{id}")]// Se usa Get porque solo voy a hacer una lectura de  // si quiero agregar mas parametros solo pongo pleca
            public async Task<ActionResult> GetOne(string id)
            {
                var result = await _personService.GetOneByIdAsync(id);
                

                //return person !=null ? Ok(person) : NotFound(new {Message = "Persona no encontrada."});
                return StatusCode(result.StatusCode, result);
            }
            [HttpPost]
            public async Task<ActionResult> Create(PersonCreateDto dto)
            {
                var result = await _personService.CreateAsync(dto);

                return StatusCode(result.StatusCode, result);
                
            }
            [HttpPut("{id}")]
            public async Task<ActionResult> Update(string id,PersonEditDto dto)
            {
                var result = await _personService.EditAsync(id, dto);
                return StatusCode(result.StatusCode, result);
            }
            [HttpDelete("{id}")]
            public async Task<ActionResult> Delete(string id)
        {
            var result = await _personService.DeleteAsync(id);
            return StatusCode(result.StatusCode,result);
        }
    }
}