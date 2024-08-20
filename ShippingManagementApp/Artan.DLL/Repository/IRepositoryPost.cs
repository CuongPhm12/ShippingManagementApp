using Artan.DLL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artan.DLL.Repository
{
    public interface IRepositoryPost
    {
        Task<List<tbl_Post>> GetAllAsync();
    }
}
