using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteParaDesenvolvedor.Model;

namespace TesteParaDesenvolvedor.Core
{
    public class PalavraCore : IPalavra
    {
        public int CalcularMovimentacaoPalavra(Palavras palavras)
        {
            if (palavras.Palavra1.Equals(palavras.Palavra2)) return 0;

            int quantidadeTroca = 0;
            int quantidadeNaoTrocada = 0;
            string novaPalvra = "";
            int tamanhoPalavra1 = palavras.Palavra1.Length;

            for (int i = 0; i < palavras.Palavra2.Length; i++)
            {
                if (tamanhoPalavra1 <= i) break; //Caso a palavra1 for menor que a palvra 2

                if (palavras.Palavra2[i] != palavras.Palavra1[i]) //Verifica se precisa da troca caso sim vai acrescentando
                    quantidadeTroca++;
                else
                    quantidadeNaoTrocada++; //Saber quando não houve nenhuma troca


                novaPalvra += palavras.Palavra2[i];
            }

            if (palavras.Palavra1.Length > palavras.Palavra2.Length)//caso a palavra1 for maior que a 2 temos que remover as demais pegamos a diferença e somamos a quantidade já trocada
                quantidadeTroca += (palavras.Palavra1.Length - palavras.Palavra2.Length - quantidadeNaoTrocada);
            else
                quantidadeTroca += (palavras.Palavra2.Length - palavras.Palavra1.Length);

            return quantidadeTroca;
        }
    }
}
