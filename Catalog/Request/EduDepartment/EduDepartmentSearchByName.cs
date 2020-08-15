using EVE.Commons;
using EVE.WebApi.Shared;
using FluentValidation;
using FluentValidation.Attributes;

namespace EVE.ApiModels.Catalog
{
    [Validator(typeof(EduDepartmentSearchByNameValidator))]
    public class EduDepartmentSearchByNameReq 
    {
        public int?  EduProvinceId { get; set; }
        public string EduDepartmentName { get; set; }
    }

    public class EduDepartmentSearchByNameValidator : AbstractValidator<EduDepartmentSearchByNameReq>
    {
    }
}
