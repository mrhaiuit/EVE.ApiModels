using EVE.Commons;
using EVE.WebApi.Shared;
using FluentValidation;
using FluentValidation.Attributes;

namespace EVE.ApiModels.Catalog
{
    [Validator(typeof(GetByEvalTypeSchoolLevelValidator))]
    public class GetByEvalTypeSchoolLevelReq 
    {
        public string SchoolLevelCode { get; set; }
    }

    public class GetByEvalTypeSchoolLevelValidator : AbstractValidator<GetByEvalTypeSchoolLevelReq>
    {
        public GetByEvalTypeSchoolLevelValidator()
        {
            RuleFor(c => c.SchoolLevelCode)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage(EnumError.SchoolLevelCodeIsNullOrEmpty.ToString());
        }
    }
}
