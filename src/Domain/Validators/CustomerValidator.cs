using Domain.Models;
using FluentValidation;

namespace Domain.Validators;


// dotnet add package FluentValidation

public class CustomerValidator : AbstractValidator<Customer>
{
    public CustomerValidator()
    {
        RuleFor(p => p.Name).NotEmpty().Length(3, 10);
        RuleFor(p=>p.Email).EmailAddress().NotEmpty().Length(5, 30);
        RuleFor(p => p.ConfirmedPassword).Equal(p => p.HashedPassword);
    }
}
