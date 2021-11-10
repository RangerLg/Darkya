using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInput : MonoBehaviour
{
    [SerializeField] PhysicsMovement _movement;
   
    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");

        _movement.Move(new Vector2(horizontal, 0));

    }
}
