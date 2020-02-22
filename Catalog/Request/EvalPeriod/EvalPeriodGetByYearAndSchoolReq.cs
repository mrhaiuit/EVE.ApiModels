﻿using EVE.Commons;
using EVE.WebApi.Shared;
using FluentValidation;
using FluentValidation.Attributes;

namespace EVE.ApiModels.Catalog
{
    [Validator(typeof(EvalPeriodGetByYearAndSchoolValidator))]
    public class EvalPeriodGetByYearAndSchoolReq
    {
        public int SchoolId { get; set; }
        public int Year { get; set; }
    }

    public class EvalPeriodGetByYearAndSchoolValidator : AbstractValidator<EvalPeriodGetByYearAndSchoolReq>
    {
        public EvalPeriodGetByYearAndSchoolValidator()
        {
            RuleFor(c => c.SchoolId)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage((EnumError.SchoolIdIsNullOrEmpty).ToString());

            RuleFor(c => c.Year)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage((EnumError.YearIsNullOrEmpty).ToString());
        }
    }
}