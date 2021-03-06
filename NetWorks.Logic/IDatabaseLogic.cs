﻿using NetWorks.Core.Domain;
using NetWorks.DataAccess.Repositories;

namespace NetWorks.Logic
{
    public interface IDatabaseLogic<TEntity> where TEntity : BaseEntity, new()
    {
        IRepo<TEntity> Repo { get; }

        IPagedList<TEntity> GetAll(int pageIndex = 0, int pageSize = int.MaxValue);

        TEntity Find(int id);

        int Add(TEntity entity);

        int Update(TEntity entity);

        int Delete(TEntity entity);

        int Delete(int id);
    }
}