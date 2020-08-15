using EVE.Commons;
using FluentValidation;
using FluentValidation.Attributes;
using System;

namespace EVE.ApiModels.Authentication.Request
{
    [Validator(typeof(EmployeeInsertValidator))]
    public class EmployeeInsertReq : EmployeeBaseReq
    {
        public string EmployeeCode { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string EmployeeName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string MinistryofEducationaCode { get; set; }
        public Nullable<int> EduProvinceId { get; set; }
        public Nullable<int> EduDepartmentId { get; set; }
        public Nullable<int> SchoolId { get; set; }
        public Nullable<bool> Active { get; set; }
        public string Remarks { get; set; }
        public string EduLevelCode { get; set; }
        public string PositionCode { get; set; }
        public Nullable<System.DateTime> Birthday { get; set; }
        public Nullable<bool> Sex { get; set; }
        public string Email { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<int> CreateBy { get; set; }
        public Nullable<int> SchoolDepartmentId { get; set; }
        public string UserGroupCode { get; set; }
        public string Class { get; set; }
    }

    public class EmployeeInsertValidator : AbstractValidator<EmployeeInsertReq>
    {
        public EmployeeInsertValidator()
        {
            RuleFor(c => c.EmployeeName)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage(((int) EnumError.EmployeeNameIsNullOrEmpty).ToString());
            RuleFor(c => c.UserName)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage(((int)EnumError.UserNameIsNullOrEmpty).ToString());
            RuleFor(c => c.Password)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage(((int)EnumError.PasswordIsNullOrEmpty).ToString());
            RuleFor(c => c.EduLevelCode)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage(((int)EnumError.EduLevelCodeIsNullOrEmpty).ToString());
            RuleFor(c => c.UserGroupCode)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage(((int)EnumError.UserGroupCodeIsNullOrEmpty).ToString());
        }
    }
}
