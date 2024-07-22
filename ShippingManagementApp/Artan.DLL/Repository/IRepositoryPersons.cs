using Artan.DLL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artan.DLL.Repository
{
    public interface IRepositoryPersons
    {
        Task<bool> DuplicateValueAsync(string fullName, string userName);
        Task<bool> LoginAsync(string userName, string password, int position);
        Task<List<vw_Persons>> GetAllAsync();
        Task<List<sp_PersonSearch_Result>> GetSearchAsync(string searchName);
        Task<bool> InsertAsync(string firstName, string lastName, bool gender, string birthDate, int educationID,
            string email, string mobile, bool condition, string address, int positionID, string userName, string password, string createDate);
        Task<bool> UpdateAsync(int personId, string firstName, string lastName, bool gender, string birthDate, int educationID,
            string email, string mobile, bool condition, string address, int positionID, string userName, string password, string createDate);
        Task<bool> DeleteAsync(int id);

    }
}
