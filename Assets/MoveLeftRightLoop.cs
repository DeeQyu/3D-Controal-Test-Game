using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftRightLoop : MonoBehaviour
{
    public float moveDistance = 5.0f; // The distance the object will move left and right.
    public float moveSpeed = 2.0f;    // The speed of the movement.

    private Vector3 startPosition;
    private Vector3 targetPosition;
    private bool movingRight = true;

    void Start()
    {
        // Record the starting position and calculate the target position.
        startPosition = transform.position;
        targetPosition = startPosition + Vector3.right * moveDistance;
    }

    void Update()
    {
        // Move the object left and right.
        if (movingRight)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

            // If the object reaches the target position, change direction.
            if (Vector3.Distance(transform.position, targetPosition) < 0.01f)
            {
                movingRight = false;
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, startPosition, moveSpeed * Time.deltaTime);

            // If the object reaches the starting position, change direction.
            if (Vector3.Distance(transform.position, startPosition) < 0.01f)
            {
                movingRight = true;
            }
        }
    }
}
