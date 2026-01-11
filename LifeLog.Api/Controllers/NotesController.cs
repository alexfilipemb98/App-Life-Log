using LifeLog.Data.DBs.Interfaces;
using LifeLog.Data.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LifeLog.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class NotesController : ControllerBase
{
	private readonly INotesDB _notes;

    public NotesController(INotesDB notes)
    {
        _notes = notes;
    }

    // GET api/notes/
    [HttpGet]
	public async Task<ActionResult<NotesDTO>> Get()
	{
		(List<NotesDTO?>? notes, string message) = await _notes.GetAll();
		return notes is null ? NotFound() : Ok(notes);
	}

	// GET api/notes/{id}
	[HttpGet("{id:guid}")]
	public async Task<ActionResult<NotesDTO>> Get(Guid id)
	{
		(NotesDTO? note, string message) = await _notes.GetByKey(id);

		return note is null ? NotFound() : Ok(note);
	}
}
