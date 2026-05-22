using Microsoft.AspNetCore.Mvc;
using Tutorial_5.DTO;
using Tutorial_5.Services;


namespace Tutorial_5.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PcsController : ControllerBase
{
    private readonly IDbService _service;

    public PcsController(IDbService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var pcs = await _service.GetPcsAsync();
        return Ok(pcs);
    }

    [HttpGet("{id:int}/components")]
    public async Task<IActionResult> GetComponentsAsync(int id)
    {
        var componentes = await _service.GetPcComponents(id);
        if (componentes == null)
        {
            return NotFound("pc not found with id "+ id);
        }

        return Ok(componentes);
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] PcCreate dto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var created = await _service.CreatePcAsync(dto);
        return CreatedAtAction(nameof(GetAll), new { id = created.Id }, created);
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var deleted = await  _service.DeletePcAsync(id);
        if (!deleted)
        {
            return NotFound("pc not found with id "+ id);
        }
        return NoContent();
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> Update(int id, [FromBody] PcUpdate dto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var updated = await _service.UpdatePcAsync(id, dto);
        if (updated == null)
        {
            return NotFound("pc with this id doesnr exist:" + id);
        }

        return Ok(updated);
    }
    
}
