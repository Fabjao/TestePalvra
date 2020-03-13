using System;
using TesteParaDesenvolvedor.Core;
using TesteParaDesenvolvedor.Model;
using Xunit;

namespace XUnitParaTesteDesenvolvedor
{
    public class UnitTest1
    {
        [Fact]
        public void CalcularMovimentacaoPalavra()
        {
            PalavraCore core = new PalavraCore();

            var palavras = new Palavras
            {
                Palavra1 = "cavalo",
                Palavra2 = "pato"
            };

            var result = core.CalcularMovimentacaoPalavra(palavras);

        }
    }
}
