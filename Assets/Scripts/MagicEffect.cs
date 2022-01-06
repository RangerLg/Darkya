using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class MagicEffect : MonoBehaviour
{
    private Light2D _light2D;

    private IEnumerator Shine()
    {
        for (int i = 0; i < 10; i++)
        {
            _light2D.intensity += (float)i / 10;
            yield return new WaitForSeconds(0.1f);
        }

        yield return new WaitForSeconds(2.0f);
        
        for (int i = 0; i < 10; i++)
        {
            _light2D.intensity -= (float)i / 10;
            yield return new WaitForSeconds(0.1f);
        }
        Destroy(gameObject);
    }
    private void Start()
    {
        _light2D = GetComponent<Light2D>();
        _light2D.intensity = 0.0f;
        StartCoroutine(Shine());
    }

    private void Awake()
    {
        
    }
}
