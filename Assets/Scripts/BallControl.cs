using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    public Rigidbody rb;
    GameManager gameManager;

    
    public float speed = 22f;

    [HideInInspector]
    public float defaultSpeed;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        ResetPosition();
        defaultSpeed = speed;
    }

    float hitFactor(Vector3 ballpos, Vector3 paddlePos, float paddleHeight) 
    {
        return (ballpos.z - paddlePos.z) / paddleHeight;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player1")
        {
            float z = hitFactor(transform.position, collision.transform.position, collision.collider.bounds.size.z);

            Vector3 dir = new Vector3(1, 0, z).normalized;

            GetComponent<Rigidbody>().velocity = dir * speed;       
        }

        if (collision.gameObject.GetComponent<PlayerAI>())
        {
            float z = hitFactor(transform.position, collision.transform.position, collision.collider.bounds.size.z);

            Vector3 dir = new Vector3(-1, 0, z).normalized;

            GetComponent<Rigidbody>().velocity = dir * speed;
        }
    }

    public void InitialForce()
    {
        Vector3 direction = new Vector3(Random.Range(3, 5), 0, 0).normalized;
        rb.AddForce(direction * 80, ForceMode.Force);
    }

    public void ResetPosition()
    {
        rb.position = new Vector3(0, 1, -2);
        rb.velocity = new Vector3(0, 0, 0);
        Invoke("InitialForce",0.4f);    
    }
}