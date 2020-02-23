using EVE.ApiModels.Authentication.Request;
using EVE.Commons;
using FluentValidation;
using FluentValidation.Attributes;

namespace EVE.ApiModels.Authentication.Request
{
    [Validator(typeof(EmployeeDeleteValidator))]
    public class EmployeeDeleteReq : EmployeeBaseReq
    {
    }

    public class EmployeeDeleteValidator : AbstractValidator<EmployeeBaseReq>
    {
        public EmployeeDeleteValidator()
        {
            RuleFor(c => c.EmployeeId)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage(((int) EnumError.EmployeeIdIsNullOrEmpty).ToString());
        }
    }
}