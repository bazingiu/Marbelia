using UnityEngine;

public class PointManager : MonoBehaviour
{
    public static PointManager instance;
    [SerializeField] int points;

    void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        SaveGame.SavePoints(0);
        points = SaveGame.GetPoints();
    }

    public void AddPoints(int pointsToAdd)
    {
        points += pointsToAdd;
        print(points);
    }

    public void SavePoints()
    {
        SaveGame.SavePoints(points);
    }
}
