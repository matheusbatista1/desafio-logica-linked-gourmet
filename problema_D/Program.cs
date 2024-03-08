using problema_D;

bool entradaValida;
Resultado resultado;
do
{
    resultado = Util.LerInputInformacoes("Digite o número de competidores: ");
    entradaValida = resultado.Sucesso;
}
while (entradaValida is false);

Console.WriteLine("\nQuantidade de classificados é: " + resultado.classificados );
