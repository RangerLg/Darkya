using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;


public class ConeEffect : MagicEffect
{
    static public float radius; 

    protected override IEnumerator Shine()
    {
        
        for (int i = 0; i < 60; i++)
        {
            _light2D.pointLightInnerAngle++;
            _light2D.pointLightOuterAngle++;
            yield return new WaitForSeconds(0.001f);
        }
        yield return new WaitForSeconds(1.0f);
        
        for (int i = 0; i < 60; i++)
        {
            _light2D.pointLightInnerAngle--;
            _light2D.pointLightOuterAngle--;
            yield return new WaitForSeconds(0.001f);
        }
        
        Destroy(gameObject);
    }

    private void Start()
    {
        _light2D = GetComponent<Light2D>();
        _light2D.intensity = 2.0f;
        _light2D.pointLightInnerRadius = 0;
        _light2D.pointLightOuterRadius = radius;
        _light2D.pointLightInnerAngle = 0.0f;
        _light2D.pointLightOuterAngle = 0.0f;

        StartCoroutine(Shine());
    }
}
