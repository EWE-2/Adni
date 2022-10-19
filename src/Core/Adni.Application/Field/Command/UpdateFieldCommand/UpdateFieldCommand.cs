using Adni.Application.Common.Exceptions;
using Adni.Application.Common.Interfaces;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Adni.Application.Field.Command.UpdateFieldCommand
{
    public class UpdateFieldCommand : IRequest
    {
        public Guid FieldId { get; set; }
        public Guid DepartmentId { get; set; }
        public string FieldName { get; set; }
        public string FieldDescription { get; set; }
        public string FieldCigle { get; set; }
    }

    public class UpdateFieldCommandHandler : IRequestHandler<UpdateFieldCommand>
    {
        private readonly IApplicationDbContext _context;

        public UpdateFieldCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateFieldCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.fields.FindAsync(request.FieldId);

            if (entity == null)
                throw new NotFoundException(nameof(Field), request.FieldId);

            entity.FieldCigle = request.FieldCigle;
            entity.FieldDescription = request.FieldDescription;
            entity.FieldName = request.FieldName;
            entity.DepartmentId = request.DepartmentId;

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
