using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayHealth : MonoBehaviour
{
    public Text text;

    void Update()
    {
        GameObject[] players = GameObject.FindGameObjectsWithTag("Player");
        if(players.Length == 0)
        {
            return;
        }
        PlayerController player = players[0].GetComponent<PlayerController>();
        
        text.text = "Życia: " + player.lives;
    }
}
