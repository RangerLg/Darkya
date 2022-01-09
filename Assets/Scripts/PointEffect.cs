using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class PointEffect : MagicEffect
{
    protected override IEnumerator Shine()
    {
        for (int i = 0; i < 30; i++)
        {
            _light2D.pointLightOuterRadius += (float) i / 1000;
            _light2D.intensity += (float)i / 100;
            
            yield return new WaitForSeconds(0.01f);
        }

        yield return new WaitForSeconds(0.2f);
        
        for (int i = 0; i < 30; i++)
        {
            _light2D.intensity -= (float)i / 100;
            yield return new WaitForSeconds(0.01f);
        }
        Destroy(gameObject);
    }
    private void Start()
    {
        _light2D = GetComponent<Light2D>();
        _light2D.intensity = 0.0f;
        StartCoroutine(Shine());
    }
}
