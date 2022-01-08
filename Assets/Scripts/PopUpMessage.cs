using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PopUpMessage : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI ShowingMessage = new TextMeshProUGUI();

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null && collision.tag == "BridgeActivator")
        {
            LowerTheBridge(collision);
        }
    }

    public void LowerTheBridge(Collider2D collision)
    {
        ShowMessage("That's might be what I need for a bridge...", 5);
        GameObject bridgeRotator = GameObject.FindGameObjectWithTag("BridgeRotator");
        if (bridgeRotator != null)
        {
            bridgeRotator.transform.rotation = new Quaternion(0, 0, 0, 0);
        }
    }

    public void ShowMessage(string message, int secondOfShowing)
    {
        Debug.Log(message);
        ShowingMessage.text = message;
        StartCoroutine(TimeOfShowingMessage(secondOfShowing));
    }

    private IEnumerator TimeOfShowingMessage(int seconds)
    {
        yield return new WaitForSeconds(seconds);
        ShowingMessage.text = " ";
    }
}
