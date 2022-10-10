using System.ComponentModel.DataAnnotations;

namespace Adni.Application.Dtos.User;

public class AuthenticateRequest
{
    [Required(ErrorMessage="Le nom d'utilisateur est obligatoire")]
    public string UserName { get; set; }

    [Required(ErrorMessage = "Le mot de passe est obligatoire")]
    public string Password { get; set; }   
}
