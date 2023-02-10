void InputArray(int[] array)
{for (int i = 0; i<array.Length;i++)
array[i] = new Random().Next(0,10);}

void InArray(int[] array)
{for (int i = 0; i<array.Length/2+array.Length%2;i++)
Console.WriteLine($"{array[i]*array[array.Length-i-1]}");
}



Console.Clear();
Console.WriteLine("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = new int[n];
InputArray(array);
Console.WriteLine($"massiv:[{string.Join(" ,",array)}]");
InArray(array);