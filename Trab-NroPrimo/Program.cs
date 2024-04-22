//1 - faça um programa que leia um número (int, float, etc) e informe se esse número é primo (por ele msm ou 1)//

float numero, numeroantes, resto;
string sair;
int contador;
sair = "N";

while (sair != "S" && sair != "s")
{
    Console.WriteLine("-----------------------------------------------------------");
    Console.WriteLine("Por favor, informe um número para saber se ele é do tipo primo ou não:");
    numero = float.Parse(Console.ReadLine());
    while (numero <= 0)
    {
        Console.WriteLine("Por favor, informe um número que seja MAIOR QUE 1:");
        numero = float.Parse(Console.ReadLine());
    }
    numeroantes = 0;
    resto = 0;
    contador = 0;

    while ((numeroantes <= numero))
    {
        resto = (numero % numeroantes);
        if (resto == 0)
        {
            contador++;
        }

        numeroantes++;
    }

    /*if (contador == 2)
    {
        Console.WriteLine("O número " + numero + " é um número primo.");
    }
    else
    {
        Console.WriteLine("O número " + numero + " NÃO é um número primo.");
    }*/
    switch (contador)
    {
        case 2:
            Console.WriteLine("O número " + numero + " é um número primo.");
            break;
        default:
            Console.WriteLine("O número " + numero + " NÃO é um número primo.");
            break;
    }

    Console.WriteLine("Digite S para sair do programa ou aperte qualquer tecla para repetir.");
    sair = Console.ReadLine();
    if (sair != "S" && sair != "s")
    {
        Console.Clear();
    }
}

Console.ReadKey();