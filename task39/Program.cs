﻿// Напишите программу которая перевернет одномерный массив (последний элемент будет на перввом месте а первый на последнем)
// [12345]->[54321]      [6736]->[6376]
int []array = GetArray(10,0,10);
//  Console.WriteLine(String.Join(" ", array));
//   Console.WriteLine(String.Join(" ",ReversArray2(array)));
Console.WriteLine(String.Join(" ", array));
ReversArray1(array);
Console.WriteLine(String.Join(" ", array));

int[]GetArray(int size,int minValue, int maxValue)
{
    int[]res = new int [size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue,maxValue+1);
    }
    return res;
}
void ReversArray1(int[] inArray)
{
    for (int i = 0; i < inArray.Length/2;i++)
    {
        int k = inArray[i];
        inArray[i] = inArray[inArray.Length-i-1];
        inArray[inArray.Length-i-1]=k;
    }
}
int[]ReversArray2(int[]inArray)
 {
     int[]result = new int[inArray.Length];
     for(int i = 0; i < inArray.Length;i++)
     {
         result[i] = inArray[inArray.Length-1-i];
     }
     return result;
 }

