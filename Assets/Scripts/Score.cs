using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Score
{
    public const string HIGH_SCORE = "highScore"; // Clave en PlayerPrefs

    public static int GetHighScore()
    {
        return PlayerPrefs.GetInt(HIGH_SCORE, 0);
    }
}
