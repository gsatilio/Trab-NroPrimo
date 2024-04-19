//1 - faça um programa que leia um número (int, float, etc) e informe se esse número é primo (por ele msm ou 1)//

float numero, numeroantes, resto;
int contador;

Console.WriteLine("Por favor, informe um número:");
numero = float.Parse(Console.ReadLine());
while(numero <= 0)
{
    Console.WriteLine("Por favor, informe um número MAIOR QUE 1:");
    numero = float.Parse(Console.ReadLine());
}
numeroantes = 0;
resto = 0;
contador = 0;

while ((numeroantes <= numero))
{
    resto = (numero % numeroantes);
    if(resto == 0)
    {
        contador++;
    }

    numeroantes++;
}

if (contador == 2){
    Console.WriteLine("O número " + numero + " é um número primo.");
} else
{
    Console.WriteLine("O número " + numero + " NÃO é um número primo.");
}

Console.ReadKey();