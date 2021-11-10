using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInput : MonoBehaviour
{
    [SerializeField] PhysicsMovement _movement;

    [SerializeField] private OnGrounChecker ground;

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        if (Input.GetKeyUp("space"))
        {
            _movement.Jump(new Vector2(0,1));
        }
        else if (ground.flag && !ground.isJumped)
        {
            _movement.Move(new Vector2(horizontal, 0));
        }
          
    }
}