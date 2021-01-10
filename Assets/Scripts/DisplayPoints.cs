using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayPoints : MonoBehaviour
{
    public Text text;

    void Update()
    {
        int count = 0;
        GameObject[] circles = GameObject.FindGameObjectsWithTag("circle");
        foreach (GameObject element in circles)
        {
            Point point = element.GetComponent<Point>();
            if (point.isActive)
            {
                count++;
            }
        }
        text.text = "Pozostało: " + count;
    }
}
