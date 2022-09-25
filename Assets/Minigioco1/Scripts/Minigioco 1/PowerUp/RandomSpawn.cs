using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public Transform [] spawnPoint;
    public GameObject[] PowerUp;
    int counter;

    void Start()
    {
        SpawnObject();
        counter = 0;
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
        GameObject powerup = PowerUp[Random.Range(0,2)];
        Transform spawn = spawnPoint[Random.Range(0, spawnPoint.Length)];
        Instantiate (powerup, spawn.position, spawn.rotation );
    }
  
}