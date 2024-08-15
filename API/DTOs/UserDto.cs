using System;
using System.ComponentModel.DataAnnotations;

namespace API.DTOs;

public class UserDto
{
    [Required]
    [MinLength(4)]
    public required string Username { get; set; }
    [Required]
    public required string Token { get; set; }
}
