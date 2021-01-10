using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EagleFly : MonoBehaviour
{
    private int direction = -1;
    public Rigidbody2D rigid;
    private int rotation = 0;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x + direction * Time.deltaTime, transform.position.y);
        //rigid.MovePosition(transform.position + transform.forward * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        direction *= -1;
        transform.localRotation *= Quaternion.Euler(0, 180, 0);
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerController player = collision.gameObject.GetComponent<PlayerController>();
            player.Death();
        }
    }
}
