using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpeed : MonoBehaviour
{
    private int impactCount;
    BallControl ballControl;

    [SerializeField]
    float impactMultiplier = 0.2f;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Player") || collision.collider.CompareTag("Player1"))
        {
            impactCount++;
            ballControl.speed += impactMultiplier * impactCount;
        }

    }


    // Start is called before the first frame update
    void Start()
    {
       ballControl = GetComponent<BallControl>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
