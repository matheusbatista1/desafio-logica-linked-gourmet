using problema_C;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_C
{
    internal static class Util
    {
        public static Resultado LerInputInformacoes(string msg)
        {
            var resultado = new Resultado();
            Console.WriteLine(msg);
            resultado.numeroCompetidores = int.Parse(Console.ReadLine());

            if (resultado.numeroCompetidores >= 2 && resultado.numeroCompetidores <= 36)
            {
                Console.WriteLine($"Agora digite em ORDEM DE LARGADA os números de cada um dos participantes de {resultado.numeroCompetidores} separados por espaço: ");
                string[] entradaPosicoesIniciais = Console.ReadLine().Split(' ');

                if (entradaPosicoesIniciais.Length == resultado.numeroCompetidores)
                {
                    foreach (string value in entradaPosicoesIniciais)
                    {
                        resultado.posicoesIniciais.Add(Convert.ToInt32(value));
                    }

                }
                else
                {
                    Console.WriteLine($"ERRO: Quantidade de competidores inválida! Digite a orde de largada dos {resultado.numeroCompetidores} competidores separados por espaço!\n");
                    resultado.Sucesso = false;
                    return resultado;
                }


                Console.WriteLine($"Agora digite em ORDEM DE CHEGADA os números de cada um dos participantes de {resultado.numeroCompetidores} separados por espaço: ");
                string[] entradaPosicoesFinais = Console.ReadLine().Split(' ');

                if (entradaPosicoesFinais.Length == resultado.numeroCompetidores)
                {
                    foreach (string value in entradaPosicoesFinais)
                    {
                        resultado.posicoesFinais.Add(Convert.ToInt32(value));
                    }
                }
                else
                {
                    Console.WriteLine($"ERRO: Quantidade de competidores inválida! Digite a orde de chegada dos {resultado.numeroCompetidores} competidores separados por espaço!\n");
                    resultado.Sucesso = false;
                    return resultado;
                }
            }
            else
            {
                Console.WriteLine($"ERRO: Quantidade de competidores inválida! Digite uma quantidade de 2 a 36!\n");
                resultado.Sucesso = false;
                return resultado;
            }
            resultado.Sucesso = true;
            return resultado;
        }
    }
}
