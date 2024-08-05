using Artan.DLL.Repository;
using Artan.DLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artan.DLL.Context
{
    public class UnitOfWork : IDisposable
    {
        private Artan_DBEntities dbArtan = new Artan_DBEntities();
        private IRepositoryPersons repositoryPersons;
        
        public IRepositoryPersons RepositoryPersons
        {
            get
            {
                if (repositoryPersons == null)
                {
                    repositoryPersons = new RepositoryPersons(dbArtan);
                }
                return repositoryPersons;
            }
        }
        private IRepositoryCompanies repositoryCompanies;

        public IRepositoryCompanies RepositoryCompanies
        {
            get
            {
                if (repositoryCompanies == null)
                {
                    repositoryCompanies = new RepositoryCompanies(dbArtan);
                }
                return repositoryCompanies;
            }
        }

        public void Dispose()
        {
            dbArtan.Dispose();
        }
    }
}
