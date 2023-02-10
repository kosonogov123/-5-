void IArray(int[] array)
{for (int i=0; i<array.Length;i++)
array[i] = new Random().Next(100,1000);}
void Arr(int[] array)
{int m=0;
{foreach(int element in array)
if (element%2==0) m++;}
Console.WriteLine($"kol-vo chetnih: {m}");}
Console.WriteLine("vvedite kol-vo elementov: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
IArray(array);
Console.WriteLine($"massiv: [{string.Join(", ",array)}]");
Arr(array);
