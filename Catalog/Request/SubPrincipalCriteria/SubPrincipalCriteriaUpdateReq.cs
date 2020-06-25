using EVE.Commons;
using EVE.WebApi.Shared;
using FluentValidation;
using FluentValidation.Attributes;

namespace EVE.ApiModels.Catalog
{
    [Validator(typeof(SubPrincipalCriteriaUpdateValidator))]
    public class SubPrincipalCriteriaUpdateReq : SubPrincipalCriteriaInsertReq
    {
    }

    public class SubPrincipalCriteriaUpdateValidator : AbstractValidator<SubPrincipalCriteriaUpdateReq>
    {
        public SubPrincipalCriteriaUpdateValidator()
        {
            RuleFor(c => c.SubPrincipalId)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage(EnumError.SubPrincipalIdIsNullOrEmpty.ToString());

            RuleFor(c => c.EvalCriteriaId)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage(EnumError.EvalCriteriaIdNullOrEmpty.ToString());

            RuleFor(c => c.EvalPeriodId)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage(EnumError.EvalPeriodNotExist.ToString());

        }
    }
}
