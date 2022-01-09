using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class FirecampLight : MonoBehaviour
{
    private Light2D _light2d;
    [SerializeField] float minValueInnerRadius;
    [SerializeField] float maxValueInnerRadius;
    [SerializeField] float minValueOuterRadius;
    [SerializeField] float maxValueOuterRadius;
    [SerializeField] float delta;

    void Start()
    {
        _light2d = GetComponent<Light2D>();
    }

    void Update()
    {
        _light2d.pointLightInnerRadius = TudaSudaFloatValue(delta, minValueInnerRadius, maxValueInnerRadius, _light2d.pointLightInnerRadius);
        _light2d.pointLightOuterRadius = TudaSudaFloatValue(delta, minValueOuterRadius, maxValueOuterRadius, _light2d.pointLightOuterRadius);
        _light2d.intensity = TudaSudaFloatValue(0.01f, 0.9f, 1.1f, _light2d.intensity);
    }

    private float TudaSudaFloatValue(float delta, float minValue, float maxValue, float currentRadiusOrWhatDoYouWantHereAnywayItShouldBeFloat)
    {
        if (Random.value > 0.5f && currentRadiusOrWhatDoYouWantHereAnywayItShouldBeFloat <= maxValue)
        {
            return currentRadiusOrWhatDoYouWantHereAnywayItShouldBeFloat += delta;
        }
        else if (currentRadiusOrWhatDoYouWantHereAnywayItShouldBeFloat >= minValue)
        {
            return currentRadiusOrWhatDoYouWantHereAnywayItShouldBeFloat -= delta;
        }
        return currentRadiusOrWhatDoYouWantHereAnywayItShouldBeFloat;
    }
}
