using System.Collections.Generic;

namespace NetWorks.Logic
{
    public interface IPagedList<T> : IList<T>, IPagedData
    {
    }
}