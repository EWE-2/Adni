using Adni.Application.Dtos.Email;
using System.Threading.Tasks;

namespace Adni.Application.Common.Interfaces
{
    public interface IEmailService
    {
        Task SendAsync(EmailDto emailRequest);
    }
}