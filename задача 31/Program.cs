
void InputArray(int[] array)
{

for(int i=0; i<array.Length; i++)
array[i] = new Random().Next(-9,10);}

void ReleaseArray(int[] array)
{
    int summaPositive=0, summaNegative=0;
    foreach (int element in array)
    {
        if (element>0)
        summaPositive +=element;
        else
        summaNegative +=element;
    }
    Console.WriteLine(summaPositive);
    Console.WriteLine(summaNegative);
}
Console.Clear();
Console.WriteLine("vvedite kol-vo elementov massiva: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] array =new int [n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(" ,",array)}]");
ReleaseArray(array);
// for (array[i]<0)
// {int x=0;
// x=x+array[i];}
// if(array[i]>0)
//     int y=0;
//     y=y+array[i];

// Console.WriteLine($"{x},{y}");