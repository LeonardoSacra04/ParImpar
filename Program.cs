double numero;
double imparPar;

Console.Clear();

Console.WriteLine("Digite um número: ");
numero = Convert.ToDouble(Console.ReadLine());
imparPar = numero % 2;

if (imparPar != 0)
{
    Console.WriteLine($"O número {numero} é ímpar!");
}
else
{
    Console.WriteLine($"O número {numero} é par!");
}