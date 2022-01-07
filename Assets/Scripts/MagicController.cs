using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using UnityEngine;
using Debug = UnityEngine.Debug;

public enum MagicType
{
    POINT,
    CONE,
    RAYS
}

public class MagicController : MonoBehaviour
{
    private bool touchedLastFrame;

    [SerializeField] private GameObject pointEffect1;
    [SerializeField] private GameObject pointEffect2;
    [SerializeField] private GameObject pointEffect3;
    private static GameObject currentMagic;
    private List<MagicType> allMagicTypes = new List<MagicType>();
    private List<MagicType> foundMagicTypes = new List<MagicType>();
    private List<MagicType> equippedMagicTypes = new List<MagicType>();

    private MagicType currentMagicType;

    private Dictionary<MagicType, GameObject> effects;

    public void ChangeMagic(int numberOfMagic)
    {
        currentMagic = numberOfMagic switch
        {
            1 => pointEffect1,
            2 => pointEffect2,
            3 => pointEffect3,
            _ => currentMagic
        };
        Debug.Log(currentMagic+$"{numberOfMagic}");
    }

    void Start()
    {
        touchedLastFrame = false;
        currentMagic = pointEffect1;
        foreach (MagicType typeMagic in Enum.GetValues(typeof(MagicType)))
        {
            allMagicTypes.Add(typeMagic);
        }
    }

    private void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            var pos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            pos.z = 0;
            if (!CanvasRaycaster.IsUIElement(Input.GetTouch(0).position))
            {
                Instantiate(currentMagic, pos, Quaternion.identity);
            }
        }
    }


    public int GetCount()
    {
        return allMagicTypes.Count;
    }
}