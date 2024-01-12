using consolidacao.domain.Intefaces;
using consolidacao.domain.Models;
using Framework.NHibernate;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolidacao.Infra.Data.Repository
{
    public class PessoaRepository : Repository<Pessoa>, IPessoaRepository
    {
        public PessoaRepository(ISession session) : base(session)
        {

        }
    }
}
