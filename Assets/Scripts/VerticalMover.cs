using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMover : MonoBehaviour
{
    public float speed;     // Speed of movement
    public float maxHeight; // Maximum height the cube will reach
    public float minHeight; // Minimum height (usually the ground)

    private bool goingUp = true;   // Direction flag

    void Update()
    {
        // Determine movement direction based on cube's current position
        if (transform.position.y >= maxHeight)
        {
            goingUp = false;
        }
        else if (transform.position.y <= minHeight)
        {
            goingUp = true;
        }

        // Move the cube vertically
        if (goingUp)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime, Space.World);
        }
        else
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime, Space.World);
        }
    }
}