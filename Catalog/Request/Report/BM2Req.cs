using EVE.Commons;
using FluentValidation;
using FluentValidation.Attributes;

namespace EVE.ApiModels.Catalog
{
    [Validator(typeof(BM2ReqValidator))]
    public class BM2Req 
    {
        public int PeriodId { get; set; }
        public int EmployeeId { get; set; }

    }

    public class BM2ReqValidator : AbstractValidator<BM2Req>
    {
        public BM2ReqValidator()
        {
            RuleFor(c => c.PeriodId)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage(((int)EnumError.PeriodIdIsNullOrEmpty).ToString());
            RuleFor(c => c.EmployeeId)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage(((int)EnumError.EmployeeIdIsNullOrEmpty).ToString());
        }
    }
}
