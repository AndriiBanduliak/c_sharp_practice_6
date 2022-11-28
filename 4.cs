﻿using static System.Console;
Clear();


int[] array1 = new int[10].Select(x=> new Random().Next(0,100)).ToArray();
int[] array2 = CopyArray(array1);
WriteLine($"[{String.Join(",", array1)}]");
WriteLine($"[{String.Join(",", array2)}]");

int[] CopyArray (int[] arr1)
{
    int[] result = new int[arr1.Length]; 
    for (int i = 0; i < arr1.Length; i++)
    {
        result[i] = arr1[i];
    }
    return result;
}
