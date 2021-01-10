using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    public bool isActive = true;
    public bool isReverse = false;
    public AudioClip SoundToPlay;
    AudioSource audio;
    SpriteRenderer sprite;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //Debug.Log(collision.collider.attachedRigidbody.position.normalized);
            //Debug.Log("enter");
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if(!isActive)
        {
            return;
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            float objectCenterX = gameObject.transform.position.x;
            float x = collision.collider.attachedRigidbody.position.x;
            if(isReverse)
            {
                if(x< objectCenterX)
                {
                    sprite.color = new Color(0.5f, 0.5f, 0.5f);
                    audio.PlayOneShot(SoundToPlay, 0.9f);
                    isActive = false;
                    //Destroy(gameObject);
                }
            } else
            {
                if (x > objectCenterX)
                {
                    sprite.color = new Color(0.5f, 0.5f, 0.5f);
                    //sprite.color.g = 0.5f;
                    //sprite.color.b = 0.5f;
                    audio.PlayOneShot(SoundToPlay, 0.9f);
                    //Destroy(gameObject);
                    isActive = false;
                }
            }
            //Debug.Log();
            //
            //Destroy(gameObject);
        }
    }
}
