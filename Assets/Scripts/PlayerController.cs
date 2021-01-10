using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public bool isBig = false;
    public Rigidbody2D rb;
    public int speed = 1;
    public Vector3 checkPoint = new Vector3(-6.5f, 3.5f, 1);
    public int lives = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Death()
    {
        lives--;
        gameObject.transform.position = checkPoint;
        if(isBig)
        {
            transform.localScale += new Vector3(-0.5f, -0.5f, 0);
            isBig = false;
        }
        
        if(lives == 0)
        {
            SceneManager.LoadScene("Menu");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-1 * speed, rb.velocity.y);
        }

        if(Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(1 * speed, rb.velocity.y);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, isBig ? 15f : 10f);
        }
    }
}
