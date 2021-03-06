﻿using EVE.Commons;
using EVE.WebApi.Shared;
using FluentValidation;
using FluentValidation.Attributes;
using FluentValidation.Results;

namespace EVE.ApiModels.Catalog
{
    [Validator(typeof(UserGroupEmployeeGetByIdValidator))]
    public class UserGroupEmployeeGetByIdReq : UserGroupEmployeeBaseReq
    {
        
    }

    public class UserGroupEmployeeGetByIdValidator : AbstractValidator<UserGroupEmployeeGetByIdReq>
    {
        public UserGroupEmployeeGetByIdValidator()
        {
            RuleFor(c => c.EmployeeId)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage((EnumError.EmployeeIdIsNullOrEmpty).ToString());
            RuleFor(c => c.UserGroupCode)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage((EnumError.UserGroupCodeIsNullOrEmpty).ToString());
        }

    }
}
