using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightModifier : MonoBehaviour
{
    Light[] lightsOnScene;
    float[] intensityInitialValues;

    [Range(0f, 1f)]
    public float lightOffIntensity = 0.1f;
    [Range(0f, 1f)]
    public float turnOnOffSpeed = 0.1f;

    public float errorTolerance = 0.1f;
    public bool turnOnOffWithLerp = false;

    // Start is called before the first frame update
    void Start()
    {
        lightsOnScene = FindObjectsOfType<Light>();
        intensityInitialValues = new float[lightsOnScene.Length];
        for(int i=0; i<intensityInitialValues.Length; ++i)
        {
            intensityInitialValues[i] = lightsOnScene[i].intensity;
        }
    }

    public void TurnOnLights()
    {
        if (turnOnOffWithLerp)
        {
            for (int i = 0; i < lightsOnScene.Length; ++i)
            {
                StartCoroutine(LerpLightIntensity(i, intensityInitialValues[i], turnOnOffSpeed, errorTolerance));
            }
        }
        else
        {
            for (int i = 0; i < intensityInitialValues.Length; ++i)
            {
                lightsOnScene[i].intensity = intensityInitialValues[i];
            }
        }
    }

    public void TurnOffLights()
    {
        if (turnOnOffWithLerp)
        {
            for(int i=0; i<lightsOnScene.Length; ++i)
            {
                StartCoroutine(LerpLightIntensity(i, lightOffIntensity, turnOnOffSpeed, errorTolerance));
            }
        }
        else
        {
            for (int i = 0; i < intensityInitialValues.Length; ++i)
            {
                lightsOnScene[i].intensity = lightOffIntensity;
            }
        }
    }

    IEnumerator LerpLightIntensity(int lightId, float targetValue, float speed, float errorTolerance)
    {
        while (Mathf.Abs(lightsOnScene[lightId].intensity - targetValue) > errorTolerance)
        {
            lightsOnScene[lightId].intensity = Mathf.Lerp(lightsOnScene[lightId].intensity, targetValue, speed);
            yield return null;
        }
    }
}
