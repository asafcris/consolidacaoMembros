using consolidacao.domain.Models;
using FluentNHibernate.Mapping;
using NHibernate.Type;

namespace Consolidacao.Infra.Data.Map
{
    public class TelefoneClassMap : ClassMap<Telefone>
    {
        public TelefoneClassMap()
        {
            Table("TELEFONE");
            Id(x => x.Id).Column("ID_TELEFONE").GeneratedBy.Identity();
            Map(x => x.Numero).Column("EMAIL");
            Map(x => x.TipoTelefone).Column("TIPO").CustomType(typeof(EnumCharType<EnumTipo>));
            References(x => x.Pessoa).Column("ID_PESSOA");
        }
    }
}
