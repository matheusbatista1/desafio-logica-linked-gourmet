using problema_A;

bool entradaValida;
Resultado resultadoPrimeiraLinha;
Resultado resultadoSegundaLinha;
do
{
    resultadoPrimeiraLinha = Util.LerPrimeiraLinhaInput("Digite a quantidade de brinquedos (de 1 a 6) e em seguida separado por espaço, digite sua altura em cm (de 90 a 200): ");
    entradaValida = resultadoPrimeiraLinha.Sucesso;
}
while (entradaValida is false);


do
{
    resultadoSegundaLinha = Util.LerSegundaLinhaInput($"Digite a altura permitida de cada um dos {resultadoPrimeiraLinha.QuantidadeBrinquedo} brinquedos:  ", resultadoPrimeiraLinha.QuantidadeBrinquedo);
    entradaValida = resultadoSegundaLinha.Sucesso;
}
while (entradaValida is false);

int quantidadeBrinquedosPermitidos = 0;
foreach (var alturaPermitida in resultadoSegundaLinha.AlturasPermitidas)
{
    if (resultadoPrimeiraLinha.AlturaPessoa >= alturaPermitida )
    {
        quantidadeBrinquedosPermitidos++;
    }
}
Console.WriteLine("Quantidade de brinquedos permitidos para brincar: " + quantidadeBrinquedosPermitidos);
