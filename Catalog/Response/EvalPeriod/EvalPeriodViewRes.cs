using EVE.Data;
using System.Collections.Generic;

namespace EVE.ApiModels.Catalog.Response
{
    public class EvalPeriodViewRes : EvalPeriodBaseRes
    {
        public string State { get; set; }
        public int JoinTotal { get; set; }
        public int Under { get; set; }
        public int Medium { get; set; }
        public int SermiGood { get; set; }
        public int Good { get; set; }
    }
}
