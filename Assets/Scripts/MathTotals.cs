using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathTotals : MonoBehaviour
{
    public List<int> totals;

    public void UpdateValues()
    {
        GetMax();
        GetMin();
        GetAverage();
        GetMedian();
    }

    public int GetMax()
    {
        List<int> temp = ConvertToIntList();

        return Mathf.Max(temp.ToArray());
    }

    public int GetMin()
    {
        List<int> temp = ConvertToIntList();

        return Mathf.Min(temp.ToArray());
    }

    public float GetAverage()
    {
        List<int> temp = ConvertToIntList();
        float sum = 0;

        foreach (int num in temp)
        {
            sum += num;
        }
        return sum / temp.Count;
    }

    public int GetMedian()
    {
        List<int> temp = ConvertToIntList();

        temp.Sort();
        return 0;
    }

    List<int> ConvertToIntList()
    {
        List<int> ints = new List<int>();
        foreach (int value in totals)
        {
            ints.Add(value);
        }
        return ints;
    }
}
