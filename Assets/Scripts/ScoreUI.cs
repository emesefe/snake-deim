using System;
using TMPro;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    public static ScoreUI Instance { get; private set; }
    
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI highScoreText;

    private void Awake()
    {
        if (Instance != null)
        {
            Debug.LogError("More than one Instance");
        }

        Instance = this;
    }
    

    public void UpdateScoreText(int score)
    {
        scoreText.text = score.ToString();

        int highScore = Score.GetHighScore();
        highScoreText.text = highScore.ToString();
    }
}
