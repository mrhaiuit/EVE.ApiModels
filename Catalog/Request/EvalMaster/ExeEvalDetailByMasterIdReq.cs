using EVE.Commons;
using EVE.WebApi.Shared;
using FluentValidation;
using FluentValidation.Attributes;

namespace EVE.ApiModels.Catalog
{
    [Validator(typeof(ExeEvalDetailByMasterIdValidator))]
    public class ExeEvalDetailByMasterIdReq 
    {
        public int BeEvalEmployeeId { get; set; }
        public int EvalEmployeeId { get; set; }
        public int PeriodId { get; set; }
    }

    public class ExeEvalDetailByMasterIdValidator : AbstractValidator<ExeEvalDetailByMasterIdReq>
    {
        public ExeEvalDetailByMasterIdValidator()
        {
            RuleFor(c => c.BeEvalEmployeeId)
                    .NotNull()
                    .NotEmpty()
                     .WithMessage((EnumError.BeEvalEmployeeIdIsNullOrEmpty).ToString());

            RuleFor(c => c.EvalEmployeeId)
                    .NotNull()
                    .NotEmpty()
                     .WithMessage((EnumError.EvalEmployeeIdIsNullOrEmpty).ToString());

            RuleFor(c => c.PeriodId)
                    .NotNull()
                    .NotEmpty()
                     .WithMessage((EnumError.PeriodIdIsNullOrEmpty).ToString());
        }
    }
}
