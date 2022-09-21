using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour{
    [SerializeField] public List<GameObject> enemy;
    [SerializeField] List<GameObject> enemyList;
    [SerializeField] int enemyLength;
    [SerializeField] float timeToSpawn;
    float PlaceY;
    public float timer = 0;
    int enemyCounter;
    bool full = false;
    Player player;

    void Start(){
        //spawnObjects();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    /*public void spawnObjects(){
        destroyObjects();
        int randomItem = 0;
        GameObject toSpawn;

        float screenY;
        Vector2 pos;
        for (int i =0; i<enemyLength; i++){
            randomItem = Random.Range(0,enemyList.Count);
            toSpawn = enemyList[randomItem];

            screenY = Random.Range(-2,7);
            pos = new Vector2(3, screenY);

            Instantiate(toSpawn, pos, toSpawn.transform.rotation);
        }
    }*/

    private void destroyObjects(){
        foreach(GameObject o in GameObject.FindGameObjectsWithTag("Enemy")){
            Destroy(o);
        }
    }

    void disableAll(){
        foreach (GameObject go in this.enemyList){
            go.SetActive(false);
        }
    }

    private void Awake(){
    }

    void Update(){
        timer += Time.deltaTime;
        if (timer >=timeToSpawn){
            enemyCounter++;
            if (enemyCounter<=enemyLength && full==false){
                timer = 0.0f;
                SpawnEnemy();
            }
            else{
                 enemyCounter = 0;
                 full = true;
            }
            enemyCounter = 0;
            for (int i = enemyCounter; i < enemyLength; i++)
            {
                if (enemyList[i].transform.position.x < -1)
                {
                    enemyList[i].SetActive(false);
                    break;
                }
            }
        }
    }

    void SpawnEnemy(){
        destroyObjects();
        timer = 0;

        GameObject toSpawn;
        int enemyCounter = 0;
        float screenY;
        Vector2 pos;

        for (int i = enemyCounter; i<enemyLength; i++){
            if (!enemyList[i].activeInHierarchy){
                enemyCounter = i+1;
                toSpawn = enemyList[i];

                screenY = Random.Range(-1,5);
                pos = new Vector2(3, screenY);
                Instantiate(toSpawn, pos, toSpawn.transform.rotation);
                break;
            }
        }
    }
}
