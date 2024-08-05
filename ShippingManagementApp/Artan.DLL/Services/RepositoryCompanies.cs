using Artan.DLL.Context;
using Artan.DLL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artan.DLL.Services
{
    public class RepositoryCompanies : IRepositoryCompanies
    {
        Artan_DBEntities db_Artan;
        public RepositoryCompanies(Artan_DBEntities entities)
        {
            db_Artan = entities;
        }
        public async Task<bool> DuplicateValueAsync(string companyName, string representative)
        {
            try
            {
                await Task.Run(() => db_Artan.vw_Companies.Any(x => x.CompanyName == companyName && x.Representative == representative));
                return true;
            }
            catch { return false; }
        }

        public async Task<List<vw_Companies>> GetAllAsync()
        {
            try
            {
                return await Task.Run(() => db_Artan.vw_Companies.ToList());

            }
            catch { return null; }
        }
        public async Task<bool> InsertAsync(string companyName, string representative, bool companyType, string collaborationDate, string email, string phone, string mobile, string fax, bool status, string address, byte[] pic, string createDate)
        {
            try
            {
                await Task.Run(() => db_Artan.sp_CompanyInsert(companyName, representative, companyType, collaborationDate, email, phone, mobile, fax, status, address, pic, createDate));
                return true;
            }
            catch { return false; }
        }


        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                await Task.Run(() => db_Artan.sp_CompanyDelete(id));
                return true;
            }
            catch { return false; }
        }

        public async Task<List<sp_CompanySearch_Result>> GetSearchAsync(string searchName)
        {
            try
            {
                return await Task.Run(() => db_Artan.sp_CompanySearch(searchName).ToList());

            }
            catch { return null; }
        }


        public async Task<bool> UpdateAsync(int companyId, string companyName, string representative, bool companyType, string collaborationDate, string email, string mobile, string fax, bool status, string address, byte[] pic, string createDate)
        {
            try
            {
                await Task.Run(() => db_Artan.sp_CompanyUpdate(companyId, companyName, representative, companyType, collaborationDate, email, mobile, fax, status, address, pic, createDate));
                return true;
            }
            catch { return false; }
        }


    }
}
