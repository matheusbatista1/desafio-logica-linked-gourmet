using problema_B;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_B
{
    internal static class Util
    {
        public static Resultado InputTestes(string msg)
        {
            var resultado = new Resultado();
            Console.WriteLine(msg);
            var entrada = int.Parse(Console.ReadLine());
            if (entrada >= 1 && entrada <= 1000)
            {
                resultado.quantidadeTestes = entrada;
                resultado.Sucesso = true;
                return resultado;
            }
            else
            {
                Console.WriteLine($"Quantidade inválida.");
                resultado.Sucesso = false;
                return resultado;
            }
        }
        public static Resultado InputTrechos(string msg, int quantidadeTestes)
        {
            var resultado = new Resultado();
            Console.WriteLine(msg);

            string[] entrada = new string[quantidadeTestes];

            for (int i = 0; i < quantidadeTestes; i++)
            {
                Console.WriteLine($"Digite o trecho de número {i + 1}: ");
                entrada[i] = Console.ReadLine();
            }
            if (entrada.Length != quantidadeTestes)
            {
                Console.WriteLine($"ERRO: você deve digitar {quantidadeTestes} trechos.");
                resultado.Sucesso = false;
                return resultado;
            }

            foreach (string trecho in entrada)
            {
                resultado.trechos.Add(trecho);
            }

            int contador = 0;
            foreach (string value in resultado.trechos)
            {
                if (value.Length > 80)
                {
                    Console.WriteLine($"ERRO: trecho {contador} com mais de 80 caracteres");
                    resultado.Sucesso = false;
                    return resultado;
                }
                else
                {
                    contador++;
                    foreach (char c in value)
                    {
                        resultado.quantidadeVogais = 0;
                        resultado.quantidadeConsoantes = 0;
                        if (!(!Char.IsLetterOrDigit(c) && c != ' ' && c != '?' && c != '!' && c != '.' && c != ','))
                        {
                            foreach (char letra in value)
                            {
                                if (char.IsLetter(letra))
                                {
                                    if ("ABCDEFGHIJKLMNOPQRSTUVWXYZ".Contains(letra))
                                    {
                                        Console.WriteLine($"ERRO: trecho {contador} contem letra(s) maiúscula(s)\n");
                                        resultado.Sucesso = false;
                                        return resultado;
                                    }
                                    if ("áàâãéèêíïóôõöúçñ".Contains(letra) || "ÁÀÂÃÉÈÊÍÏÓÔÕÖÚÇÑ".Contains(letra))
                                    {
                                        Console.WriteLine($"ERRO: trecho {contador} contem letra(s) acentuada(s)\n");
                                        resultado.Sucesso = false;
                                        return resultado;
                                    }
                                    else
                                    {
                                        if ("aeiou".Contains(letra))
                                        {
                                            resultado.quantidadeVogais++;
                                        }
                                        else
                                        {
                                            resultado.quantidadeConsoantes++;
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine($"ERRO: trecho {contador} inválido");
                            resultado.Sucesso = false;
                            return resultado;
                        }
                    }
                }
                Console.WriteLine($"Número de vogais do trecho {contador}: >>> {resultado.quantidadeVogais} <<<");
                Console.WriteLine($"Número de consoantes do trecho {contador}: >>> {resultado.quantidadeConsoantes} <<<\n\n");
            }

            resultado.Sucesso = true;
            return resultado;
        }
    }
}
