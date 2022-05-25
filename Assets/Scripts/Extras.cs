using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Extras : MonoBehaviour
{
    private bool hasAlreadyDown; private bool hasAlreadyRotated; private bool hasAlreadyReversed;
    public float duration;

    private float rotateCounter;


    void Start()
    {
        rotateCounter = duration;
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

    public void Rotate()
    {
        if (!hasAlreadyRotated)
        {
            //startTime = Time.time;
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
}
