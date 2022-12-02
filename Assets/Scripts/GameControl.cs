
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{

    public Text scoreText, timeText;
    public float startTime = 10.0f;
    public GameObject gameOverText, finishText;

    private float currentTime;
    private int scoreCounter, timeCounter;

    void Start()
    {
          currentTime = startTime;
        gameOverText.SetActive(false);
        finishText.SetActive(false);
    }


    void Update()
    {
        currentTime -= Time.deltaTime;
        timeCounter = (int)currentTime;

        if(currentTime <= 0.0f)
        {
            timeCounter = 0;

            gameOverText.SetActive(true);
        }


        scoreText.text = "Score: " + scoreCounter;
        timeText.text = "Time: " + timeCounter;
    }

    public void IncreaseScore(int points)
    {
        scoreCounter += points;
    }

    public void GameFinished()
    {
        finishText.SetActive(true);
    }
}
