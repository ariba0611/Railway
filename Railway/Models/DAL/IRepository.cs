using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Railway.Models.DAL
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetModel();

        T GetModelByID(int ModelId);

        void InsertModel(T model);  

        void UpdateModel(T model);  
        void DeleteModel(int ModelId);
        void Save();

    }
    
}
