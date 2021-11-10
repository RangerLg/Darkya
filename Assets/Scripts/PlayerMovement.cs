using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    private float _horizontalMove;
    [SerializeField] private float speed = 40f;
    private bool jump = false;
    void Update()
    {
        _horizontalMove = Input.GetAxisRaw("Horizontal") * speed;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump = true;
        }
        Debug.Log(jump);
    }

    private void FixedUpdate()
    {
        controller.Move(_horizontalMove*Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
