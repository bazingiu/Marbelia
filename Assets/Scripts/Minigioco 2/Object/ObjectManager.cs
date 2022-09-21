using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    [SerializeField] public List<GameObject> objects;
    [SerializeField] List<GameObject> objectList;
    [SerializeField] int objectLength;
    [SerializeField] float timeToSpawn;
    float PlaceY;
    public float timer = 0;

    int objectCounter;
    bool full = false;

    void Start(){
        //spawnObjects();
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
        foreach(GameObject o in GameObject.FindGameObjectsWithTag("Object")){
            Destroy(o);
        }
    }

    void disableAll(){
        foreach (GameObject go in this.objectList){
            go.SetActive(false);
        }
    }

    private void Awake(){
    }

    void Update(){
        timer += Time.deltaTime;
        if (timer >=timeToSpawn){
            objectCounter++;
            if (objectCounter<=objectLength && full==false){
                timer = 0.0f;
                SpawnObject();
            }
            else{
                 objectCounter = 0;
                 full = true;
            } 
        }
    }

    void SpawnObject(){
        destroyObjects();
        timer = 0;

        GameObject toSpawn;
        int objectCounter = 0;
        float screenY;
        Vector2 pos;

        for (int i = objectCounter; i<objectLength; i++){
            if (!objectList[i].activeInHierarchy){
                objectCounter = i+1;
                toSpawn = objectList[i];
                screenY = Random.Range(-1,5);
                pos = new Vector2(3, screenY);
                Instantiate(toSpawn, pos, toSpawn.transform.rotation);
                break;
            }
        }
    }
}
