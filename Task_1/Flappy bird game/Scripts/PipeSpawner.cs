using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2f;  // Adjust this value to control the spawn frequency
    private float timer = 0f;
    public float heightOffset = 10f;  // Adjust this to control the vertical range of pipe spawning

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        // Increment timer by deltaTime
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            // Spawn a new pipe and reset the timer
            spawnPipe();
            timer = 0f;
        }
    }

    // Function to spawn a new pipe
    void spawnPipe()
    {
        // Set the lowest and highest points for pipe's vertical position
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        // Instantiate a new pipe at a random Y position
        GameObject newPipe = Instantiate(pipe, new Vector3(10f, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
        Debug.Log("Pipe spawned at: " + newPipe.transform.position);
    }
}
