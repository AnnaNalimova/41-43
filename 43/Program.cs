// Напишите программу,которая найдет точку пересечения двух прямых,
// заданных уравнениями y=k1*x+b1,
//                      y=k2*x+b2
// значения b1,k1,b2,k2 вводит пользователь.
double[]  DataInput() { 
  double[] massive =new double[4];
 Console.WriteLine("Введите значение  b1 : ");
 massive[0]= double.Parse(Console.ReadLine());
 Console.WriteLine("Введите значение k1 : ");
 massive[1]= double.Parse(Console.ReadLine());
 Console.WriteLine("Введите значение b2 : ");
 massive[2]= double.Parse(Console.ReadLine());
 Console.WriteLine("Введите значение k2 : ");
 massive[3]= double.Parse(Console.ReadLine());
 return massive;
}

double[] FindPoint(double[] mass)
{
  double [] array=new double[2];
  array[0]=(mass[1]-mass[3])/(mass[2]-mass[0]);
  array[1]=mass[1]*array[0]+mass[0];
return array;  
}   
Console.WriteLine($"({String.Join("; ", FindPoint(DataInput()))}) ");