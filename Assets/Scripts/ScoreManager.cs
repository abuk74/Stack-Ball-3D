using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public int score = 0;
    private Text scoreText;

    void Awake()
    {
        scoreText = GameObject.Find("Text").GetComponent<Text>();
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }  
    }
    void Start()
    {
        AddScore(0);
    }
    void Update()
    {
        if (scoreText == null)
        {
            scoreText = GameObject.Find("Text").GetComponent<Text>();
            scoreText.text = score.ToString();
        }
    }
    public void AddScore(int amount)
    {
        score += amount;
        if (score > PlayerPrefs.GetInt("HighScore", 0))
            PlayerPrefs.SetInt("HighScore", score);
        scoreText.text = score.ToString();
    }
    public void ResetScore()
    {
        score = 0;
    }
}
