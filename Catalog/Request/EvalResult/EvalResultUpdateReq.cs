using EVE.Commons;
using EVE.WebApi.Shared;
using FluentValidation;
using FluentValidation.Attributes;

namespace EVE.ApiModels.Catalog
{
    [Validator(typeof(EvalResultUpdateValidator))]
    public class EvalResultUpdateReq : EvalResultInsertReq
    {
    }

    public class EvalResultUpdateValidator : AbstractValidator<EvalResultUpdateReq>
    {
        public EvalResultUpdateValidator()
        {
            RuleFor(c => c.EvalResultCode)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage((EnumError.EvalResultCodeIsNullOrEmpty).ToString());
            RuleFor(c => c.EvalResultName)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage((EnumError.EvalResultNameIsNullOrEmpty).ToString());
        }
    }
}
