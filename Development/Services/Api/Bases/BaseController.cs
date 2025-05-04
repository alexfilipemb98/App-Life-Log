using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Api.Bases
{
   public class BaseController : ApiController
    {
        internal readonly Data.Engine _engine;
        public BaseController()
        {
            _engine = Engine._engine;
        }
    }
}
