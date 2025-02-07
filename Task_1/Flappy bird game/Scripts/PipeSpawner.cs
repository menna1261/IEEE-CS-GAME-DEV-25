using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2f;  
    private float timer = 0f;
    public float heightOffset = 10f; 


    void Start()
    {
        spawnPipe();
    }

    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0f;
        }
    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        GameObject newPipe = Instantiate(pipe, new Vector3(10f, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
        Debug.Log("Pipe spawned at: " + newPipe.transform.position);
    }
}
