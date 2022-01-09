using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CampfireManager : MonoBehaviour
{
    [SerializeField] private PlayerManager playerManager;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) return;
        playerManager.currentCampfire = this.transform;
        var s = this.GetComponent<BoxCollider2D>();
        s.enabled = false;
        playerManager.Die();
    }
}
