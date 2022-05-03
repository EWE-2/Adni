using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Adni.Application.Common.Exceptions
{
    public class ValidationException: Exception
    {
        public ValidationException(): base("One or more validation failures have occured.")
        {
            errors = new Dictionary<string, string[]>();
        }

        public ValidationException(IEnumerable<ValidationFailure> failures): this()
        {
            var failuresGroups = failures
                .GroupBy(e => e.PropertyName, e => e.ErroMessage);

            foreach (var failureGroup in failuresGroups)
            {
                var PropertyName = failureGroup.Key;
                var propertyFailures = failureGroup.ToArray();

                Errors.Add(propertyName, propertyFailures);
            }
        }

        public IDictionary<string, string[]> Errors{get;}
    }
}