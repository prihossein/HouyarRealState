using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using MediatR;
using Microsoft.Extensions.Logging;

namespace HouyarRealState.Application.Behaviours
{
    public class LogginBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
    {
        private readonly ILogger<LogginBehaviour<TRequest, TResponse>> _logger;
        public LogginBehaviour(ILogger<LogginBehaviour<TRequest, TResponse>> logger)
        {
            _logger = logger;
        }

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            _logger.LogInformation($"Handling {typeof(TRequest).Name}");
            Type myType = request.GetType();
            IList<PropertyInfo> props = new List<PropertyInfo>(myType.GetProperties());
            foreach (PropertyInfo prop in props)
            {
                object probValue = prop.GetValue(request, null);
                _logger.LogInformation($"Property: {prop.Name}, {probValue}");
            }

            var response = await next();
            _logger.LogInformation($"Handled {typeof(TRequest).Name}");

            return response;
        }
    }
}
