using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PhillipCapital.Model.Dashboard;
using Refit;

namespace PhillipCapital.ApiService
{
    public interface IDashboardApi
    {
        [Get("/api/")]
        Task<CurrentPortfolioValueModel> GetCurrentPortfolioValue();

        [Get("/api/")]
        Task<List<FundTopPickModel>> GetListTopPickFund();
    }
}
