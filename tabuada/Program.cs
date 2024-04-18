int n1 = 0, tabuada = 0;

Console.WriteLine("Digite o numero: ");
n1=int.Parse(Console.ReadLine());

for (int i = 0; i<11 && n1>0; i++)
{
    tabuada = n1 * i;
    Console.WriteLine(n1+"x"+i+"="+tabuada);
}
