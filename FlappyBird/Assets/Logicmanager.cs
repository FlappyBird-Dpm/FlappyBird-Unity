using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Logicmanager : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;

    
    public void Awake()
    {
        scoreText.text = playerScore.ToString();
    }
}
