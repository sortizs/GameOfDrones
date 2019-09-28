using System;
using System.Collections.Generic;

namespace gameApi.Repository
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        void Save(T t);
    }
}