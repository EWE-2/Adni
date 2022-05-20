using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Adni.Application.Common.Behaviors
{
    internal class UnhandledExeptionBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
        where TRequest: MediatR.IRequest<TResponse>
    {
        private readonly ILogger<TRequest> _logger;
        public UnhandledExeptionBehavior(ILogger<TRequest> logger)
        {
            _logger = logger;
        }
        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            try
            {
                return await next();
            }
            catch (Exception ex)
            {
                var requestName = typeof(TRequest).Name;
                _logger.LogError(ex, "Company Request: Unhandled Exception for Request {Name} {@Request}", requestName, request);
                throw;
            }
        }
    }
}
