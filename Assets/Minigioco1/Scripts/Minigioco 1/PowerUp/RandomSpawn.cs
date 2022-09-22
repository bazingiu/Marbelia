using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public Transform [] spawnPoint;
    public GameObject PowerUp;


    void Start()
    {
        SpawnObject();
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