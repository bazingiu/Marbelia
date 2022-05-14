// using UnityEngine;

// public class EnemyManager : MonoBehaviour
// {
//     [SerializeField] GameObject enemy;
//     [SerializeField] GameObject[] enemyList;
//     [SerializeField] int enemyLength;

//     [SerializeField] Transform spawnPoint; 
//     [SerializeField] float timeToSpawn;
//     float timer = 0;
//     int enemyCounter = 0;

//     // Instanzia i nemici dopo la partenza 
//     private void Awake()
//     {
//         enemyList = new GameObject[enemyLength];
//         for(int i=0; i< enemyLength; i++)
//         {
//             enemyList[i] = Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
//         }
//     }

//     private void Update()
//     {
//         timer += Time.deltaTime;
//         if (timer >= timeToSpawn)
//         {
//             SpawnEnemy();
//         }
//     }

//     void SpawnEnemy()
//     {
//         timer = 0;

//         for(int i = enemyCounter; i < enemyLength; i++)
//         {

//             if (!enemyList[i].activeInHierarchy)
//             {

//                 enemyList[i].GetComponent<Enemy>().Spawn(spawnPoint);
                
//                 enemyCounter = i + 1;
//                 if(enemyCounter >= enemyLength)
//                 {
//                     enemyCounter = 0;
//                 }
//                 break;
//             }
//         }

//     }
// }
