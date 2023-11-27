using NHibernate;
using System.Linq.Expressions;

namespace Framework.NHibernate
{
    public class Repository<T> : IRepository<T>
    {

        private ISession _session;
        public Repository(ISession session)
        {
            _session = session;
        }
        public T GetById(int id)
        {
            T entity;

            entity = (T)_session.Load(persitentType, id, LockMode.Read);

            return entity;
        }

        object IRepository.GetById(int id)
        {
            return GetById(id);
        }

        public IQueryable<T> GetAll()
        {
            return _session.Query<T>();
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> where)
        {
            return _session.Query<T>().Where(where);
        }

        public T Save(T entity)
        {
            _session.SaveOrUpdate(entity);
            CommitTran();
            return entity;
        }

        public void Save(IList<T> entities)
        {

            foreach (T item in entities)
            {
                Save(item);
            }
            CommitTran();
        }

        public void Delete(T entity)
        {
            _session.Delete(entity);
        }

        public void BeginTran()
        {
            _session.BeginTransaction();
        }

        public void CommitTran()
        {
            _session.BeginTransaction().Commit();
        }

        public void RollbackTran()
        {
            _session.BeginTransaction().Rollback();
        }

        public void Evict(Object obj)
        {
            _session.Evict(obj);
        }

        public bool Exist(System.Linq.Expressions.Expression<Func<T, bool>> where)
        {
            return _session.Query<T>().Any(where);
        }

        #region Privados


        protected Type persitentType = typeof(T);

        #endregion


    }
}
