using System;
using EVE.Commons;
using EVE.WebApi.Shared;
using FluentValidation;
using FluentValidation.Attributes;
using FluentValidation.Results;

namespace EVE.ApiModels.Catalog
{
    [Validator(typeof(UserGroupFormInsertValidator))]
    public class UserGroupFormInsertReq : UserGroupFormBaseReq
    {
    }

    public class UserGroupFormInsertValidator : AbstractValidator<UserGroupFormInsertReq>
    {
        public UserGroupFormInsertValidator()
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

        public override ValidationResult Validate(ValidationContext<UserGroupFormInsertReq> context)
        {
            return context.InstanceToValidate == null
                           ? new ValidationResult(new[] {new ValidationFailure("Request", "Request can not null")})
                           : base.Validate(context);
        }
    }
}
