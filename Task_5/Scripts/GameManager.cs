using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> characterObjects; 
    private CustomQueue turnQueue = new CustomQueue();

    void Start()
    {
        // Initialize and add all characters to queue
        foreach (GameObject obj in characterObjects)
        {
            Character character = obj.GetComponent<Character>();
            if (character != null)
            {
                turnQueue.Enqueue(character);
            }
        }

        StartCoroutine(GameLoop());
    }

    IEnumerator GameLoop()
    {
        int round = 1;
        while (!turnQueue.IsEmpty())
        {
            Debug.Log("Round " + round);
            turnQueue.PrintQueue(); // Print the queue at the start of each round

            int roundSize = turnQueue.Count();
            for (int i = 0; i < roundSize; i++)
            {
                Character currentCharacter = turnQueue.Dequeue();

                // Character takes damage
                currentCharacter.TakeDamage();

                // If still alive, re-enqueue
                if (!currentCharacter.isDead())
                {
                    turnQueue.Enqueue(currentCharacter);
                }
            }

            yield return new WaitForSeconds(1f); 
            round++;
        }

        Debug.Log("Game Over! No characters left.");
    }
}
