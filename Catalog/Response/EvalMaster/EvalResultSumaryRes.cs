using EVE.Data;
using System.Collections.Generic;

namespace EVE.ApiModels.Catalog.Response
{
    public class EvalResultSumaryRes 
    {
        public int Total { get; set; }
        public int Everage { get; set; } = 0;
        public int TotalCriteria { get; set; } = 0;
        public int TotalCriteriaHasValue { get; set; }
        public string EvalResultCode { get; set; } = string.Empty;
        public string EvalResultName { get; set; } = string.Empty;
    }
}
