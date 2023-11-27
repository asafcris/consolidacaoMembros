using consolidacao.domain.Models;
using FluentNHibernate.Mapping;
using NHibernate.Type;

namespace Consolidacao.Infra.Data.Map
{
    public class EmailClassMap : ClassMap<Email>
    {
        public EmailClassMap()
        {
            Table("PROJETO");
            Id(x => x.Id).Column("ID_EMAIL").GeneratedBy.Identity();
            Map(x => x.Descricao).Column("EMAIL");
            Map(x => x.TipoEmail).Column("TIPO").CustomType(typeof(EnumCharType<EnumTipo>));
            References(x => x.Pessoa).Column("ID_PESSOA");
        }
    }
}
