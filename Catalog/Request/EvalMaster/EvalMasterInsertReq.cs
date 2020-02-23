using EVE.Commons;
using EVE.WebApi.Shared;
using FluentValidation;
using FluentValidation.Attributes;
using System;

namespace EVE.ApiModels.Catalog
{
    [Validator(typeof(EvalMasterInsertValidator))]
    public class EvalMasterInsertReq : EvalMasterBaseReq
    {
        public string Remark { get; set; }
        public string EvalStateCode { get; set; }
        public Nullable<int> EvalPeriodId { get; set; }
        public Nullable<int> BeEvalEmployeeId { get; set; }
        public Nullable<int> EvalEmployeeId { get; set; }
        public Nullable<int> CreateBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<int> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
    }

    public class EvalMasterInsertValidator : AbstractValidator<EvalMasterInsertReq>
    {
        public EvalMasterInsertValidator()
        {
            RuleFor(c => c.EvalMasterId)
                    .NotNull()
                    .NotEmpty();
        }
    }
}
