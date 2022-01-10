using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PopUpMessage : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI ShowingMessage;

    private bool _thisPlayerHasNeverBeenOn2Level = true;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null)
        {
            if (collision.tag == "BridgeActivator")
            {
                LowerTheBridge();
            }
            if (collision.tag == "Bridge")
            {
                OhItsBridge();
            }
            if (collision.tag == "ThirstTimeOnSecondLevel" && _thisPlayerHasNeverBeenOn2Level)
            {
                _thisPlayerHasNeverBeenOn2Level = false;
                HellYeah2Level();
            }
        }
    }

    private void HellYeah2Level()
    {
        ShowMessage("No one was supposed to see this...", 3);
    }

    private void LowerTheBridge()
    {
        ShowMessage("That's might be what I need for a bridge...", 5);
        GameObject bridgeRotator = GameObject.FindGameObjectWithTag("BridgeRotator");
        if (bridgeRotator != null)
        {
            bridgeRotator.transform.rotation = new Quaternion(0, 0, 0, 0);
        }
    }

    private void OhItsBridge()
    {
        ShowMessage("Bridge... I need to find something to lower it", 5);
    }

    private void ShowMessage(string message, int secondOfShowing)
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
