using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public static ScoreCounter Instance;
    [SerializeField] GameObject GameOverText;
    [SerializeField] Text totalTimeSpend;
    [SerializeField] Text totalCoinsCollected;
    [SerializeField] Text currentCoinValue;
  
    void Start()
    {
        if (Instance == null)
            Instance = this;
    }

    int scoreCount = 0;

    //Increase the score count every time the player touches the coins.
   public void IncreaseScoreCount()
    {
        scoreCount++;
        currentCoinValue.text = scoreCount.ToString();
        
    }

    ///Show the gameover text
    public void ShowGameOver()
    {
        Time.timeScale = 0;
        GameOverText.SetActive(true);
        totalCoinsCollected.text ="Total Coins : " + TotalScore().ToString();
        totalTimeSpend.text = "Total Time : " + (30f - FindObjectOfType<TimeCounter>().tempTime).ToString();
    }
    public int TotalScore()
    {
        return scoreCount;
    }
}
