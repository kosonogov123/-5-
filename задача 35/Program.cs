
void InputArray(int[] array)
{for (int i = 0; i<array.Length;i++)
array[i] = new Random().Next(0,100);}

// void InputArray(int[] array)
// {for (int i = 0; i<array.Length;i++)
// array[i]= new Random().Next(-9,10);}
void Arr(int[] array)
{int kol=0;
    foreach (int element in array)
    {if (element>10 && element< 100) 
    kol++;}
    Console.WriteLine(kol);}

Console.Clear();
Console.WriteLine("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = new int[n];
InputArray(array);
Console.WriteLine($"massiv:[{string.Join(" ,",array)}]");
Arr(array);
// Console.Clear();
// Console.WriteLine("Введите количество элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int [] array =new int [n];
// InputArray(array);


// Console.WriteLine($"Начальный массив: [{string.Join(" ,",array)}]");