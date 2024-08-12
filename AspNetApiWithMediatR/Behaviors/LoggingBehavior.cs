using FluentResults;
using MediatR;

namespace AspNetApiWithMediatR.Behaviors
{
    public class LoggingBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
        where TRequest : IRequest<TResponse>
        where TResponse : ResultBase
    {
        private readonly ILogger<LoggingBehavior<TRequest, TResponse>> _logger;

        public LoggingBehavior(ILogger<LoggingBehavior<TRequest, TResponse>> logger)
        {
            _logger = logger;
        }
        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Starting request {@RequestName} at time {@DateTimeUtc}", typeof(TRequest).Name, DateTime.UtcNow);
            var result = await next();
            if (result.IsFailed)
            {
                _logger.LogWarning("Errors in {@RequestName}, [{@Errors}]",typeof(TRequest).Name, result.Errors.Select(e => e.Message));
            }
            return result;
        }
    }
}
