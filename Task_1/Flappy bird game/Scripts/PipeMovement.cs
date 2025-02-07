using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public float movementSpeed = 5f; 
    private float DeadZone = -15f;    
   
    void Update()
    {
        transform.position += Vector3.left * movementSpeed * Time.deltaTime;
        if (transform.position.x < DeadZone)
        {
            Destroy(gameObject);
        }
    }
}
