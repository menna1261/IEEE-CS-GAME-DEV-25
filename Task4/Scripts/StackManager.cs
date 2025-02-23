using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackManager : MonoBehaviour
{
    //Create a new object of the Custom stack
    CustomStack<GameObject>boxes = new CustomStack<GameObject>();
    //Reference to the box prefab
    public GameObject boxPrefab;
    private float BoxHeight = 1f;
    //The starting position where the first box will be instantiated
    private Vector3 startingPosition = new Vector3(0, 0.5f, 0);

    void Start()
    {
        if (Input.GetKeyUp(KeyCode.A))
        {
        // If this is the first box, instantiate it in the starting position (will only happen once)
            if (boxes.IsEmpty())
            {
                GameObject firstBox = Instantiate(boxPrefab, startingPosition, Quaternion.identity);
                boxes.Push(firstBox);

            }
        }

    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {

            removeBox();
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            addBox();
        }
        
    }

    void addBox()
    {
            //Compute the new height 
            float newY = startingPosition.y + boxes.Count() * BoxHeight;
            //Calculate the new position, here I added a random value on the x position to use it as an offset to make it look more realistic 
            Vector3 position = new Vector3(Random.Range(0.3f, -0.3f), newY, startingPosition.z);
            GameObject newBox = Instantiate(boxPrefab, position, Quaternion.identity);
            boxes.Push(newBox);
        
    }

    void removeBox()
    {
        if (!boxes.IsEmpty())
        {
            GameObject boxToRemove = boxes.Pop();
            Destroy(boxToRemove);
        }

    }


}
