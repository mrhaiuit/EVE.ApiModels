using EVE.Commons;
using EVE.WebApi.Shared;
using FluentValidation;
using FluentValidation.Attributes;

namespace EVE.ApiModels.Catalog
{
    [Validator(typeof(UserGroupFormUpdateValidator))]
    public class UserGroupFormUpdateReq : UserGroupFormInsertReq
    {
    }

    public class UserGroupFormUpdateValidator : AbstractValidator<UserGroupFormUpdateReq>
    {
        public UserGroupFormUpdateValidator()
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
