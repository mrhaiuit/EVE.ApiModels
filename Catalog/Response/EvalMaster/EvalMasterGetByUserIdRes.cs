using EVE.Data;
using System;
using System.Collections.Generic;

namespace EVE.ApiModels.Catalog.Response
{
    public class EvalMasterGetByUserIdRes
    {
        public int MasterId { get; set; }  // Tổng điểm
        public int? Year { get; set; }
        public string Period { get; set; }
        public string EvalEmployee { get; set; }
        public string BeEvalEmployee { get; set; } 
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public bool? Approveed { get; set; }
        public int TotalEval { get; set; } = 0;
        public string Class { get; set; }
    }
}
