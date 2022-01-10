using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public abstract class MagicEffect : MonoBehaviour
{
    protected Light2D _light2D;
    protected abstract IEnumerator Shine();
}



