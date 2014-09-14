
using InmNow.API.ActionResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace InmNow.API.Controllers
{
    public class BaseController : ApiController
    {

        public ViewModelActionResult BuildViewModel<TDestination>(HttpRequestMessage request, params object[] domainSources)
        {
            return new ViewModelActionResult(typeof(TDestination), request, domainSources);
        }

    }
}