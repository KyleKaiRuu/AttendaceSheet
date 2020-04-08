using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalRow : MonoBehaviour
{
    public List<Text> values;
    int total;
    public Text totalText;
    public MathTotals mathTotals;

    private void Awake()
    {
        mathTotals = GameObject.FindGameObjectWithTag("Manager").GetComponent<MathTotals>();
    }
    public void UpdateTotal()
    {
        total = 0;
        foreach (Text value in values)
        {
            int temp = Convert.ToInt32(value.text);
            total += temp;
        }
        totalText.text = total.ToString();
        //Fix this, it's adding ones already added
        //if ()
        mathTotals.totals.Add(total);
        mathTotals.UpdateValues();
    }
}
