void InputArray(double[] array)
{   
    int begin=1, end=100;
  for (int i = 0; i < array.Length; i++)
    array[i] = Math.Round(new Random().NextDouble() * (end - begin) + begin, 2);
}


double cmp(double[] array)
{
    double max=array[0], min=array[0];
    double result;
  for(int i=0; i<array.Length; i++){
    if(array[i]>max){
        max=array[i];
    }
    if(array[i]<min){
        min=array[i];
    }
  }
  result =max-min;
 return result;
}


Console.Clear();
Console.Write("Введите кол-во элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine(cmp(array));