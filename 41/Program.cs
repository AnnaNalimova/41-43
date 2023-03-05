// Пользователь вводит с клавиатуры М чисел. 
// Посчитайте сколько чисел больше 0 ввел пользователь.
Console.WriteLine("Введите числа массива через пробел: ");
string elements=Console.ReadLine();
int[]firstarray=GetArrayFromString(elements);
int res = GetNumber(firstarray);
Console.WriteLine(res);
int  GetNumber(int[] massive)
{
    int count=0;
    for(int i=0;i<massive.Length;i++)
    {
       if(massive[i]>0)  
       count++;
    }
    return  count;
}
int[] GetArrayFromString(string stringArray)
{

  string[]nums=stringArray.Split(" ");
  int[]result = new int[nums.Length];
  for( int i=0;i<nums.Length;i++){

      result [i]=int.Parse(nums[i]);
  }
  return result;
}

 
