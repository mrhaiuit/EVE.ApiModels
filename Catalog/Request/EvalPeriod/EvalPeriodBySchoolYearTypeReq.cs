namespace EVE.ApiModels.Catalog
{
    public class EvalPeriodBySchoolYearTypeReq
    {
        public int SchoolId { get; set; }
        public int Year { get; set; }
        public string EvalTypeCode { get; set; }
    }
}
