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
        private IRepositoryPost repositoryPost;
        public IRepositoryPost RepositoryPost
        {
            get
            {
                if (repositoryPost == null)
                {
                    repositoryPost = new RepositoryPost(dbArtan);
                }
                return repositoryPost;
            }
        }

        private IRepositoryPackage repositoryPackage;
        public IRepositoryPackage RepositoryPackage
        {
            get
            {
                if (repositoryPackage == null)
                {
                    repositoryPackage = new RepositoryPackage(dbArtan);
                }
                return repositoryPackage;
            }
        }

        private IRepositoryCondition repositoryCondition;
        public IRepositoryCondition RepositoryCondition
        {
            get
            {
                if (repositoryCondition == null)
                {
                    repositoryCondition = new RepositoryCondition(dbArtan);
                }
                return repositoryCondition;
            }
        }
        public void Dispose()
        {
            dbArtan.Dispose();
        }
    }
}
