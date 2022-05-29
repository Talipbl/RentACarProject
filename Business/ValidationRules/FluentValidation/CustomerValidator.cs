using Entities.Concretes.Models;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(p => p.FirstName).NotEmpty();
            RuleFor(p => p.LastName).NotEmpty();
            RuleFor(p => p.PhoneNumber).NotEmpty();
            RuleFor(p => p.PhoneNumber).MaximumLength(11);
        }
    }
}
