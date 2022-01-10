using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] public Transform currentCampfire;

    [SerializeField] private GameObject player;

    [SerializeField] private Text dieText;

    [SerializeField] public bool isDied;

    [SerializeField] private GameObject rightButton;
    [SerializeField] private GameObject leftButton;
    [SerializeField] private GameObject jumpButton;

    [SerializeField] private GameObject magicButton;

    // Start is called before the first frame update
    private const string DieText = "You die";

    public void Die()
    {
        StartCoroutine(DieCoroutine());
    }

    private IEnumerator DieCoroutine()
    {
        dieText.enabled = true;
        UI(false);
        isDied = true;
        yield return new WaitForSeconds(5);
        dieText.enabled = false;
        Awake();
        isDied = false;
        UI(true);
    }

    private void Awake()
    {
         player.transform.position = currentCampfire.position - new Vector3(1.5f, 0, 0);
    }

    private void UI(bool isActive)
    {
        rightButton.SetActive(isActive);
        leftButton.SetActive(isActive);
        jumpButton.SetActive(isActive);
        magicButton.SetActive(isActive);
    }
    
}