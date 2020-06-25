using EVE.Commons;
using FluentValidation;
using FluentValidation.Attributes;

namespace EVE.ApiModels.Catalog
{
    [Validator(typeof(GetByEmployeeAndPeriodReqValidator))]
    public class GetByEmployeeAndPeriodReq
    {
        public int SubPrincipalId { get; set; }
        public int EvalPeriodId { get; set; }
    }


    public class GetByEmployeeAndPeriodReqValidator : AbstractValidator<GetByEmployeeAndPeriodReq>
    {
        public GetByEmployeeAndPeriodReqValidator()
        {
            RuleFor(c => c.SubPrincipalId)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage(EnumError.SubPrincipalIdIsNullOrEmpty.ToString());

            RuleFor(c => c.EvalPeriodId)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage(EnumError.EvalPeriodNotExist.ToString());

        }
    }
}
