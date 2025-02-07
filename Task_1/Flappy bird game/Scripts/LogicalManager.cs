using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicalManager : MonoBehaviour
{
    public Text text;
    public GameObject gameOverScreen;
    private int playerScore = 0;

    [ContextMenu("increase score")]
    public void addScore()
    {
        Debug.Log("score is being updated");
        playerScore += 1;
        text.text = playerScore.ToString();
        
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}


