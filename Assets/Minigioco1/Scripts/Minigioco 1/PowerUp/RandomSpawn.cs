using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public Transform[] spawnPoint;
    public GameObject PowerUp;
    void Start()
    {
        Transform spawn = spawnPoint[Random.Range(0, spawnPoint.Length)];
        Instantiate (PowerUp, spawn.position, spawn.rotation );
    }
}