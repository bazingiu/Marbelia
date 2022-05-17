
using UnityEngine;
using System.Collections;

public class WaveManager : MonoBehaviour
{
    public enum SpawnState {SPAWNING, WAITING, COUNTING};

    // La nostra ondata di nemici
    [System.Serializable]
    public class Wave
    {
        public string name;
        public GameObject enemy; 
        public Transform SpawnPosition;
        public int count;
        public float rate; 
    }

    // la gestione delle nostre ondate
    public Wave [] waves;
    private int nextWave = 0; 

    public float timeBetweenWaves = 5f; 
    public float waveCountdown; 

    private float searchCountdown = 1f; 

    private SpawnState state = SpawnState.COUNTING;
    void Start()
    {
        waveCountdown = timeBetweenWaves;
    }

    void Update()
    {
        if (state == SpawnState.WAITING)
        {
           if (!EnemyIsAlive())
           {
                //begin a new round
                Debug.Log("Wave completed");
           }
           else 
            return;
        }
        if(waveCountdown <= 0)
        {
            if(state != SpawnState.SPAWNING)
                StartCoroutine(SpawnWave(waves[nextWave]));
            else
            {
                waveCountdown -= Time.deltaTime;
            } 
        }
        else 
            waveCountdown -= Time.deltaTime;
    }

    bool EnemyIsAlive()
    {
        searchCountdown -= Time.deltaTime;
        if(searchCountdown <= 0)
        {
            searchCountdown = 1f;
            if(GameObject.FindGameObjectWithTag("Enemy") == null )
                return false;
        }
            return true;
    }

    IEnumerator SpawnWave(Wave _wave)
    {
        Debug.Log("Spawning Wave: " + _wave.name);
        state = SpawnState.SPAWNING;
        
        for( int i = 0; i < _wave.count; i++ )
        {
            SpawnEnemy(_wave);
            yield return new WaitForSeconds(1f/_wave.rate);
        }
        state = SpawnState.WAITING;
        yield break;
    }

    void SpawnEnemy (Wave _wave)
    {
        Debug.Log("Spawning Enemy: " + _wave.enemy.name);
        Instantiate (_wave.enemy, _wave.SpawnPosition.position, _wave.SpawnPosition.rotation );
    }
}