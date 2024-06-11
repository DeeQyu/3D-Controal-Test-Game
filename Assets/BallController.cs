using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public Transform cameraPivot; // A GameObject to pivot the camera around
    private Rigidbody rb;
    private Transform mainCamera;
    private bool isMovingForward = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        mainCamera = Camera.main.transform;
    }

    private void Update()
    {
        // Get input from the W key
        if (Input.GetKey(KeyCode.W))
        {
            isMovingForward = true;
        }
        else
        {
            isMovingForward = false;
        }

        // Calculate the movement direction
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput).normalized;

        // Apply the movement to the rigidbody
        rb.velocity = movement * moveSpeed;

        // Rotate the camera pivot to follow the ball
        if (isMovingForward)
        {
            cameraPivot.LookAt(transform);
        }
    }
}
