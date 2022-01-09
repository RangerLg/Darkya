using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapMovement : MonoBehaviour
{
    void Update()
    {
        transform.position = new Vector3(transform.position.x, (float) (transform.position.y + Math.Sin(Time.deltaTime)),
            transform.position.z);
    }
}
