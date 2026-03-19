using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LifeLog.Services.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class NotesController : ControllerBase
{
    //private readonly INoteRepository _notes;

    //public NotesController(INoteRepository notes)
    //{
    //    _notes = notes;
    //}

    //// GET api/notes/
    //[HttpGet]
    //public async Task<ActionResult<Note>> Get()
    //{
    //    (List<Note?>? notes, string message) = await _notes.GetAll();
    //    return notes is null ? NotFound() : Ok(notes);
    //}

    //// GET api/notes/{id}
    //[HttpGet("{id:guid}")]
    //public async Task<ActionResult<Note>> Get(Guid id)
    //{
    //    (Note? note, string message) = await _notes.GetByKey(id);

    //    return note is null ? NotFound() : Ok(note);
    //}
}
