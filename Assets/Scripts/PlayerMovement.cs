using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    private float _horizontalMove;
    [SerializeField] private float speed = 40f;
    private bool jump = false;
    void Update()
    {
        _horizontalMove = CrossPlatformInputManager.GetAxisRaw("Horizontal") * speed;
        if (CrossPlatformInputManager.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }

    private void FixedUpdate()
    {
        controller.Move(_horizontalMove*Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
