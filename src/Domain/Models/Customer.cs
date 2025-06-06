using System.ComponentModel.DataAnnotations;

namespace Domain.Models;

public class Customer : BaseEntity
{
    [Required]
    [MinLength(3)]
    [MaxLength(10)]
    public required string Name { get; set; }

    [Required, Length(5, 30), EmailAddress]
    public required string Email { get; set; }

    public string? HashedPassword { get; set; }
    [Compare(nameof(HashedPassword))]
    public string? ConfirmedPassword { get; set; }

    public bool IsDeleted { get; set; }
}
