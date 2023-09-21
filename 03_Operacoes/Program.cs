Console.WriteLine("Digite o valor de x:");
//Precisamos converter os dados que recebemos do ReadLine
//int.Parse() para converter para inteiro
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor de y:");
int y = int.Parse(Console.ReadLine());

// Exemplos de operadores aritméticos
int soma = x + y;
int subtracao = x - y;
int multiplicacao = x * y;
int divisao = x / y;
int resto = x % y;
int restoDiv2 = x % 2; //#########

Console.WriteLine("Soma: " + soma);
Console.WriteLine("Subtração: " - subtracao);
Console.WriteLine("Multiplicação: " * multiplicacao);
Console.WriteLine("Divisão: " / divisao);
Console.WriteLine("Resto: " % resto);

if (restoDiv2 == 0)
{
    Console.WriteLine($"{x} é par");
}
else
{
    Console.WriteLine($"{x} é ímpar");
}

//Operador ternário
// Condição ? se verdade : senão
string ePar = (restoDiv2 == 0) ? " par " : " ímpar";

switch (dia  semana ){
    case 1 : 
    console.WriteLine("Hoje é Domingo");
    break;

     case 2 : 
    console.WriteLine("Hoje é Segunda");
    break;

     case 3: 
    console.WriteLine("Hoje é Terça");
    break;

     case 4: 
    console.WriteLine("Hoje é Quarta");
    break;

     case 5 : 
    console.WriteLine("Hoje é Quinta");
    break;

     case 6 : 
    console.WriteLine("Hoje é Sexta");
    break;

     case 7 : 
    console.WriteLine("Hoje é Sabado");
    break;

    default:
    Console.WriteLine("Dia invalido");
    break;
} 