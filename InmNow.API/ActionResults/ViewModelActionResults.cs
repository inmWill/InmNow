using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using AutoMapper;

namespace InmNow.API.ActionResults
{

    public class ViewModelActionResult : IHttpActionResult
    {
        public Type SourceType { get; private set; }
        public Type DestinationType { get; private set; }
        readonly object ModelObject;
        private readonly HttpRequestMessage _request;

        public ViewModelActionResult(Type sourceType, Type destinationType, object domainModel, HttpRequestMessage request)
        {
            SourceType = sourceType;
            DestinationType = destinationType;
            ModelObject = domainModel;
            _request = request;
        }
        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            var viewModel = Mapper.Map(ModelObject, SourceType, DestinationType);
            var response = new HttpResponseMessage()
            {
                //build viewmodel
                Content = new ObjectContent(viewModel.GetType(), viewModel, new JsonMediaTypeFormatter()),
                RequestMessage = _request
            };

            return Task.FromResult(response);
        }
    }
}