using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using EM.Domain.Classes;

namespace EM.Repository.Repositorios
{
    public abstract class RepositorioAbstrato<T> where T : IEntidade
    {
        public abstract void Add(T objeto);
        public abstract void Remove(T objeto);
        public abstract void Update(T objeto);
        public abstract IEnumerable<T> GetAll();
        public abstract IEnumerable<T> Get(Expression<Func<T,bool>> predicate);
    }
}
