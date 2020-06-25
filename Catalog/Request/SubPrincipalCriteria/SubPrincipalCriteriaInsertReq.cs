using System;
using EVE.Commons;
using EVE.WebApi.Shared;
using FluentValidation;
using FluentValidation.Attributes;
using FluentValidation.Results;

namespace EVE.ApiModels.Catalog
{
    [Validator(typeof(SubPrincipalCriteriaInsertValidator))]
    public class SubPrincipalCriteriaInsertReq : SubPrincipalCriteriaBaseReq
    {
    }

    public class SubPrincipalCriteriaInsertValidator : AbstractValidator<SubPrincipalCriteriaInsertReq>
    {
        public SubPrincipalCriteriaInsertValidator()
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
        public override ValidationResult Validate(ValidationContext<SubPrincipalCriteriaInsertReq> context)
        {
            return context.InstanceToValidate == null
                           ? new ValidationResult(new[] {new ValidationFailure("Request", "Request can not null")})
                           : base.Validate(context);
        }
    }
}
