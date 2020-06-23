using EVE.Commons;
using FluentValidation;
using FluentValidation.Attributes;

namespace EVE.ApiModels.Catalog
{

    [Validator(typeof(EvalPeriodByUserGroupAndTypeValidator))]
    public class EvalPeriodByUserGroupAndTypeReq 
    {
        public string UserGroupCode { get; set; }
        public int EmpoyeeId { get; set; }
        public string EvalTypeCode { get; set; }
    }

    public class EvalPeriodByUserGroupAndTypeValidator : AbstractValidator<EvalPeriodByUserGroupAndTypeReq>
    {
        public EvalPeriodByUserGroupAndTypeValidator()
        {
            RuleFor(c => c.UserGroupCode)
                    .NotNull()
                    .NotEmpty()
                  .WithMessage((EnumError.UserGroupCodeIsNullOrEmpty).ToString());
            RuleFor(c => c.EmpoyeeId)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage((EnumError.EmployeeIdIsNullOrEmpty).ToString());
            RuleFor(c => c.EvalTypeCode)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage((EnumError.EvalTypeCodeIsNullOrEmpty).ToString());
        }
    }
}
