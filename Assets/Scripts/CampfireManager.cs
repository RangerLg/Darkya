using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = System.Object;

public class CampfireManager : MonoBehaviour
{
    [SerializeField] private PlayerManager playerManager;

    [SerializeField] private GameObject BigCampfire;

    [SerializeField] private CreateCampfireManager CreateCampfireManager;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("test");
        var position = this.gameObject.transform;
        if (!other.CompareTag("Player")) return;
        playerManager.currentCampfire = this.transform;
        this.CreateCampfireManager.CreateCampfire(position);
        Destroy(this.gameObject);
        var s = this.GetComponent<BoxCollider2D>();
        s.enabled = false;
    }
}
