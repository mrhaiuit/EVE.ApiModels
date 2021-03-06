﻿using EVE.Commons;
using EVE.WebApi.Shared;
using FluentValidation;
using FluentValidation.Attributes;
using FluentValidation.Results;

namespace EVE.ApiModels.Catalog
{
    [Validator(typeof(UserGroupFormGetByIdValidator))]
    public class UserGroupFormGetByIdReq : UserGroupFormBaseReq
    {
        
    }

    public class UserGroupFormGetByIdValidator : AbstractValidator<UserGroupFormGetByIdReq>
    {
        public UserGroupFormGetByIdValidator()
        {
            RuleFor(c => c.FormCode)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage((EnumError.FormCodeIsNullOrEmpty).ToString());
            RuleFor(c => c.UserGroupCode)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage((EnumError.UserGroupCodeIsNullOrEmpty).ToString());
        }

    }
}
