using Framework.Util;

namespace consolidacao.domain.Models
{
    public enum EnumTipo
    {
        [CodigoBd("P")]
        [NomeExibicao("Pessoal")]
        Pessoal,

        [CodigoBd("C")]
        [NomeExibicao("Comercial")]
        Comercial
    }
    public enum EnumSexo
    {
        [CodigoBd("M")]
        [NomeExibicao("Masculino")]
        Masculino,

        [CodigoBd("F")]
        [NomeExibicao("Feminino")]
        Feminino
    }
}
