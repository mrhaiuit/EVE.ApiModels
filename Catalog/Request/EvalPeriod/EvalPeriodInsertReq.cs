using EVE.Commons;
using FluentValidation;
using FluentValidation.Attributes;
using System;

namespace EVE.ApiModels.Catalog
{
    [Validator(typeof(EvalPeriodInsertValidator))]
    public class EvalPeriodInsertReq : EvalPeriodBaseReq
    {
        public string EvalTypeCode { get; set; }
        public string PeriodName { get; set; }
        public Nullable<int> Year { get; set; }
        public Nullable<System.DateTime> FromDate { get; set; }
        public Nullable<System.DateTime> ToDate { get; set; }
        public Nullable<int> SchoolId { get; set; }
        public string Remark { get; set; }
    }

    public class EvalPeriodInsertValidator : AbstractValidator<EvalPeriodInsertReq>
    {
        public EvalPeriodInsertValidator()
        {
            RuleFor(c => c.PeriodName)
                    .NotNull()
                    .NotEmpty()
                  .WithMessage((EnumError.PeriodNameCanNotBeNull).ToString());
            RuleFor(c => c.Year)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage((EnumError.YearCanNotBeNull).ToString());
            RuleFor(c => c.FromDate)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage((EnumError.FromDateCanNotBeNull).ToString());
            RuleFor(c => c.ToDate)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage((EnumError.ToDateCanNotBeNull).ToString());
            RuleFor(c => c.SchoolId)
                    .NotNull()
                    .NotEmpty()
                  .WithMessage((EnumError.SchoolIsNullOrEmpty).ToString());
        }
    }
}
