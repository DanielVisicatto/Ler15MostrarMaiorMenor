using System.Globalization;

float[] numbers = new float[15];
float maior, menor;

for (int i = 0; i < 15; i++)
{
    Console.Write("Digite um numero para a {0}ª posição: ", i + 1);
    numbers[i] = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Clear();
}
for(int i = 0;i < 15; i++)
{
    Console.Write(", ", numbers[i]);
}

//maior = numbers.Max();
//menor = numbers.Min();

maior = numbers[0];
menor = numbers[0];

for (int i = 0; i < 15; i++)
{
    if(maior < numbers[i])
        maior = numbers[i];
}

for (int i = 0; i < 15; i++)
{
    if (menor > numbers[i])
        menor = numbers[i];
}


Console.Write("Maior número digitado: {0}\n" +
    "Menor número digitado: {1}", maior.ToString("F2"), menor.ToString("F2"));