using UnityEngine;
using UnityEngine.UI;

public class PointManager : MonoBehaviour
{
    public static PointManager instance;

    public Text scoreText; 
    public Text highscoreText;

    int score = 0;
    int highscore; 

    void Awake()
    {   
        instance = this;
    }

    private void Start()
    {
        highscore = SaveGame.GetHighScore();
        scoreText.text = score.ToString() + " POINTS";
        highscoreText.text = "HIGHSCORE: " + highscore.ToString();
    }

    public int getScore()
    {
        return score;
    }

    public void AddPoints(int pointsToAdd)
    {
        score += pointsToAdd;
        scoreText.text = score.ToString() + " POINTS";
        if(highscore < score)
        {
            highscore = score; 
            SaveGame.SaveHighScore(highscore);
            highscoreText.text = "HIGHSCORE: " + highscore.ToString();
        }
    }

    public void SavePoints()
    {
        SaveGame.SaveHighScore(highscore);
    }
}
