using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAndStop : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody rb;
    private float timer;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        timer = 0f;
        ApplyForce();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 6f)
        {
            StopMovement();
        }
    }

    void ApplyForce()
    {
        Vector3 force = transform.forward * speed;
        rb.AddForce(force, ForceMode.VelocityChange);
    }

    void StopMovement()
    {
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
    }
}