using UnityEngine;

public class testingCollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger entered with: " + other.gameObject.name);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision entered with: " + collision.gameObject.name);
       
    }
}
