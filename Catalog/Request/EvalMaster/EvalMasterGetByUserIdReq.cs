using EVE.Commons;
using EVE.WebApi.Shared;
using FluentValidation;
using FluentValidation.Attributes;

namespace EVE.ApiModels.Catalog
{
    [Validator(typeof(EvalMasterGetByUserIdValidator))]
    public class EvalMasterGetByUserIdReq 
    {
        public int EmployeeId { get; set; }
        public int Year { get; set; }
    }

    public class EvalMasterGetByUserIdValidator : AbstractValidator<EvalMasterGetByUserIdReq>
    {
        public EvalMasterGetByUserIdValidator()
        {
            RuleFor(c => c.EmployeeId)
                    .NotNull()
                    .NotEmpty()
                     .WithMessage((EnumError.EmployeeIdIsNullOrEmpty).ToString());

            RuleFor(c => c.Year)
                    .NotNull()
                    .NotEmpty()
                     .WithMessage((EnumError.YearCanNotBeNull).ToString());
        }
    }
}
