using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization.Infrastructure;

namespace A_DOT_NET.models;

public class Person{ 
    [Required]
    [EmailAddress]
    public string? Email {get;set;}
    [Required]
    [DataType(DataType.Password)]
    public string? Password{get;set;}

    [Display(Name="Remember me")]
    public bool RememberMe{get;set;}
}