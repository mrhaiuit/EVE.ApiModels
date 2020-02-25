using EVE.Data;
using System.Collections.Generic;

namespace EVE.ApiModels.Catalog.Response
{
    public class EvalResultSumaryRes 
    {
        public int Total { get; set; }  // Tổng điểm
        public int Everage { get; set; } = 0; // Điểm trung bình
        public int TotalCriteria { get; set; } = 0; // Tổng số tiêu chí
        public int TotalCriteriaHasValue { get; set; } // Tổng số tiêu chí đã đánh giá
        public string EvalResultCode { get; set; } = string.Empty; // Mã kết quả
        public string EvalResultName { get; set; } = string.Empty; // Giá trị kết quả(Đat, không đạt ..)
    }
}
