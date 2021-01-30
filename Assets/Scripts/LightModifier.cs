using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightModifier : MonoBehaviour
{
    Light[] lightsOnScene;
    float[] intensityInitialValues;

    public Light lightP1 = null, lightP2 = null;

    [Range(0f, 1f)]
    public float lightOffIntensity = 0.1f;
    [Range(0f, 1f)]
    public float playerLightOnIntensity = 1f;
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

    public void TurnOnLights(bool isPlayer1)
    {
        if (turnOnOffWithLerp)
        {
            for (int i = 0; i < lightsOnScene.Length; ++i)
            {
                if (lightsOnScene[i]==lightP1|| lightsOnScene[i]==lightP2)
                {
                    if (isPlayer1&& lightsOnScene[i]==lightP1)
                    {
                        StartCoroutine(LerpLightIntensity(i, intensityInitialValues[i], turnOnOffSpeed, errorTolerance));
                    }
                    else if(!isPlayer1 && lightsOnScene[i]==lightP2)
                    {
                        StartCoroutine(LerpLightIntensity(i, intensityInitialValues[i], turnOnOffSpeed, errorTolerance));
                    }
                }
                else
                    StartCoroutine(LerpLightIntensity(i, intensityInitialValues[i], turnOnOffSpeed, errorTolerance));
            }
        }
        else
        {
            for (int i = 0; i < lightsOnScene.Length; ++i)
            {
                if (lightsOnScene[i] == lightP1 || lightsOnScene[i]== lightP2)
                {
                    if (isPlayer1 && lightsOnScene[i] == lightP1)
                    {
                        lightsOnScene[i].intensity = intensityInitialValues[i];
                    }
                    else if (!isPlayer1 && lightsOnScene[i] == lightP2)
                    {
                        lightsOnScene[i].intensity = intensityInitialValues[i];
                    }
                }
                else
                    lightsOnScene[i].intensity = intensityInitialValues[i];
            }
        }
    }

    public void TurnOffLights(bool isPlayer1)
    {
        if (turnOnOffWithLerp)
        {
            for(int i=0; i<lightsOnScene.Length; ++i)
            {
                if (lightsOnScene[i] == lightP1 || lightsOnScene[i] == lightP2)
                {
                    if (isPlayer1 && lightsOnScene[i] == lightP1)
                    {
                        StartCoroutine(LerpLightIntensity(i, playerLightOnIntensity, turnOnOffSpeed, errorTolerance));
                    }
                    else if (!isPlayer1 && lightsOnScene[i] == lightP2)
                    {
                        StartCoroutine(LerpLightIntensity(i, playerLightOnIntensity, turnOnOffSpeed, errorTolerance));
                    }
                }
                else
                    StartCoroutine(LerpLightIntensity(i, lightOffIntensity, turnOnOffSpeed, errorTolerance));
            }
        }
        else
        {
            for (int i = 0; i < intensityInitialValues.Length; ++i)
            {
                if (lightsOnScene[i] == lightP1 || lightsOnScene[i] == lightP2)
                {
                    if (isPlayer1 && lightsOnScene[i] == lightP1)
                    {
                        lightsOnScene[i].intensity = playerLightOnIntensity;
                    }
                    else if (!isPlayer1 && lightsOnScene[i] == lightP2)
                    {
                        lightsOnScene[i].intensity = playerLightOnIntensity;
                    }
                }
                else
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
