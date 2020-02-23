using EVE.Commons;
using FluentValidation;
using FluentValidation.Attributes;
using System;

namespace EVE.ApiModels.Catalog
{
    [Validator(typeof(SchoolDepartmentInsertValidator))]
    public class SchoolDepartmentInsertReq : SchoolDepartmentBaseReq
    {
        public int SchoolId { get; set; }
        public string SchoolDepartmentName { get; set; }
    }

    public class SchoolDepartmentInsertValidator : AbstractValidator<SchoolDepartmentInsertReq>
    {
        public SchoolDepartmentInsertValidator()
        {
            RuleFor(c => c.SchoolId)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage(((int) EnumError.SchoolIdIsNullOrEmpty).ToString());
            RuleFor(c => c.SchoolDepartmentName)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage(((int)EnumError.SchoolDepartmentNameIsNullOrEmpty).ToString());           
        }
    }
}
