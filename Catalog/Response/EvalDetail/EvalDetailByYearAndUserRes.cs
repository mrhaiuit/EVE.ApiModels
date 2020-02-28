using System.Collections.Generic;

namespace EVE.ApiModels.Catalog.Response
{
    public class EvalDetailByYearAndUserRes
    {
        public int Year { get; set; }
        public string EvalResultName { get; set; }
        public string Reason { get; set; }
        public string Attachment { get; set; }
        
    }
}
