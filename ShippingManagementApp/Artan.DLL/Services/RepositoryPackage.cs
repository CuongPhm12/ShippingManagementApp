using Artan.DLL.Context;
using Artan.DLL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artan.DLL.Services
{
    public class RepositoryPackage:IRepositoryPackage
    {
        Artan_DBEntities db_Artan;
        public RepositoryPackage (Artan_DBEntities entities)
        {
            db_Artan = entities;
        }

        public async Task<List<tbl_Package>> GetAllAsync()
        {
            try
            {
                return await Task.Run(() => db_Artan.tbl_Package.ToList());

            }
            catch { return null; }
        }
    }
}
