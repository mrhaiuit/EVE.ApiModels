using EVE.Data;
using System;
using System.Collections.Generic;

namespace EVE.ApiModels.Catalog.Response
{
    public class EvalCriteriaSchoolLevelRes 
    {
        public int EvalCriteriaId { get; set; }
        public Nullable<int> EvalStandardId { get; set; }
        public string EvalCriteriaCode { get; set; }
        public string EvalCriteriaName { get; set; }
        public Nullable<bool> Active { get; set; }
        public string Idx { get; set; }
        public string EvalStandardName { get; set; } 
    }
}
