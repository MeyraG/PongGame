using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField]
    float speed = 5f;
    //float speeding = 0.8f;
    //float maxSpeed = 10f;

    //bool move;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        InitialForce();
    }

    public void InitialForce()
    {
        Vector3 direction = new Vector3(Random.Range(3, 5), 0, 0).normalized;
        rb.AddForce(direction * speed, ForceMode.Impulse);
    }

    void Update()
    {
        //transform.position += transform.right * speed * Time.deltaTime;
        //speed += speeding * Time.deltaTime;
        //if (speed > maxSpeed)
        //{
        //    speed = maxSpeed;
        //}
    }
}
