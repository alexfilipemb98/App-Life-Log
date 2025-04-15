using Api.Bases;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Api.Controllers
{
    /// <summary>
    /// Notes controller
    /// </summary>
    [ApiController]
    [Route("notes")]
    public class NotesController : BaseController
    {
        #region GET'S

        /// <summary>
        /// Gets all notes
        /// </summary>
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                List<Data.ORM.DataModelCode.ORM_Notes> results = _engine.Notes.GetAll(out _);
                return Ok(results);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, new { Error = ex.ToString() });
            }
        }

        /// <summary>
        /// Returns a note by its key
        /// </summary>
        /// <param name="id">Note ID</param>
        [HttpGet("{id:guid}")]
        public IActionResult GetById(Guid id)
        {
            try
            {
                Data.ORM.DataModelCode.ORM_Notes result = _engine.Notes.GetByKey(id, out _);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, new { Error = ex.ToString() });
            }
        }

        #endregion
    }
}
