using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public Transform [] spawnPoint;
    public GameObject PowerUp;
    public float timeBetweenSpawn; 
    public float TimeLeft;

    void Start()
    {
        SpawnObject();
        TimeLeft = timeBetweenSpawn;
    }

    void Update()
    {
        if (GameObject.FindGameObjectWithTag("PowerUp") == null)
        {
            SpawnObject();
        }
    }

    void SpawnObject()
    {
        Transform spawn = spawnPoint[Random.Range(0, spawnPoint.Length)];
        Instantiate (PowerUp, spawn.position, spawn.rotation );
    }
  
}