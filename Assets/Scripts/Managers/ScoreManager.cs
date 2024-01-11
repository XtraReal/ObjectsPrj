using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScoreManager : MonoBehaviour
{
    private int score;
    public UnityEvent OnScoreUpdated;
    private int highScore;

    public int GetScore()
    {
        return score;
    }

    public int GetHighScore()
    {
        return highScore;
    }

    public void IncrementScore() 
    { 
        score++;
        SetHighScore();
        OnScoreUpdated?.Invoke(); // ? is a nullable checking if there are any functions attached to this event and if none it doesn't get called
    }

    private void SetHighScore()
    {
        if (score >= highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("HIGHSCORE", highScore);
        }
        
    }

    public void DecrementScore() { score--; }
    
    void Start()
    {
        if(PlayerPrefs.HasKey("HIGHSCORE"))
        {

            highScore = PlayerPrefs.GetInt("HIGHSCORE");
        }
        else
        {
            PlayerPrefs.SetInt("HIGHSCORE", highScore);

        }
        OnScoreUpdated?.Invoke();
    }
    
    void Update()
    {

    }

    //public void UpdateScore()
    //{
    //    scoreTxt.SetText(GameManager.GetInstance().scoreManager.GetScore().ToString());

    //}
}
