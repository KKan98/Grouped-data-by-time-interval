using System;
using System.Collections.Generic;
using System.Text;

namespace GroupedData.Infrastructure
{
    public interface IInMemoryDb<T>
    {
        T Get(Guid id);
        IEnumerable<T> GetAll();
        void Add(T entity);
    }
}
