using EVE.Commons;
using EVE.WebApi.Shared;
using FluentValidation;
using FluentValidation.Attributes;

namespace EVE.ApiModels.Catalog
{
    [Validator(typeof(SubPrincipalCriteriaDeleteValidator))]
    public class SubPrincipalCriteriaDeleteReq : SubPrincipalCriteriaBaseReq
    {
    }

    public class SubPrincipalCriteriaDeleteValidator : AbstractValidator<SubPrincipalCriteriaDeleteReq>
    {
        public SubPrincipalCriteriaDeleteValidator()
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
