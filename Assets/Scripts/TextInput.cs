using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextInput : MonoBehaviour
{
    public Text textToChange;

    public void AddName(string name)
    {
        textToChange.text = name;
        gameObject.GetComponent<Buttons>().inputFieldObject.SetActive(false);
    }
}
