using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDronesServices.Repositories
{
    public interface IRepositoryBase<T>
    {
        IEnumerable<T> GetAll();
        void Create(T entity);
    }
}
