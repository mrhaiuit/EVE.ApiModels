using EVE.Commons;
using EVE.WebApi.Shared;
using FluentValidation;
using FluentValidation.Attributes;

namespace EVE.ApiModels.Catalog
{
    [Validator(typeof(EvalStandardGetByLevelAndTypeValidator))]
    public class EvalStandardGetByLevelAndTypeReq 
    {
        public string SchoolLevelCode { get; set; }
        public string EvalTypeCode { get; set; }

    }

    public class EvalStandardGetByLevelAndTypeValidator : AbstractValidator<EvalStandardGetByLevelAndTypeReq>
    {
        public EvalStandardGetByLevelAndTypeValidator()
        {
            RuleFor(c => c.SchoolLevelCode)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage((EnumError.EduLevelCodeIsNullOrEmpty).ToString());
            RuleFor(c => c.EvalTypeCode)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage((EnumError.EvalTypeCodeIsNullOrEmpty).ToString());
        }

    }
}
