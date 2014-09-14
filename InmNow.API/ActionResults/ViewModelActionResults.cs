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
using InmNow.API.ViewModels;
using System.Collections;
using System.Net.Http.Headers;

namespace InmNow.API.ActionResults
{

    public class ViewModelActionResult : IHttpActionResult
    {
        public Type DestinationType { get; private set; }
        readonly object[] DomainSources;
        private readonly HttpRequestMessage _request;

        public ViewModelActionResult(Type destinationType, HttpRequestMessage request, params object[] domainSources)
        {
            DomainSources = domainSources;
            DestinationType = destinationType;
            _request = request;
        }

        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            try
            {
                var sourceQueue = new Queue(DomainSources);
                var initialSource = sourceQueue.Dequeue();
                Type sourceType = initialSource.GetType();

                var compositeViewModel = Mapper.Map(initialSource, sourceType, DestinationType);


                while (sourceQueue.Count > 0)
                {
                    var source = sourceQueue.Dequeue();
                    Mapper.Map(source, compositeViewModel, source.GetType(), DestinationType);
                }

                //  GlobalConfiguration.Configuration.Formatters
                var formatter = new JsonMediaTypeFormatter();
                formatter.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.Objects;
                formatter.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;

                var response = new HttpResponseMessage()
                {
                    Content = new ObjectContent(compositeViewModel.GetType(), compositeViewModel, formatter,
                            new MediaTypeWithQualityHeaderValue("application/json")),
                    RequestMessage = _request
                };

                return Task.FromResult(response);
            }
            catch (Exception ex)
            {
                return Task.FromResult(new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest));
            }
        }
    }
}