using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallBall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerController player = collision.gameObject.GetComponent<PlayerController>();
            if (player.isBig)
            {
                player.isBig = false;
                collision.gameObject.transform.localScale += new Vector3(-0.5f, -0.5f, 0);
            }
        }
    }
}
