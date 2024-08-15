using System;
using System.ComponentModel.DataAnnotations;

namespace API.DTOs;

public class LoginDto
{
    [Required]
    [MinLength(4)]
    public required string Username { get; set; }
    [Required]
    public required string Password { get; set; }
}
