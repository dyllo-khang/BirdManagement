using BusinessObject.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class TypeService : ITypeService
    {
        private ITypeRepository _typeRepository;
        public TypeService() 
        { 
           _typeRepository = new TypeRepository();
        }

        public List<TypeProduct> GetAll() => _typeRepository.GetAll();
    }
}
