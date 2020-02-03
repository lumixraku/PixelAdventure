using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Utils 
{
    public static List<int> MakeRandomList(int start, int end)
    {
        List<int> list = new List<int>();
        for (int i = end -1 ; i >= start ; i--)
        {
            list.Add( i );   
        }
        list.Sort(delegate (int a, int b) { return (new System.Random()).Next(-1, 1); });   
        return list;
    }

    public static int GetRandomNoRepeat(List<int> arr, int lastOne)
    {
        int idx = UnityEngine.Random.Range(0, arr.Count - 1);
        if (idx == lastOne)
        {
            idx++;
        }
        idx = idx % (arr.Count -1);
        return idx;
    }

    public int GetRandomNoRepeat(int[] arr, int lastOne)        
    {
        int idx =  Array.IndexOf(arr, lastOne);
        if (idx != -1 ) {
            idx ++;
        }
        idx = idx % arr.Length;
        return idx;
    }
}
