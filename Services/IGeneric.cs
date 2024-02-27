using Gerocery.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerocery.Services
{
    public interface IGeneric<t>
    {
        public  Task<List<Category2>> GetAll();
    }
}
