using EVE.Commons;
using EVE.WebApi.Shared;
using FluentValidation;
using FluentValidation.Attributes;

namespace EVE.ApiModels.Catalog
{
    [Validator(typeof(UserGroupEmployeeUpdateValidator))]
    public class UserGroupEmployeeUpdateReq : UserGroupEmployeeInsertReq
    {
    }

    public class UserGroupEmployeeUpdateValidator : AbstractValidator<UserGroupEmployeeUpdateReq>
    {
        public UserGroupEmployeeUpdateValidator()
        {
            RuleFor(c => c.EmployeeId)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage((EnumError.EmployeeIdIsNullOrEmpty).ToString());
            RuleFor(c => c.UserGroupCode)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage((EnumError.UserGroupCodeIsNullOrEmpty).ToString());
        }
    }
}
