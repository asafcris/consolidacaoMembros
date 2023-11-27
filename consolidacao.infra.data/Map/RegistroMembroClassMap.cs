using consolidacao.domain.Models;
using FluentNHibernate.Mapping;

namespace Consolidacao.Infra.Data.Map
{
    public class RegistroMembroClassMap : ClassMap<RegistroMembro>
    {
        public RegistroMembroClassMap()
        {
            Table("REGISTRO_MEMBRO");
            Id(x => x.Id).Column("ID_REGISTRO_MEMBRO").GeneratedBy.Identity();
            Map(x => x.DataConversao).Column("DATA_CONVERSAO");
            Map(x => x.DataBatismo).Column("DATA_BATISMO");
            References(x => x.Pessoa).Column("ID_PESSOA");
        }
    }
}
