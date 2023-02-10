void InArray(int[] array)
{for (int i=0; i<array.Length;i++)
array[i]=new Random().Next(-100,100);}
void to(int[] array)
{int max=-100, min=100;
foreach (int element in array)
{
    if (element>max) max=element;
if (element<min) min=element;
}
Console.WriteLine($"max = {max}");
Console.WriteLine($"min = {min}");
Console.WriteLine($"raznitsa = {max-min}");}



Console.WriteLine("vvedite kol-vo elementov: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InArray(array);

Console.WriteLine($"[{string.Join(", ",array)}]");
to(array);

