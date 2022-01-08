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
    private bool isMagicAvailable = true;
    [SerializeField] MagicFactory factory;
    [SerializeField] private int magicTimer;
    private static MagicType currentMagic;

    [SerializeField] private GameObject currMagic;
    private List<MagicType> allMagicTypes = new List<MagicType>();
    private List<MagicType> foundMagicTypes = new List<MagicType>();
    private List<MagicType> equippedMagicTypes = new List<MagicType>();

    private MagicType currentMagicType;

    private Dictionary<MagicType, GameObject> effects;

    public void ChangeMagic(int numberOfMagic)
    {
        currentMagic = numberOfMagic switch
        {
            1 => MagicType.POINT,
            2 => MagicType.CONE,
            3 => MagicType.RAYS,
            _ => MagicType.POINT
        };
    }

    void Start()
    {
        currentMagic = MagicType.CONE;
        foreach (MagicType typeMagic in Enum.GetValues(typeof(MagicType)))
        {
            allMagicTypes.Add(typeMagic);
        }
    }

    private void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began && isMagicAvailable)
        {
            var pos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            pos.z = 0;

            if (!CanvasRaycaster.IsUIElement(Input.GetTouch(0).position))
            {
                factory.GetMagic(currentMagic).LightUp(pos);
                StartCoroutine(Timer());
            }
        }
    }

    private IEnumerator Timer()
    {
        isMagicAvailable = false;
        yield return new WaitForSeconds(magicTimer);
        isMagicAvailable = true;
    }

    public int GetCount()
    {
        return allMagicTypes.Count;
    }
}