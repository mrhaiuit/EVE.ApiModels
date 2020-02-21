using EVE.Commons;
using EVE.WebApi.Shared;
using FluentValidation;
using FluentValidation.Attributes;
using System;

namespace EVE.ApiModels.Catalog
{
    [Validator(typeof(EduDepartmentInsertValidator))]
    public class EduDepartmentInsertReq : EduDepartmentBaseReq
    {
        public string EduDepartmentName { get; set; }
        public Nullable<int> DistrictId { get; set; }
        public Nullable<int> EduProvinceId { get; set; }
        public string Address { get; set; }
        public Nullable<int> Idx { get; set; }
    }

    public class EduDepartmentInsertValidator : AbstractValidator<EduDepartmentInsertReq>
    {
        public EduDepartmentInsertValidator()
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
