using EVE.Commons;
using FluentValidation;
using FluentValidation.Attributes;

namespace EVE.ApiModels.Authentication.Request
{
    [Validator(typeof(EmployeeUpdateValidator))]
    public class EmployeeUpdateReq : EmployeeInsertReq
    {
    }

    public class EmployeeUpdateValidator : AbstractValidator<EmployeeUpdateReq>
    {
        public EmployeeUpdateValidator()
        {
            RuleFor(c => c.EmployeeName)
                       .NotNull()
                       .NotEmpty()
                       .WithMessage(((int)EnumError.EmployeeNameIsNullOrEmpty).ToString());
            RuleFor(c => c.UserName)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage(((int)EnumError.UserNameIsNullOrEmpty).ToString());
            RuleFor(c => c.Password)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage(((int)EnumError.PasswordIsNullOrEmpty).ToString());
            RuleFor(c => c.EmployeeName)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage(((int)EnumError.PasswordIsNullOrEmpty).ToString());
            RuleFor(c => c.EduLevelCode)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage(((int)EnumError.EduLevelCodeIsNullOrEmpty).ToString());
        }
    }
}
