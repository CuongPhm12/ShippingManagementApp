using Artan.DLL.Context;
using Artan.DLL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artan.DLL.Services
{
    public class RepositoryCondition : IRepositoryCondition
    {
        Artan_DBEntities db_Artan;
        public RepositoryCondition(Artan_DBEntities entities)
        {
            db_Artan = entities;
        }

        public async Task<List<tbl_Condition>> GetAllAsync()
        {
            try
            {
                return await Task.Run(() => db_Artan.tbl_Condition.ToList());

            }
            catch { return null; }
        }
    }
}
