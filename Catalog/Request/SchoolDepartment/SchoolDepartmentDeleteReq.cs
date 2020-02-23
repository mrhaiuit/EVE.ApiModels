using EVE.ApiModels.Authentication.Request;
using EVE.Commons;
using FluentValidation;
using FluentValidation.Attributes;

namespace EVE.ApiModels.Catalog
{
    [Validator(typeof(SchoolDepartmentDeleteValidator))]
    public class SchoolDepartmentDeleteReq : SchoolDepartmentBaseReq
    {
    }

    public class SchoolDepartmentDeleteValidator : AbstractValidator<SchoolDepartmentBaseReq>
    {
        public SchoolDepartmentDeleteValidator()
        {
            RuleFor(c => c.SchoolDepartmentId)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage(((int) EnumError.SchoolDepartmentIdIsNullOrEmpty).ToString());
        }
    }
}