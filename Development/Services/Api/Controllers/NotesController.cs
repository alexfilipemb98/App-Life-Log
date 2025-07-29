using Api.Bases;
using Data.ORM.DataModelCode;
using Swashbuckle.Swagger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Api.Controllers
{
    /// <summary>
    /// Notes controller
    /// </summary>
    [RoutePrefix("notes")]
    public class NotesController : BaseController
    {

        #region GET'S

        /// <summary>
        /// Gets all notes
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            try
            {
                List<ORM_Notes> results = _engine.Notes.GetAll(out _);
                return Content(HttpStatusCode.OK, results);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, new { Error = ex.ToString() });
            }
        }

        /// <summary>
        /// Resturns a note by it's key
        /// </summary>
        /// <param name="id">ID da região</param>
        [HttpGet]
        [Route("{id:guid}")]
        public IHttpActionResult GetById(Guid id)
        {
            try
            {
                ORM_Notes result = _engine.Notes.GetByKey(id, out _);
                return Content(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, new { Error = ex.ToString() });
            }
        }

        #endregion
    }
}
