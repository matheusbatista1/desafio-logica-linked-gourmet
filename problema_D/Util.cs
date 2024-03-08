using problema_D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_D
{
    internal static class Util
    {
        public static Resultado LerInputInformacoes(string msg)
        {
            var resultado = new Resultado();
            Console.WriteLine(msg);
            resultado.numeroCompetidores = int.Parse(Console.ReadLine());

            if (resultado.numeroCompetidores >= 1 && resultado.numeroCompetidores <= 1000)
            {
                Console.WriteLine("Digite o número minimo de competidores que vão se classificar: ");
                resultado.numeroMinimoCompetidores = int.Parse(Console.ReadLine());

                Console.WriteLine($"Digite separado por espaço a pontuação de todos os {resultado.numeroCompetidores} competidores: ");
                int[] entradaPontuacoes = new int[resultado.numeroCompetidores];

                for (int i = 0; i < resultado.numeroCompetidores; i++)
                {
                    entradaPontuacoes[i] = int.Parse(Console.ReadLine());
                }

                foreach (int value in entradaPontuacoes)
                {
                    resultado.pontuacao.Add(value);
                }

                resultado.pontuacao.Sort((a, b) => b.CompareTo(a));

                int classificados = CalculaClassificados(resultado.pontuacao, resultado.numeroMinimoCompetidores);
                resultado.classificados = classificados;
            }
            else
            {
                Console.WriteLine($"ERRO: Quantidade de competidores inválida! digite um número de competidores entre 1 e 1000. \n");
                resultado.Sucesso = false;
                return resultado;
            }
            resultado.Sucesso = true;
            return resultado;
        }

        static int CalculaClassificados(List<int> pontuacoes, int competidoresMinimos)
        {
            int pontuacaoMinima = pontuacoes[competidoresMinimos - 1];

            int classificados = pontuacoes.Count(p => p >= pontuacaoMinima);

            return classificados;
        }
    }
}
