using Artan.DLL.Context;
using Artan.DLL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artan.DLL.Services
{
    public class RepositoryPersons : IRepositoryPersons
    {
        Artan_DBEntities db_Artan;
        public RepositoryPersons(Artan_DBEntities entities)
        {
            db_Artan = entities;
        }
        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                await Task.Run(() => db_Artan.sp_PersonDelete(id));
                return true;
            }
            catch { return false; }
        }

        public async Task<bool> DuplicateValueAsync(string fullName, string userName)
        {
            try
            {
                await Task.Run(() => db_Artan.vw_Persons.Any(x => x.FullName == fullName && x.UserName == userName));
                return true;
            }
            catch { return false; }

        }

        public async Task<List<vw_Persons>> GetAllAsync()
        {
            try
            {
                return await Task.Run(() => db_Artan.vw_Persons.ToList());

            }
            catch { return null; }
        }

        public async Task<List<sp_PersonSearch_Result>> GetSearchAsync(string searchName)
        {
            try
            {
                return await Task.Run(() => db_Artan.sp_PersonSearch(searchName).ToList());

            }
            catch { return null; }
        }

        public async Task<bool> InsertAsync(string firstName, string lastName, bool gender, string birthDate, int educationID, string email, string mobile, bool condition, string address, int positionID, string userName, string password, string createDate)
        {
            try
            {
                await Task.Run(() => db_Artan.sp_PersonInsert(firstName, lastName, gender, birthDate, educationID, email, mobile, condition, address, positionID, userName, password, createDate));
                return true;
            }
            catch { return false; }
        }

        public async Task<bool> UpdateAsync(int personId, string firstName, string lastName, bool gender, string birthDate, int educationID, string email, string mobile, bool condition, string address, int positionID, string userName, string password, string createDate)
        {
            try
            {
                await Task.Run(() => db_Artan.sp_PersonUpdate(personId,  firstName, lastName,  gender, birthDate,  educationID,  email, mobile, condition,  address, positionID, userName, password,  createDate));
                return true;
            }
            catch { return false; }
        }
    }
}
