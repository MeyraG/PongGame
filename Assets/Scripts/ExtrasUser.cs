using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtrasUser : ExtraFeatures
{
    private void Start()
    {
        Initialiser();
    }

    void Update()
    {
        if (hasAlreadyRotated)
        {
            rotateCounter -= Time.deltaTime;
            if(rotateCounter <= 0)
            {
                NotRotate();
                rotateCounter = duration;
            }
        }
    }
    
}
