using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CanvasRaycaster : MonoBehaviour
{
    static GraphicRaycaster _mRaycaster;
    static PointerEventData _mPointerEventData;
    static EventSystem _mEventSystem;

    void Start()
    {
        _mRaycaster = GetComponent<GraphicRaycaster>();
        _mEventSystem = GetComponent<EventSystem>();
    }

    public static bool IsUIElement(Vector3 position)
    {
        //Set up the new Pointer Event
        _mPointerEventData = new PointerEventData(_mEventSystem);
        //Set the Pointer Event Position to that of the mouse position
        _mPointerEventData.position = position;

        //Create a list of Raycast Results
        List<RaycastResult> results = new List<RaycastResult>();

        //Raycast using the Graphics Raycaster and mouse click position
        _mRaycaster.Raycast(_mPointerEventData, results);

        //For every result returned, output the name of the GameObject on the Canvas hit by the Ray
        Debug.Log(results.Count);
        return results.Count != 0;
    }
}