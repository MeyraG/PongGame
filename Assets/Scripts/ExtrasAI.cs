using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtrasAI : ExtraFeatures
{
    [SerializeField] private float callMinTime = 5.5f;
    [SerializeField] private float callMaxTime = 7.5f;

    private float currentTime;

    private void Start()
    {
        Initialiser();
        currentTime = Random.Range(callMinTime, callMaxTime);
        Invoke("CallNextFeature", currentTime);
    }

    private void CallNextFeature()
    {
        Debug.Log("HELO!");
        currentTime = Random.Range(callMinTime, callMaxTime);

        //Define an enum for extra features then random choose between them

        //TODO: Random Later
        Rotate();
        hasAlreadyRotated = true;
        //

        //REVERSE
        // ...
        //
    }

    private void Update()
    {
        if (hasAlreadyRotated)
        {
            rotateCounter -= Time.deltaTime;
            if (rotateCounter <= 0)
            {
                NotRotate();
                Invoke("CallNextFeature", currentTime);
                rotateCounter = duration;
            }
        }
    }
}
