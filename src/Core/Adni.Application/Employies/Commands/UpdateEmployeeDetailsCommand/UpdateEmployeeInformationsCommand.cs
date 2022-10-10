using Adni.Application.Common.Interfaces;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Adni.Application.Employies.Commands.UpdateEmployeeDetailsCommand;

public class UpdateEmployeeInformationsCommand : IRequest
{
    //Identity user informations
    public Guid EmployeeId { get; set; }
    public string? UserName { get; set; }
    public string Email { get; set; }
    public string NormalizedEmail { get; set; }
    public string PasswordHash { get; set; }

    //User self information
    public string Firstname { get; set; }
    public string? Lastname { get; set; }
    public char Gender { get; set; }
    public string? PhoneNumber { get; set; }
    public string? WhatsappNumber { get; set; }
    public string? Dob { get; set; }
    public string? UserLocation { get; set; }

    public string? ImageDirectory { get; set; }

    public bool IsOnline { get; set; }
    public string Role { get; set; }

}

public class UpdateEmployeeInformationsCommandHandler : IRequestHandler<UpdateEmployeeInformationsCommand>
{
    private IApplicationDbContext _context;

    public UpdateEmployeeInformationsCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Unit> Handle(UpdateEmployeeInformationsCommand request, CancellationToken cancellationToken)
    {
        var emplEntity = await _context.employees.FindAsync(request.EmployeeId);

        emplEntity.UserName = request.UserName;
        emplEntity.Email = request.Email;
        emplEntity.NormalizedEmail = request.NormalizedEmail;
        emplEntity.PasswordHash = request.PasswordHash;
        //User se = request.EmployeeId;
        emplEntity.Firstname = request.Firstname;
        emplEntity.Lastname = request.Lastname;
        emplEntity.Gender = request.Gender;
        emplEntity.PhoneNumber = request.PhoneNumber;
        emplEntity.WhatsappNumber = request.WhatsappNumber;
        emplEntity.Dob = request.Dob;
        emplEntity.UserLocation = request.UserLocation;;
        emplEntity.ImageDirectory = request.ImageDirectory;;
        emplEntity.IsOnline = false;
        emplEntity.Role = request.Role;

        await _context.SaveChangesAsync(cancellationToken);

        return Unit.Value;

    }
}
