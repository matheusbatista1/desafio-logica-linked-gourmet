using problema_C;

bool entradaValida;
Resultado resultado;
do
{
    resultado = Util.LerInputInformacoes("Digite o número de pilotos que vão participar da corrida: ");
    entradaValida = resultado.Sucesso;
}
while (entradaValida is false);

bool encontrouNaMesmaPosicao = true;
int ultrapassagens = 0;
for (int inicialIndex = 0; inicialIndex < resultado.numeroCompetidores; inicialIndex++)
{
    var posInicialValor = resultado.posicoesIniciais[inicialIndex];
    for (int posFinalIndex = 0; posFinalIndex < resultado.posicoesFinais.Count; posFinalIndex++)
    {
        if (encontrouNaMesmaPosicao && resultado.posicoesIniciais[posFinalIndex] == resultado.posicoesFinais[posFinalIndex])
        {
            ultrapassagens++;
            encontrouNaMesmaPosicao = false;
            break;
        }
        var posFinalValor = resultado.posicoesFinais[posFinalIndex];
        var finalIndex = resultado.posicoesFinais.IndexOf(posInicialValor);
        if (posInicialValor == posFinalValor) break;
        else if (inicialIndex != finalIndex && inicialIndex < finalIndex)
        {
            var qtdPosPerdida = (finalIndex - inicialIndex);
            ultrapassagens += qtdPosPerdida;
            break;
        }
    }
}
Console.WriteLine("Quantidade de ultrapassagem minima é de: " + ultrapassagens);
