using UnityEngine;

public static class SaveGame
{
    public static void SaveHighScore(int Points)
    {
        PlayerPrefs.SetInt("POINTS", Points);
        PlayerPrefs.Save();
    }

    public static int GetHighScore()
    {
        return PlayerPrefs.GetInt("POINTS");
    }    
}
