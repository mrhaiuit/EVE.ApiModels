using System;
using EVE.Commons;
using EVE.WebApi.Shared;
using FluentValidation;
using FluentValidation.Attributes;

namespace EVE.ApiModels.Catalog
{
    [Validator(typeof(EvalDetailInsertValidator))]
    public class EvalDetailInsertReq : EvalDetailBaseReq
    {
        public int EvalMasterId { get; set; }
        public string EvalStandardName { get; set; }
        public int EvalCriteriaId { get; set; }
        public string EvalCriteriaName { get; set; }
        public string EvalResultCode { get; set; }
        public string Sample { get; set; }
        public string Attachment { get; set; }
        public string EvalResultPrincipal { get; set; }
    }

    public class EvalDetailInsertValidator : AbstractValidator<EvalDetailInsertReq>
    {
        public EvalDetailInsertValidator()
        {
            RuleFor(c => c.EvalMasterId)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage(((int)EnumError.EvalMasterIsNullOrEmpty).ToString());
            RuleFor(c => c.EvalCriteriaId)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage(((int)EnumError.EvalCriteriaIsNullOrEmpty).ToString());
        }
    }
}
