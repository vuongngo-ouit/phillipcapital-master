using System;
using System.Collections.Generic;
using System.Text;

namespace PhillipCapital.Model.Dashboard
{
    public class CurrentPortfolioValueModel
    {
        public int Id { get; set; }
        public double Value { get; set; }
        public double ValueChangePercent { get; set; }
        public double ValueChange { get; set; }
    }
}
