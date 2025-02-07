using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicalManager logic;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicalManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("area entered");
        if (collision.gameObject.layer == 3)
        {
            logic.addScore();
        }

    }

}