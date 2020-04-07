using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public GameObject grid;

    private GameObject elementToSpawn;
    public void AddElement(GameObject toSpawn)
    {
        elementToSpawn = toSpawn;
        Instantiate(elementToSpawn, grid.transform);
    }
}
