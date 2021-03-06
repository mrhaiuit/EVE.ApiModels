﻿using EVE.Commons;
using EVE.WebApi.Shared;
using FluentValidation;
using FluentValidation.Attributes;

namespace EVE.ApiModels.Catalog
{
    [Validator(typeof(UserGroupUpdateValidator))]
    public class UserGroupUpdateReq : UserGroupInsertReq
    {
    }

    public class UserGroupUpdateValidator : AbstractValidator<UserGroupUpdateReq>
    {
        public UserGroupUpdateValidator()
        {
            RuleFor(c => c.UserGroupCode)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage((EnumError.UserGroupCodeIsNullOrEmpty).ToString());
            RuleFor(c => c.UserGroupName)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage((EnumError.UserGroupNameIsNullOrEmpty).ToString());

            RuleFor(c => c.EduLevelCode)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage((EnumError.EduLevelCodeIsNullOrEmpty).ToString());
        }
    }
}
