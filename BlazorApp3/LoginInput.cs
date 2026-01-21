using System.ComponentModel.DataAnnotations;

namespace BlazorApp3;

public class LoginInput
{
    [Required]
    public string Username { get; set; } = string.Empty;
    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; } = string.Empty;
    public bool UseLdap { get; set; }
    public bool RememberMe { get; set; }
}
