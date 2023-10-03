Console.WriteLine("Digite o tamanho do vetor A");
int n = int.Parse(Console.ReadLine());

int[] VetA = new int[n];

Console.WriteLine("Digite o tamanho do vetor B");
int m = int.Parse(Console.ReadLine());
int[] VetB = new int[m];

Console.WriteLine("Digite os elementos do vetor A");
for (int i = 0; i < n; i++)
{
    VetA[i] = int.Parse(Console.ReadLine());

}

Console.WriteLine("Digite os elementos do vetor B");
for (int i = 0; i < m; i++)
{
    VetB[i] = int.Parse(Console.ReadLine());

}

int maiorvetor;
maiorvetor = 0;

if (n > m)
{
    maiorvetor = n;
}
else
{
    maiorvetor = m;
}

Console.WriteLine("Soma dos elementos correspondentes:");
int[] VetC = new int[maiorvetor];

for (int i = 0; i < maiorvetor; i++)
{
    int valorA = i < n ? VetA[i] : 0; 
    int valorB = i < m ? VetB[i] : 0;
    
    VetC[i] = valorA + valorB;
    Console.WriteLine(VetC[i]);
}