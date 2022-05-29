using Business.Constanst;
using Entities.Concretes.Models;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalValidator : AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(p => p.CustomerId).NotEmpty();
            RuleFor(p => p.CarId).NotEmpty();
            RuleFor(p => p.RentDate).NotEmpty();
            RuleFor(p => p.ReturnDate).GreaterThan(p => p.RentDate).WithMessage(Messages.Validation.GreaterThanRentDate);
        }
    }
}
