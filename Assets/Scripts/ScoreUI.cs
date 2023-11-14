using TMPro;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI highScoreText;

    public void UpdateScoreText(int score)
    {
        scoreText.text = score.ToString();

        int highScore = Score.GetHighScore();
        highScoreText.text = highScore.ToString();
    }
}
