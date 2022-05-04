using UnityEngine;

public static class SaveGame
{
    public static void SavePoints(int Points)
    {
        PlayerPrefs.SetInt("POINTS", Points);
        PlayerPrefs.Save();
    }

    public static int GetPoints()
    {
        return PlayerPrefs.GetInt("POINTS");
    }
}
