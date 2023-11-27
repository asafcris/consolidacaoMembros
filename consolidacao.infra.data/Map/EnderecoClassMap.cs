using consolidacao.domain.Models;
using FluentNHibernate.Mapping;


namespace Consolidacao.Infra.Data.Map
{
    public class EnderecoClassMap : ClassMap<Endereco>
    {
        public EnderecoClassMap()
        {
            Table("ENDERECO");
            Id(x => x.Id).Column("ID_ENDERECO").GeneratedBy.Identity();
            Map(x => x.Cep).Column("CEP");
            Map(x => x.Logradouro).Column("LOGRADOURO");
            Map(x => x.Bairro).Column("BAIRRO");
            Map(x => x.Cidade).Column("CIDADE");
            Map(x => x.Complemento).Column("COMPLEMENTO");
            Map(x => x.PontoReferencia).Column("PONTO_REFERENCIA");

            References(x => x.Pessoa).Column("ID_PESSOA");
        }
    }
}
