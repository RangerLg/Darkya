using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) return;
        CharacterController2D go = other.GetComponent<CharacterController2D>();
        go.playerManager.Die();
    }
}
