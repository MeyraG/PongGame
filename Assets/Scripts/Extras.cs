using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Extras : MonoBehaviour
{
//    public bool isPlayer1;
//    public bool hasAlreadyDown; public bool hasAlreadyRotated; public bool hasAlreadyReversed;
//    public float duration; 
//    public float startTime;

   

    void Start()
    {
      
    }

    
    void Update()
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

    public void Rotate()
    {
        //if (!hasAlreadyRotated)
        //{
        //    startTime = Time.time;
        //    transform.rotation = Quaternion.Euler(0, 0, 90);
        //    hasAlreadyRotated = true;
        //    Debug.Log("Rotate is working!");
        //}
    }
    public void NotRotate()
    {
        //transform.rotation = Quaternion.Euler(0, 0, 0);
        //hasAlreadyRotated = false;
    }

    public void Reverse()
    {

    }
}
