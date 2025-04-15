using Microsoft.AspNetCore.Mvc;

namespace Api.Bases
{
    /// <summary>
    /// Base controller for all controllers
    /// </summary>
    [ApiController]
    public class BaseController : ControllerBase
    {
        internal readonly Data.Engine _engine;

        public BaseController()
        {
            _engine = Engine._engine;
        }
    }
}
