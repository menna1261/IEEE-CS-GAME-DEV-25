using UnityEngine;

public class birdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public LogicalManager logic;
    public bool birdIsAlive = true;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicalManager>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigidbody.velocity = Vector2.up * 8;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}