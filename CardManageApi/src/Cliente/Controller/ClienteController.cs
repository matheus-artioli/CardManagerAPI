using CardManageApi.Cliente.Service;
using Microsoft.AspNetCore.Mvc;

namespace CardManageApi.Cliente.Controller;

[ApiController]
[Route("api/[controller]")]
public class ClienteController : ControllerBase
{

    private readonly ClienteService _clienteService;

    public ClienteController(ClienteService clienteService)
    {
        _clienteService = clienteService;
    }

    [HttpPost("Create")]
    public IActionResult CreateCliente([FromBody] ClienteDto cliente)
    {
        try{
            _clienteService.Validate(cliente);

            _clienteService.Create(cliente);
            return Ok(new { Message = "Cliente created successfully", Cliente = cliente });
        }
        catch (ArgumentException ex)
        {
            return BadRequest(new { Message = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { Message = "An error occurred while creating the cliente", Error = ex.Message });
        }
    }
}