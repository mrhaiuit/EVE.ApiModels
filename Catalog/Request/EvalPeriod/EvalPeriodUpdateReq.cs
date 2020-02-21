using EVE.Commons;
using FluentValidation;
using FluentValidation.Attributes;

namespace EVE.ApiModels.Catalog
{
    [Validator(typeof(EvalPeriodUpdateValidator))]
    public class EvalPeriodUpdateReq : EvalPeriodInsertReq
    {
    }

    public class EvalPeriodUpdateValidator : AbstractValidator<EvalPeriodUpdateReq>
    {
        public EvalPeriodUpdateValidator()
        {
            RuleFor(c => c.PeriodName)
                    .NotNull()
                    .NotEmpty()
                  .WithMessage((EnumError.PeriodNameCanNotBeNull).ToString());
            RuleFor(c => c.Year)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage((EnumError.YearCanNotBeNull).ToString());
            RuleFor(c => c.FromDate)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage((EnumError.FromDateCanNotBeNull).ToString());
            RuleFor(c => c.ToDate)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage((EnumError.ToDateCanNotBeNull).ToString());

        }
    }
}
