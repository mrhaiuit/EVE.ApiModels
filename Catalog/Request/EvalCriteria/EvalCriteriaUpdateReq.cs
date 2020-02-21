using EVE.Commons;
using EVE.WebApi.Shared;
using FluentValidation;
using FluentValidation.Attributes;

namespace EVE.ApiModels.Catalog
{
    [Validator(typeof(EvalCriteriaUpdateValidator))]
    public class EvalCriteriaUpdateReq : EvalCriteriaInsertReq
    {
    }

    public class EvalCriteriaUpdateValidator : AbstractValidator<EvalCriteriaUpdateReq>
    {
        public EvalCriteriaUpdateValidator()
        {
            RuleFor(c => c.EvalStandardId)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage(((int)EnumError.EvalStandardIdIsNullOrEmpty).ToString());
            RuleFor(c => c.EvalCriteriaName)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage(((int)EnumError.EvalCriteriaNameIsNullOrEmpty).ToString());
            RuleFor(c => c.Idx)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage(((int)EnumError.IdxIsNullOrEmpty).ToString());
        }
    }
}
