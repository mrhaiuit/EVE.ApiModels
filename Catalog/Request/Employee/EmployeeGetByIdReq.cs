using EVE.Commons;
using FluentValidation;
using FluentValidation.Attributes;

namespace EVE.ApiModels.Authentication.Request
{
    [Validator(typeof(EmployeeGetByIdValidator))]
    public class EmployeeGetByIdReq : EmployeeBaseReq
    {
    }

    public class EmployeeGetByIdValidator : AbstractValidator<EmployeeGetByIdReq>
    {
        public EmployeeGetByIdValidator()
        {
            RuleFor(c => c.EmployeeId)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage(((int) EnumError.EmployeeIdIsNullOrEmpty).ToString());
        }
    }
}
