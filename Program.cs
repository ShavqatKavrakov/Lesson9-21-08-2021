using System.Reflection.Emit;
using System;

namespace Lesson9_21_08_2021
{
    static class ArrayHelper
    {
     public static double Pop(ref  double[] arr)
    {
        double[] newarr= new double[arr.Length-1];
        double  endElementMas=arr[arr.Length-1];
        for(int  i=0; i<arr.Length-1; ++i) newarr[i]=arr[i];
            arr=newarr;
             return endElementMas;
    }
      public static double Pop(ref  int[] arr)
    {
        int [] newarr= new int[arr.Length-1];
       int   endElementMas=arr[arr.Length-1];
        for(int  i=0; i<arr.Length-1; ++i) newarr[i]=arr[i];
            arr=newarr;
            
             return endElementMas;
    }
      public static decimal Pop(ref  decimal[] arr)
    {
        decimal[] newarr= new decimal[arr.Length-1];
        decimal endElementMas=arr[arr.Length-1];
        for(int  i=0; i<arr.Length-1; ++i) newarr[i]=arr[i];
            arr=newarr;
             return endElementMas;
    }
      public static double Pop(ref  float[] arr)
    {
        float[] newarr= new float[arr.Length-1];
        float endElementMas=arr[arr.Length-1];
        for(int  i=0; i<arr.Length-1; ++i) newarr[i]=arr[i];
            arr=newarr;
             return endElementMas;
    }
    
    public static int Push(ref double[]arr,double element)
    {
     double[] newarr=new double[arr.Length+1];
     newarr[arr.Length]=element;
     for(int i=0; i<arr.Length; ++i)  newarr[i]=arr[i]; 
     arr=newarr;
     return arr.Length;
    }
    
    public static int Push(ref int[]arr,int element)
    {
     int[] newarr=new int[arr.Length+1];
     newarr[arr.Length]=element;
     for(int i=0; i<arr.Length; ++i)  newarr[i]=arr[i]; 
     arr=newarr;
     return arr.Length;
    }
    public static int Push(ref decimal[]arr,decimal element)
    {
     decimal[] newarr=new decimal[arr.Length+1];
     newarr[arr.Length]=element;
     for(int i=0; i<arr.Length; ++i)  newarr[i]=arr[i]; 
     arr=newarr;
     return arr.Length;
    }
    public static int Push(ref float[]arr,float element)
    {
     float[] newarr=new float[arr.Length+1];
     newarr[arr.Length]=element;
     for(int i=0; i<arr.Length; ++i)  newarr[i]=arr[i]; 
     arr=newarr;
     return arr.Length;
    }
    public static double Shift(ref double[] arr)
    {
        double[] newarr=new double[arr.Length-1];
        double begin=arr[0];
        for(int i=1; i<arr.Length; ++i) newarr[i-1]=arr[i];
        arr=newarr;
        return begin;
    }
    
    public static double Shift(ref int[] arr)
    {
        int[] newarr=new int[arr.Length-1];
        double begin=arr[0];
        for(int i=1; i<arr.Length; ++i) newarr[i-1]=arr[i];
        arr=newarr;
        return begin;
    }
    public static decimal Shift(ref decimal[] arr)
    {
        decimal[] newarr=new decimal[arr.Length-1];
        decimal begin=arr[0];
        for(int i=1; i<arr.Length; ++i) newarr[i-1]=arr[i];
        arr=newarr;
        return begin;
    }
    public static double Shift(ref float[] arr)
    {
        float[] newarr=new float[arr.Length-1];
        float begin=arr[0];
        for(int i=1; i<arr.Length; ++i) newarr[i-1]=arr[i];
        arr=newarr;
        return begin;
    }
    public static int UnShift(ref double[]arr,double element1)
    {
     double[] newarr=new double[arr.Length+1];
     newarr[0]=element1;
     for(int i=1; i<arr.Length+1; i++) newarr[i]=arr[i-1]; 
     arr=newarr;
     return arr.Length;
    }
    public static int UnShift(ref int[]arr,int element)
    {
     int[] newarr=new int[arr.Length+1];
     newarr[0]=element;
     for(int i=1; i<arr.Length+1; ++i) newarr[i]=arr[i-1]; 
     arr=newarr;
     return arr.Length;
    }public static int UnShift(ref decimal[]arr,decimal element)
    {
     decimal[] newarr=new decimal[arr.Length+1];
     newarr[0]=element;
     for(int i=1; i<arr.Length+1; ++i) newarr[i]=arr[i-1]; 
     arr=newarr;
     return arr.Length;
    }
    public static int UnShift(ref float[]arr,float element)
    {
     float[] newarr=new float[arr.Length+1];
     newarr[0]=element;
     for(int i=1; i<arr.Length+1; ++i) newarr[i]=arr[i-1]; 
     arr=newarr;
     return arr.Length;
    }
    }
    class Program
    {
        static void Main(string[] args)
        {
            {
                //Д32
                Console.Write("Введите размера массива:");
                int.TryParse(Console.ReadLine(),out int n);
               double[] arr=new double[n];
               Console.WriteLine("Введите элементы массива");
               for(int i=0; i<arr.Length; ++i)arr[i]=double.Parse(Console.ReadLine());
         Console.WriteLine($"Последний элемент массива который мы удалили: {ArrayHelper.Pop(ref arr)}");
      foreach(double s in arr)Console.WriteLine(s);
            Console.Write($"Добавляете элемент в конце массива: ");
            float.TryParse(Console.ReadLine(),out float element);
            Console.WriteLine($"Размер массива после добовлении  новых элементов: {ArrayHelper.Push(ref arr,element)}");
                 foreach(double s in arr)Console.WriteLine(s);
             Console.WriteLine($"Первый элемент массива который мы удалили: {ArrayHelper.Shift(ref arr)}");
                 foreach(double s in arr)Console.WriteLine(s);
             Console.Write("Добавляете элемент в начале массива: ");
             float.TryParse(Console.ReadLine(),out float element1);
             Console.WriteLine($"Размер массива после добовлении  новых элементов: {ArrayHelper.UnShift(ref arr,element1)}");
                  foreach(double s in arr)Console.WriteLine(s);
            }
            }
            
         }
    }

