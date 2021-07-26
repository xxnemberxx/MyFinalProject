﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    // Generic Constraint - where
    // class : referance type
    // IEntity -> IEntity olabilir ya da implemente eden bir nesne olabilir
    // new() : Oluşturulan, yer tutan bir nesne olabilir 
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(List<T> entities);
        void Update(T entityId);
        void Delete(List<T> entities);
    }
}