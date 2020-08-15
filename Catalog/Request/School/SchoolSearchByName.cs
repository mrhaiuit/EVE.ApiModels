using EVE.Commons;
using EVE.WebApi.Shared;
using FluentValidation;
using FluentValidation.Attributes;
using FluentValidation.Results;

namespace EVE.ApiModels.Catalog
{
    [Validator(typeof(SchoolSearchByNameValidator))]
    public class SchoolSearchByNameReq
    {
        public int? EduProvinceId { get; set; }
        public int? EduDepartmentId { get; set; }
        public string SchoolName { get; set; }
    }

    public class SchoolSearchByNameValidator : AbstractValidator<SchoolSearchByNameReq>
    {

    }
}
