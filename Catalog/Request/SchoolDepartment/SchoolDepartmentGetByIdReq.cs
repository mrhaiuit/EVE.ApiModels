using EVE.Commons;
using FluentValidation;
using FluentValidation.Attributes;

namespace EVE.ApiModels.Catalog
{
    [Validator(typeof(SchoolDepartmentGetByIdValidator))]
    public class SchoolDepartmentGetByIdReq : SchoolDepartmentBaseReq
    {
    }

    public class SchoolDepartmentGetByIdValidator : AbstractValidator<SchoolDepartmentGetByIdReq>
    {
        public SchoolDepartmentGetByIdValidator()
        {
            RuleFor(c => c.SchoolDepartmentId)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage(((int) EnumError.SchoolDepartmentIdIsNullOrEmpty).ToString());
        }
    }
}
