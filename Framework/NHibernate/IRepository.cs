using System.Linq.Expressions;

namespace Framework.NHibernate
{
    public interface IRepository<T> : IRepository
    {
        new T GetById(int id);
        IQueryable<T> GetAll();
        IQueryable<T> Find(Expression<Func<T, bool>> where);
        bool Exist(Expression<Func<T, bool>> where);
        T Save(T entity);
        void Save(IList<T> entities);
        void Delete(T entity);
        void BeginTran();
        void CommitTran();
        void RollbackTran();
        void Evict(Object obj);

    }
    public interface IRepository
    {
        object GetById(int id);
    }
}