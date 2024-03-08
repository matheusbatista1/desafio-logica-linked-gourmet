using problema_B;

bool entradaValida;
Resultado resultadoInputTestes;
Resultado resultadoInputPalavras;
do
{
    resultadoInputTestes = Util.InputTestes("Digite a quantidade de testes que deseja fazer entre 1 e 1000: ");
    entradaValida = resultadoInputTestes.Sucesso;
}
while (entradaValida is false);


do
{
    resultadoInputPalavras = Util.InputTrechos($"Digite {resultadoInputTestes.quantidadeTestes} trechos com no máximo 80 caracteres: ", resultadoInputTestes.quantidadeTestes);
    entradaValida = resultadoInputPalavras.Sucesso;
}
while (entradaValida is false);