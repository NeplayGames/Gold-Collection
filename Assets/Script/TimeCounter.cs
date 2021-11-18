using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour
{
    [SerializeField]float gameTime = 30;
    [SerializeField] Text timerText;
    public int tempTime;

    void Start()
    {
        tempTime = (int)gameTime;
        timerText.text = tempTime.ToString();

    }
    
    // Update is called once per frame
    void Update()
    {
        if (gameTime > 0)
        {
            gameTime -= Time.deltaTime;
            if((int)gameTime != tempTime)
            {
                tempTime = (int)gameTime;
                timerText.text = tempTime.ToString();
            }
        }
        else
        {
            ScoreCounter.Instance.ShowGameOver();
        }
    }
}
