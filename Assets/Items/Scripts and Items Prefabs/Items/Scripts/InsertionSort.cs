using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InsertionSort : MonoBehaviour
{
    public int[] Prefabs = new int[12];
    // Function to sort array
    // using insertion sort
    void sort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; ++i)
        {
            int key = arr[i];
            int j = i - 1;

            // Move elements of arr[0..i-1],
            // that are greater than key,
            // to one position ahead of
            // their current position
            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j = j - 1;
            }
            arr[j + 1] = key;
        }
    }

    // A utility function to print
    // array of size n
    static void printArray(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; ++i)
            Debug.Log(arr[i] + " ");

        Debug.Log("\n");
    }

    // Driver Code
    public static void Main()
    {
        int[] PrefabsPrices = { 40, 30, 20, 10, 20, 40, 50, 30, 50, 20, 10, 30 };
        InsertionSort ob = new InsertionSort();
        ob.sort(PrefabsPrices);
        printArray(PrefabsPrices);
       
        
    }
}
    
    

