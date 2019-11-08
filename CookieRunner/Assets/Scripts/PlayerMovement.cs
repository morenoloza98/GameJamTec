﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller2D;
    public float horizontalMove = 0f;
    public float runSpeed = 40f;

    public bool jump = false;
    public bool crouch = false;

   void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if(Input.GetButtonDown("Jump") )
            jump = true;

        /*if(Input.GetButtonDown("Crouch") )
            crouch = false;
        else if(Input.GetButtonUp("Crouch") )
            crouch = false;*/
        
    }

    void FixedUpdate()
    {
        controller2D.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
