using EVE.Commons;
using FluentValidation;
using FluentValidation.Attributes;

namespace EVE.ApiModels.Authentication.Request
{
    [Validator(typeof(GetUserGroupByUserNameReqValidator))]
    public class GetUserGroupByUserNameReq
    {
        public string UserName { get; set; }
    }

    public class GetUserGroupByUserNameReqValidator : AbstractValidator<GetUserGroupByUserNameReq>
    {
        public GetUserGroupByUserNameReqValidator()
        {
            RuleFor(c => c.UserName)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage(((int) EnumError.UsernameIsNullOrEmpty).ToString());
        }
    }
}
