using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeComponent : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerController player = collision.gameObject.GetComponent<PlayerController>();
            player.Death();
        }
    }
}
