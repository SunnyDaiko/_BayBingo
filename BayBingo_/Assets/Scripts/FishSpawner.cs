using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpawner : MonoBehaviour
{
    
    public Transform[] spawnPoints;
    [SerializeField]
    public GameObject[] Fish;
    public float spawnTime;
    public float spawnDelay;
    //public bool stop = false;

    void Start()
    {
        //this keeps the fish spawning for ever
        InvokeRepeating("Spawn", spawnTime, spawnDelay);
    }
    void Spawn()
    {
        //generates which fish gets spawned
        int randFish = Random.Range(0, Fish.Length);
        //the spawn point for specific fish depths
        int randSpawnPoint = Random.Range(0, spawnPoints.Length);
        //Instantiates the spawner
        Instantiate(Fish[randFish], spawnPoints[randSpawnPoint].position, transform.rotation);

        /*if (randFish > 0)
        {
            CancelInvoke("Spawn");
        }*/

    }
}
