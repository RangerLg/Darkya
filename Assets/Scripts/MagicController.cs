using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public enum MagicType
{
    POINT,
    CONE,
    RAYS
}

public class MagicController : MonoBehaviour
{
    private bool touchedLastFrame;

    [SerializeField] private GameObject pointEffect;


    private List<MagicType> allMagicTypes = new List<MagicType>();
    private List<MagicType> foundMagicTypes = new List<MagicType>();
    private List<MagicType> equippedMagicTypes = new List<MagicType>();

    private MagicType currentMagicType;

    private Dictionary<MagicType, GameObject> effects;

    void Start()
    {
        touchedLastFrame = false;


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
                GameObject test = Instantiate(pointEffect, pos, Quaternion.identity);
            }
        }
    }


    public int GetCount()
    {
        return allMagicTypes.Count;
    }
}