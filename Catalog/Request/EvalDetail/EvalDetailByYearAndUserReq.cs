using EVE.Commons;
using EVE.WebApi.Shared;
using FluentValidation;
using FluentValidation.Attributes;

namespace EVE.ApiModels.Catalog
{
    [Validator(typeof(EvalDetailByYearAndUserValidator))]
    public class EvalDetailByYearAndUserReq 
    {
        public int EvalCriteriaId { get; set; }
        public int EmployeeId { get; set; }
        public int Year { get; set; }

    }

    public class EvalDetailByYearAndUserValidator : AbstractValidator<EvalDetailByYearAndUserReq>
    {
        public EvalDetailByYearAndUserValidator()
        {
            RuleFor(c => c.EvalCriteriaId)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage(((int)EnumError.EvalCriteriaIdNullOrEmpty).ToString());
            RuleFor(c => c.EmployeeId)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage(((int)EnumError.EmployeeIdIsNullOrEmpty).ToString());
            RuleFor(c => c.Year)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage(((int)EnumError.YearIsNullOrEmpty).ToString());
        }
    }
}
