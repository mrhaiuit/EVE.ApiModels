using EVE.Commons;
using FluentValidation;
using FluentValidation.Attributes;

namespace EVE.ApiModels.Catalog
{
    [Validator(typeof(EvalStandardUpdateValidator))]
    public class EvalStandardUpdateReq : EvalStandardInsertReq
    {
    }

    public class EvalStandardUpdateValidator : AbstractValidator<EvalStandardUpdateReq>
    {
        public EvalStandardUpdateValidator()
        {
            RuleFor(c => c.EvalStandardName)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage((EnumError.EvalStandardNameIsNullOrEmpty).ToString());
            RuleFor(c => c.EvalTypeCode)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage((EnumError.EvalTypeCodeIsNullOrEmpty).ToString());
            RuleFor(c => c.SchoolLevelCode)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage((EnumError.SchoolLevelCodeIsNullOrEmpty).ToString());
        }
    }
}
