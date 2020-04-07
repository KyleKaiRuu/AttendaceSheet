using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    //The public grid variable for inEditor purposes
    public GameObject grid;

    public GameObject inputFieldObject;

    private void Awake()
    {
        //If the grid variable was not initialized in editor
        if (grid == null)
        {
            //Ensure there is a grid object in the scene
            if (GameObject.FindGameObjectWithTag("Grid") != null)
            {
                //Set the grid to the grid object
                grid = GameObject.FindGameObjectWithTag("Grid");
            }
            //If there isn't a grid in the scene, send a message
            else
            {
                Debug.Log("There are no objects with the 'Grid' tag");
            }
        }
    }

    //Add an element to the grid
    public void AddElement(GameObject toSpawn)
    {
        //Ensure the grid is not null
        if (grid != null)
        {
            //Spawn the element needed and parent it to the grid
            GameObject spawned = Instantiate(toSpawn, grid.transform);
            spawned.GetComponent<Buttons>().inputFieldObject.SetActive(true);

        }
        //If there isn't a grid in the scene, send a message
        else
        {
            Debug.Log("There is no grid in the scene!");
        }
    }

    //Add to the count when button clicked
    public void AddToCount(GameObject text)
    {
        //Do the math stuff needed for the correct amount to show
        DoMath(text, 1);
    }

    //Subtract from the count when button clicked
    public void SubtractFromCount(GameObject text)
    {
        //Ensure the value is not already 0
        if (Convert.ToInt32(text.GetComponent<Text>().text) > 0)
        {
            //Do the math stuff needed for the correct amount to show
            DoMath(text, -1);
        }
        //If value is already 0, send a message
        else
        {
            Debug.Log("There's nothing to take!");
        }
    }

    void DoMath(GameObject text, int operation)
    {
        //Get the Text component
        Text objText = text.GetComponent<Text>();
        //Convert the current text to an int
        int stringToInt = Convert.ToInt32(objText.text);
        //Add to the current value and return it to a string, then set it to the text
        objText.text = (stringToInt + operation).ToString();
    }
}
