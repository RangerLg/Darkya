using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    private Animator _animator;
    private float _horizontalMove;
    [SerializeField] private float speed = 40f;
    private bool jump = false;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        _horizontalMove = CrossPlatformInputManager.GetAxisRaw("Horizontal") * speed;
        
        _animator.SetFloat("Speed", Mathf.Abs(_horizontalMove));
        
        if (CrossPlatformInputManager.GetButtonDown("Jump"))
        {
            jump = true;
            _animator.SetBool("IsJumping", true);
        }
    }

    public void OnLanding()
    {
        _animator.SetBool("IsJumping", false);
    }

    private void FixedUpdate()
    {
        controller.Move(_horizontalMove*Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
