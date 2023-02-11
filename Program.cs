void InputArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-9, 10); // [-9, 9]
}


int sum(int[] array)
{
    int count=0;
  for(int i=1; i<array.Length; i+=2){
    count+=array[i];
  }
  return count;
}


Console.Clear();
Console.Write("Введите кол-во элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine(sum(array));