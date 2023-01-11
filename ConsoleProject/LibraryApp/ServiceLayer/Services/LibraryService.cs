using DomainLayer.Entities;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class LibraryService : ILibraryService
    {
        private readonly ILibraryService _repo;
        private int _count;
        public LibraryService()
        {
           _repo= new LibraryService();
        }

        public Library Create(Library library) 
        {
            library.Id = _count;
            _repo.Create(library);
            return library; 
        }

        public List<Library> GetAll()
        {
            throw new NotImplementedException();
        }

        public Library GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Library> Search(string searchText)
        {
            throw new NotImplementedException();
        }
    }
}
