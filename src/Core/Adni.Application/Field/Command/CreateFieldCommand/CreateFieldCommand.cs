using Adni.Application.Common.Interfaces;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Adni.Application.Field.Command.CreateFieldCommand
{
    public class CreateFieldCommand : IRequest<Guid>
    {
        public Guid DepartmentId { get; set; }
        public string FieldName { get; set; }
        public string FieldDescription { get; set; }
        public string FieldCigle { get; set; }
    }

    public class CreateFieldCommandHandler : IRequestHandler<CreateFieldCommand, Guid>
    {
        private readonly IApplicationDbContext _context;

        public CreateFieldCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CreateFieldCommand request, CancellationToken cancellationToken)
        {
            var entity = new Domain.Entities.Field
            {
                DepartmentId = request.DepartmentId,
                FieldName = request.FieldName,
                FieldDescription = request.FieldDescription,
                FieldCigle = request.FieldCigle.ToUpper()
            };

            _context.fields.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);

            return entity.FieldId;
        }
    }
}
