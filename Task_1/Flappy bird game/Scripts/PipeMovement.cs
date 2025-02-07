using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public float movementSpeed = 5f;  // Speed at which the pipes move
    private float DeadZone = -15f;    // The position where pipes will be destroyed

    // Update is called once per frame
    void Update()
    {
        // Move the pipe to the left
        transform.position += Vector3.left * movementSpeed * Time.deltaTime;

        // Destroy the pipe when it reaches the DeadZone
        if (transform.position.x < DeadZone)
        {
            Destroy(gameObject);
        }
    }
}
