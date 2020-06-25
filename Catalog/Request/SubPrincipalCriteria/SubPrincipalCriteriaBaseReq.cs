using EVE.Commons;
using FluentValidation;
using FluentValidation.Attributes;

namespace EVE.ApiModels.Catalog
{
    [Validator(typeof(SubPrincipalCriteriaValidator))]
    public class SubPrincipalCriteriaBaseReq
    {
        public int SubPrincipalId { get; set; }
        public int EvalPeriodId { get; set; }
        public int EvalCriteriaId { get; set; }
    }


    public class SubPrincipalCriteriaValidator : AbstractValidator<SubPrincipalCriteriaBaseReq>
    {
        public SubPrincipalCriteriaValidator()
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
