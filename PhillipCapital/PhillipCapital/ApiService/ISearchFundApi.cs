using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PhillipCapital.Model.Dashboard;
using PhillipCapital.Model.SearchFund;

namespace PhillipCapital.ApiService
{
    public interface ISearchFundApi
    {
        [Get("/api/")]
        Task<List<FundResult>> GetListFund();

        [Get("/api/")]
        Task<List<General>> GetListGeneralFund();

        [Get("/api/")]
        Task<List<Retirement>> GetListRetirementFund();

        [Get("/api/")]
        Task<List<AMCs>> GetListAMCs();
    }
}
