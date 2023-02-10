
void InputArray(int[] array)
{for(int i=0; i<array.Length; i++)
array[i] = new Random().Next(-9,10);}
void Array(int[] array)
{for(int i=0; i<array.Length; i++)
array[i] = array[i]*(-1);}




Console.Clear();
Console.WriteLine("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] array =new int [n];
InputArray(array);


Console.WriteLine($"Начальный массив: [{string.Join(" ,",array)}]");
Array(array);
Console.WriteLine($"Массив с новыми элементами: [{string.Join(" ,",array)}]");
// Console.Clear();
// Console.WriteLine("Vvedite znachenia massiva: ");
// int[] array = new int[8];
// for (int i=0; i< array.Length; i++)

// array[i] = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"result: [{string.Join(" , ",array)}]");
