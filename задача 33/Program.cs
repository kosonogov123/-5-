// присутствует ли число в массиве
void InputArray(int[] array)
{for (int i = 0; i<array.Length;i++)
array[i]= new Random().Next(-9,10);}

string IntArray(int[] array,int number)
{ 
foreach (int element in array)
{if (element ==  number)
return "yes";}
return "no"; }



Console.WriteLine("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"массив: [{string.Join(" ,",array)}]");
Console.WriteLine("Введите искомый элемент: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(IntArray(array,number));