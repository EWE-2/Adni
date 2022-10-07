using System;

namespace Adni.Application.Dtos.User;

public class AuthenticateResponse
{
    /// <summary>
    /// Identifiant de l'utilisateur
    /// </summary>
    public Guid Id { get; set; }
    /// <summary>
    /// Nom de l'utilisateur
    /// </summary>
    public string Firstname { get; set; }
    /// <summary>
    /// Prenom de l'utilisateur
    /// </summary>
    public string Lastname { get; set; }
    /// <summary>
    /// nom d'utlisateur
    /// </summary>
    public string Username { get; set; }
    /// <summary>
    /// TRUE si est un success, FALSE sinon
    /// </summary>
    public bool Success { get; set; }
    /// <summary>
    /// Message de connexion
    /// </summary>
    public string Message { get; set; }
    /// <summary>
    /// Le token si la connexion s'est effcetue avec succes ou Null si non
    /// </summary>
    public string? Token { get; set; }

    
    public AuthenticateResponse(Adni.Domain.Entities.Employee user, string token)
    {
        Id = user.UserId;
        Firstname = user.Firstname;
        Lastname = user.Lastname;
        Username = user.UserName;
        Token = token;
    }
}
