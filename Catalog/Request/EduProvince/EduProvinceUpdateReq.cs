using EVE.Commons;
using EVE.WebApi.Shared;
using FluentValidation;
using FluentValidation.Attributes;

namespace EVE.ApiModels.Catalog
{
    [Validator(typeof(EduProvinceUpdateValidator))]
    public class EduProvinceUpdateReq : EduProvinceInsertReq
    {
    }

    public class EduProvinceUpdateValidator : AbstractValidator<EduProvinceUpdateReq>
    {
        public EduProvinceUpdateValidator()
        {
            RuleFor(c => c.EduProvinceName)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage(((int)EnumError.EduProvinceNameIsNullOrEmpty).ToString());

            RuleFor(c => c.ProvinceId)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage(((int)EnumError.ProvinceIdIsNullOrEmpty).ToString());
        }
    }
}
