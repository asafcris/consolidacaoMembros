

using consolidacao.domain.Models;
using FluentNHibernate.Mapping;

namespace Consolidacao.Infra.Data.Map
{
    internal class PessoaClassMap : ClassMap<Pessoa>
    {
        public PessoaClassMap()
        {
            Table("PROJETO");
            Id(x => x.Id).Column("ID_EMAIL").GeneratedBy.Identity();
            Map(x => x.Nome).Column("NOME");
            Map(x => x.Apelido).Column("APELIDO");
            Map(x => x.DataNascimento).Column("DATA_NASCIMENTO");
            Map(x => x.Sexo).Column("SEXO");
        }
    }
}
