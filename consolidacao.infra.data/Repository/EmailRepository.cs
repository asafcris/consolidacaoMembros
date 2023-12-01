using consolidacao.domain.Intefaces;
using consolidacao.domain.Models;
using Framework.NHibernate;
using NHibernate;

namespace Consolidacao.Infra.Data.Repository
{
    public class EmailRepository : Repository<Email>, IEmailRepository
    {
        public EmailRepository(ISession session) : base(session)
        {
        }
    }
}
