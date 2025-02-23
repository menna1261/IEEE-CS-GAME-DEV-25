using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackManager : MonoBehaviour
{
    CustomStack<GameObject>boxes = new CustomStack<GameObject>();
    public GameObject boxPrefab;
    private float BoxHeight = 1f;
    private Vector3 startingPosition = new Vector3(0, 0.5f, 0);

    void Start()
    {
        if (Input.GetKeyUp(KeyCode.A))
        {
            if (boxes.IsEmpty())
            {
                GameObject firstBox = Instantiate(boxPrefab, startingPosition, Quaternion.identity);
                boxes.Push(firstBox);

            }
        }

    }

    // Update is called once per frame
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
         
            float newY = startingPosition.y + boxes.Count() * BoxHeight;
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
