using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnGrounChecker : MonoBehaviour
{

    public bool flag = false;

    public bool isJumped=false;
    // Start is called before the first frame update
    
    private void OnCollisionStay2D(Collision2D other)
    {
        if(!isJumped)
            flag = true;
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        flag = false;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        isJumped = false;
    }
}
