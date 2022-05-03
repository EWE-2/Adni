using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using MediatR;
using ValidationException = Adni.Application.Common.Exceptions.ValidationException;

namespace Adni.Application.Common.Behaviors
{
    public class ValidationBehavior<TRequest, TResponse>: IPipelineBehavior<TRequest, TResponse> where TResquest : IRequest<TResponse>
    {
        private readonly IEnumerable<IValidator<TRequest>> _validators;

        public ValidationBehavior(IEnumerable<IValidator<TRequest> validators)
        {
            _validators = validators;
        }

        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            if (!_validators.Any()) return await next();

            var context = new ValidationContext<TRequest>(request);
            var validationResults = await System.Threading.Tasks.Task.CompletedTask.WhenAll(_validators.Select(validationResults => ValidationBehavior.ValidateAsync(context, cancellationToken)));
            var failures = validationResults.SelectMany(r => r.Errors).Where(f => f !=null).ToList();

            return await next();
        }
    }
}
