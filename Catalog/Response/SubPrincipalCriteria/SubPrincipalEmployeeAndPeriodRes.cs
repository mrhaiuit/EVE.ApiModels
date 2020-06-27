using EVE.Data;
using System;
using System.Collections.Generic;

namespace EVE.ApiModels.Catalog.Response
{
    public class SubPrincipalEmployeeAndPeriodRes
    {
        public int SubPrincipalId { get; set; }
        public int EvalPeriodId { get; set; }
        public int EvalCriteriaId { get; set; }
        public string EvalCriteriaName { get; set; }
        public int Idx { get; set; }
        public string EvalStandardName { get; set; } 
    }
}
