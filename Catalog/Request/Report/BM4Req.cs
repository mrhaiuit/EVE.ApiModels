using EVE.Commons;
using FluentValidation;
using FluentValidation.Attributes;

namespace EVE.ApiModels.Catalog
{
    [Validator(typeof(BM4ReqValidator))]
    public class BM4Req 
    {
        public int PeriodId { get; set; }
        public int SchoolId { get; set; }

    }

    public class BM4ReqValidator : AbstractValidator<BM4Req>
    {
        public BM4ReqValidator()
        {
            RuleFor(c => c.PeriodId)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage(((int)EnumError.PeriodIdIsNullOrEmpty).ToString());
            RuleFor(c => c.SchoolId)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage(((int)EnumError.SchoolIdIsNullOrEmpty).ToString());
        }
    }
}
