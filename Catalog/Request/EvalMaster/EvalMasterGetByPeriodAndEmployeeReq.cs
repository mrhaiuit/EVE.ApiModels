using EVE.Commons;
using EVE.WebApi.Shared;
using FluentValidation;
using FluentValidation.Attributes;

namespace EVE.ApiModels.Catalog
{
    [Validator(typeof(EvalMasterGetByPeriodAndEmployeeValidator))]
    public class EvalMasterGetByPeriodAndEmployeeReq 
    {
        public int PeriodId { get; set; }
        public int BeEvalEmployeeId { get; set; }
        public int EvalEmployeeId { get; set; }
    }

    public class EvalMasterGetByPeriodAndEmployeeValidator : AbstractValidator<EvalMasterGetByPeriodAndEmployeeReq>
    {
        public EvalMasterGetByPeriodAndEmployeeValidator()
        {
            RuleFor(c => c.PeriodId)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage((EnumError.PeriodIdIsNullOrEmpty).ToString());

            RuleFor(c => c.BeEvalEmployeeId)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage((EnumError.BeEvalEmployeeIdIsNullOrEmpty).ToString());

            RuleFor(c => c.EvalEmployeeId)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage((EnumError.EvalEmployeeIdIsNullOrEmpty).ToString());
        }
    }
}
