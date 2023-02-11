void InputArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 32); 
}
 

int[] ReleaseArray1(int[] array)
{
    int [] arr2=new int[array.Length];
  for(int i=0; i<array.Length; i++){
    if(array[i]%2!=0){
        arr2[i]=array[i];
    }
  }
  return arr2;
}


int[] ReleaseArray2(int[] array)
{
    int [] arr2=new int[array.Length];
  for(int i=0; i<array.Length; i++){
    if(array[i]%2==0){
        arr2[i]=array[i];
    }
  }
  return arr2;
}

string comp(int [] arr1, int[] arr2){
    int sz1=0;
    int sz2=0;
    for(int i=0; i<arr1.Length; i++){
        if(arr1[i]!=0){
            sz1++;
        }
         if(arr2[i]!=0){
            sz2++;
        }
    }
    if(sz1>sz2)return "No";
    return "Yes";
} 

Console.Clear();
Console.Write("Введите кол-во элементов от 1 до 100: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
int[] array2= ReleaseArray1(array);
Console.WriteLine($"Массив троек: [{string.Join(", ", array2)}]");
int[] array3= ReleaseArray2(array);
Console.WriteLine($"Массив четверок: [{string.Join(", ", array3)}]");
Console.WriteLine(comp(array2, array3));