using EVE.Commons;
using FluentValidation;
using FluentValidation.Attributes;

namespace EVE.ApiModels.Catalog
{
    [Validator(typeof(SchoolDepartmentUpdateValidator))]
    public class SchoolDepartmentUpdateReq : SchoolDepartmentInsertReq
    {
    }

    public class SchoolDepartmentUpdateValidator : AbstractValidator<SchoolDepartmentInsertReq>
    {
        public SchoolDepartmentUpdateValidator()
        {
            RuleFor(c => c.SchoolDepartmentName)
                       .NotNull()
                       .NotEmpty()
                       .WithMessage(((int)EnumError.SchoolDepartmentNameIsNullOrEmpty).ToString());
            RuleFor(c => c.SchoolId)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage(((int)EnumError.SchoolIdIsNullOrEmpty).ToString());
        }
    }
}
