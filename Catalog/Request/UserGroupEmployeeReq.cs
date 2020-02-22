using EVE.Commons;
using FluentValidation;
using FluentValidation.Attributes;

namespace EVE.ApiModels.Catalog
{

    [Validator(typeof(UserGroupEmployeeValidator))]
    public class UserGroupEmployeeReq : EvalPeriodBaseReq
    {
        public string UserGroupCode { get; set; }
        public int EmpoyeeId { get; set; }
    }

    public class UserGroupEmployeeValidator : AbstractValidator<UserGroupEmployeeReq>
    {
        public UserGroupEmployeeValidator()
        {
            RuleFor(c => c.UserGroupCode)
                    .NotNull()
                    .NotEmpty()
                  .WithMessage((EnumError.UserGroupCodeIsNullOrEmpty).ToString());
            RuleFor(c => c.EmpoyeeId)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage((EnumError.EmployeeIdIsNullOrEmpty).ToString());
        }
    }
}
