using UnityEngine;
using System.Collections;

// CONTROLLARE SE FUNZIONA BENE IL SISTEMA DI SPAWN 
public class WaveManager : MonoBehaviour
{
    public enum SpawnState {SPAWNING, WAITING, COUNTING};

    // La nostra ondata di nemici
    [System.Serializable]
    public class Wave
    {
        public string name;
        public GameObject [] enemy; 
        public Transform [] SpawnPosition;
        public int count;
        public float rate; 
    }

    // la gestione delle nostre ondate
    public Wave [] waves;
    private int nextWave = 0; 

    private float timeBetweenWaves = GameData.timeBetweenWaves;

    public float waveCountdown; 

    private float searchCountdown = GameData.searchCountdown; 

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
                WaveCompleted();
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
    
    void WaveCompleted() {
        state = SpawnState.COUNTING; 
        waveCountdown = timeBetweenWaves; 

        if(nextWave + 1 > waves.Length - 1)
        {
            nextWave = 0; 
            // Va in loop ma aggiungeremo qui il codice per dire che sei riuscito a completare
            //Aggiungere schermata di vittoria!!!!
            Debug.Log("Completed all waves");
        }
        else
        {
            nextWave++; 
        }
    }

    bool EnemyIsAlive()
    {
        searchCountdown -= Time.deltaTime;
        if(searchCountdown <= 0)
        {
            searchCountdown = GameData.searchCountdown;
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
            GameObject typeOfEnemy = _wave.enemy[Random.Range(0,_wave.enemy.Length)];
            Transform spawn = _wave.SpawnPosition[Random.Range(0,_wave.SpawnPosition.Length)];
            SpawnEnemy(typeOfEnemy, spawn);
            yield return new WaitForSeconds(1f/_wave.rate);
        }
        state = SpawnState.WAITING;
        yield break;
    }

    void SpawnEnemy (GameObject enemy, Transform SpawnPosition )
    {
        // Debug.Log("Spawning Enemy: " + enemy.name);
        Instantiate (enemy, SpawnPosition.position, SpawnPosition.rotation );
    }
}