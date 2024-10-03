using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Logicmanager : MonoBehaviour
{
    public int playerScore;
    private int playerHighScore;
    public Text scoreText;
    public Text highsoreText;
    public GameObject gameOverSreen;

    private void Start()
    {
        playerHighScore = PlayerPrefs.GetInt("HighScore", 0); 
        highsoreText.text = playerHighScore.ToString();
    }

    public void AddScrore()
    {
        playerScore++;
        scoreText.text = playerScore.ToString();
        if (playerScore > playerHighScore)
        {
            playerHighScore = playerScore;
            highsoreText.text = playerHighScore.ToString();
            PlayerPrefs.SetInt("HighScore", playerHighScore);
            PlayerPrefs.Save(); 
        }
    }

    public void Restartgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Gameover()
    {
        gameOverSreen.SetActive(true);
    }
}
