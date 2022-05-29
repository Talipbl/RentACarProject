using Entities.Concretes.Models;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(p => p.CarName).NotEmpty();
            RuleFor(p => p.CarName).MinimumLength(3);
            RuleFor(p => p.DailyPrice).NotEmpty();
        }
    }
}
