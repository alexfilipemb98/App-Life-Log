using LifeLog.Base.Infrastructure.Interfaces;
using LifeLog.Data.Database.Queries;
using LifeLog.Data.Models;
using LifeLog.Services.Api.Bases;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;

namespace LifeLog.Services.Api.Controllers
{
	/// <summary>
	/// Notes controller
	/// </summary>
	[RoutePrefix("notes")]
	public class NotesController : BaseController, IDisposable
	{
		//PRIVATE
		private INotesQuery<NotesModel, Guid> _Data;

		/// <summary>
		/// Constructor
		/// </summary>
		public NotesController(INotesQuery<NotesModel, Guid> data)
		{
			_Data = data ?? throw new ArgumentNullException(nameof(data));
		}

		#region GET'S

		/// <summary>
		/// Gets all notes
		/// </summary>
		/// <returns></returns>
		[HttpGet]
		public async Task<IHttpActionResult> GetAll()
		{
			try
			{
				(List<NotesModel> results, string message) = await _Data.GetAll();
				return Content(HttpStatusCode.OK, new { results, message });
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
		public async Task<IHttpActionResult> GetById(Guid id)
		{
			try
			{
				//NotesModel result = await Notes.GetByKey(id);
				return Content(HttpStatusCode.OK, new { });
			}
			catch (Exception ex)
			{
				return Content(HttpStatusCode.InternalServerError, new { Error = ex.ToString() });
			}
		}

		#endregion

		#region FUNCTIONS

		/// <summary>
		/// Dispose 
		/// </summary>
		/// <param name="disposing"></param>
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		#endregion
	}
}
