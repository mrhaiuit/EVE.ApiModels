using EVE.Commons;
using EVE.WebApi.Shared;
using FluentValidation;
using FluentValidation.Attributes;

namespace EVE.ApiModels.Catalog
{
    [Validator(typeof(EduDepartmentUpdateValidator))]
    public class EduDepartmentUpdateReq : EduDepartmentInsertReq
    {
    }

    public class EduDepartmentUpdateValidator : AbstractValidator<EduDepartmentUpdateReq>
    {
        public EduDepartmentUpdateValidator()
        {
            RuleFor(c => c.EduDepartmentName)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage(((int)EnumError.EduDepartmentNameIsNullOrEmpty).ToString());
            RuleFor(c => c.EduDepartmentName)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage(((int)EnumError.EduProvinceIdIsNullOrEmpty).ToString());
            RuleFor(c => c.DistrictId)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage(((int)EnumError.DistrictIdIsNullOrEmpty).ToString());
        }
    }
}
