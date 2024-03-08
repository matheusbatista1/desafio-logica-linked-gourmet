using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_A
{
    internal static class Util
    {
        public static Resultado LerPrimeiraLinhaInput(string msg)
        {
            var resultado = new Resultado();
            Console.WriteLine(msg);
            string[] entrada = Console.ReadLine().Split(' ');

            if (entrada.Length == 2)
            {
                if (Convert.ToInt32(entrada[0]) >= 1 && Convert.ToInt32(entrada[0]) <= 6)
                {
                    resultado.QuantidadeBrinquedo = Convert.ToInt32(entrada[0]);
                }
                else
                {
                    Console.WriteLine("\nERRO: A quantidade de brinquedos precisa ser entre 1 e 6!\n");
                    resultado.Sucesso = false;
                    return resultado;
                }
                if (Convert.ToInt32(entrada[1]) >= 90 && Convert.ToInt32(entrada[1]) <= 200)
                {
                    resultado.AlturaPessoa = Convert.ToInt32(entrada[1]);
                }
                else
                {
                    Console.WriteLine("\nERRO: A altura precisa ser entre 90 e 200 cm!\n");
                    resultado.Sucesso = false;
                    return resultado;
                }
                resultado.Sucesso = true;
                return resultado;
            }
            else
            {
                Console.WriteLine("\nERRO: Digite a quantidade de brinquedos e a altura separados por espaço corretamente!\n");
                resultado.Sucesso = false;
                return resultado;
            }
        }
        public static Resultado LerSegundaLinhaInput(string msg, int quantidadeBrinquedos)
        {
            var resultado = new Resultado();
            Console.WriteLine(msg);
            string[] entrada = Console.ReadLine().Split(' ');


            if (entrada.Length == quantidadeBrinquedos)
            {
                foreach (string value in entrada)
                {
                    if (!string.IsNullOrEmpty(value) && Convert.ToInt32(value) >= 90 && Convert.ToInt32(value) <= 200)
                    {
                        resultado.AlturasPermitidas.Add(Convert.ToInt32(value));
                    }
                    else
                    {
                        resultado.Sucesso = false;
                        return resultado;
                    }
                }
                resultado.Sucesso = true;
                return resultado;
            }
            else
            {
                Console.WriteLine($"\nERRO: Digite a altura permitida de todos os {quantidadeBrinquedos} brinquedos!\n");
                resultado.Sucesso = false;
                return resultado;
            }
        }
    }
}
