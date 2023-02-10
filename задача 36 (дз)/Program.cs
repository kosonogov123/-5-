void IArray(int[] array)
{for (int i=0; i<array.Length;i++)
array[i] = new Random().Next(0,100);}
int Arr(int[] array)
{int s=0;
    for (int i = 1;  i<array.Length;i+=2)
s=s+array[i];
return s;}


Console.WriteLine("vvedite kol-vo elementov: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
IArray(array);
Console.WriteLine($"massiv: [{string.Join(", ",array)}]");

Console.WriteLine($"summa: {Arr(array)}");

// Console.Clear();
// Console.WriteLine("Введите количество элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int [] array = new int[n];
// InputArray(array);
// Console.WriteLine($"massiv:[{string.Join(" ,",array)}]");
// InArray(array);