using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    float horizontalMove = 0f;
    public float speed = 40f;
    bool jump = false;

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * speed;

        if(Input.GetButtonUp("Jump")) 
        {
            jump = true;
            Debug.Log("jump");
        }
    } 

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
