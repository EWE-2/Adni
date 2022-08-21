using Adni.Application.Dtos.User;
using Adni.Domain.Entities;
using System;

namespace Adni.Application.Common.Interfaces
{
    public interface IUserService
    {
        AuthenticateResponse Authenticate(AuthenticateRequest model);
        Employee GetById(Guid id);
    }
}
