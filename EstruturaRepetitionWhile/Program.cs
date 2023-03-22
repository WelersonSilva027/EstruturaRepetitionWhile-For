//While vai sempre repetir um bloco de comandos enquanto a condição for verdadeira.

//while (condição)

/*
 * int e = 10;
while (e <= 10)
{
    Console.WriteLine(e);
    e++;  //Vai seguir atribuindo sempre +1 valor (sequêncial) na condição/variavel...até chegar no 10.
    //se atribuirmos o valor 11 na linha 5, sem alterar o limite de atribuição no WHILE (linha 6), o código não vai rodar pq o limite de atribuição já foi ultrapassado, então o código não tem o que acrescentar...parando de rodar.

}*/


/*
 int[] arInt = new int[] {1, 2, 3, 4, 5};

int i  = 0;
while (i <= arInt.Length)
{
    int numero = arInt[i];
    Console.WriteLine(numero);

} */

    int[] arInt = new int[] { 1, 2, 3, 4, 5 };

    for (int j = 0; j < arInt.Length; j++)
    {
        int numero = arInt[j];
        Console.WriteLine(j);
    }