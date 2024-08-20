using Artan.DLL.Context;
using Artan.DLL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artan.DLL.Services
{
    public class RepositoryPost : IRepositoryPost
    {
        Artan_DBEntities db_Artan;
        public RepositoryPost(Artan_DBEntities entities)
        {
            db_Artan = entities;
        }

        public async Task<List<tbl_Post>> GetAllAsync()
        {
            try
            {
                return await Task.Run(() => db_Artan.tbl_Post.ToList());

            }
            catch { return null; }
        }
    }
}
