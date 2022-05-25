using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ExtraFeatures : MonoBehaviour
{
    protected bool hasAlreadyDown; protected bool hasAlreadyRotated; protected bool hasAlreadyReversed;

    public float duration;

    protected float rotateCounter;


    public void Initialiser()
    {
        rotateCounter = duration;
    }

    public void Rotate()
    {
        if (!hasAlreadyRotated)
        {
            transform.rotation = Quaternion.Euler(90, 0, 90);
            hasAlreadyRotated = true;
            Debug.Log("Rotate is working!");
        }
    }
    public void NotRotate()
    {
        transform.rotation = Quaternion.Euler(90, 0, 0);
        hasAlreadyRotated = false;
    }

    public void Reverse()
    {

    }

    //if (!hasAlreadyDown)
    //{
    //    startTime = Time.time;
    //    transform.localScale = transform.localScale / 3;
    //    hasAlreadyDown = true;

    //}
    public void DownSize()
    {
        Debug.Log("bu muhtemelen çalışacak");
    }

    public void UpSize()
    {
        //if (hasAlreadyDown)
        //{
        //    transform.localScale = transform.localScale * 3;
        //    hasAlreadyDown = false;
        //}
    }
}
