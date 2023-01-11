using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repositories
{
    internal class LibraryRepository : IRepository<Library>
    {
        public void Create(Library entity)
        {
            if (entity == null) throw new ArgumentNullException();
        }

        public void Delete(Library entity)
        {
            if(entity == null) throw new ArgumentNullException();
        }

        Library IRepository<Library>.Get(Predicate<Library> predicate)
        {
            throw new NotImplementedException();
        }

        List<Library> IRepository<Library>.GetAll(Predicate<Library> predicate)
        {
            throw new NotImplementedException();
        }

        void IRepository<Library>.Update(Library entity)
        {
            throw new NotImplementedException();
        }
    }
}
