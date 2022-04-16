using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleAI : MonoBehaviour
{
    public Rigidbody ball;
    public Rigidbody rb;
    [SerializeField]
    float speed = 10f;
    void Awake()
    {
       rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (this.ball.velocity.x > 0.0f)
        {
            if (this.ball.position.z > this.transform.position.z)
            {
                rb.AddForce(Vector3.forward * this.speed);
            }
            else if (this.ball.position.z < this.transform.position.z)
            {
                rb.AddForce(Vector3.back * this.speed);
            }
        }

        else
        {
            if (this.transform.position.z > 0.0f)
            {
                rb.AddForce(Vector3.back * this.speed);
            }
            else if (this.transform.position.z < 0.0f)
            {
                rb.AddForce(Vector3.forward * this.speed);
            }
        }
    }
}
