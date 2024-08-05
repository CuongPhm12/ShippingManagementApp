using Artan.DLL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artan.DLL.Repository
{
    public interface IRepositoryCompanies
    {
        Task<bool> DuplicateValueAsync(string companyName, string representative);
        Task<List<vw_Companies>> GetAllAsync();
        Task<List<sp_CompanySearch_Result>> GetSearchAsync(string searchName);
        Task<bool> InsertAsync(string companyName, string representative, bool companyType, string collaborationDate, 
            string email, string phone, string mobile, string fax, bool status, string address, byte[] pic, string createDate);
        Task<bool> UpdateAsync(int companyId, string companyName, string representative, bool companyType, string collaborationDate,
            string email, string mobile, string fax, bool status, string address, byte[] pic, string createDate);
        Task<bool> DeleteAsync(int id);
    }
}
