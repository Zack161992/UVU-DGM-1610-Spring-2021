using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] objectPrefabs;
    private float maxSpawnHeight = 15f;
    private float minSpawnHeight = 5f;
    private float maxRepeateRate = 4f;
    private float minRepeateRate = .75f;
    private float timer;
    private float repeateRate;
    private float spawnHeight;
    


    // Start is called before the first frame update
    void Start()
    {
        repeateRate = Random.Range(minRepeateRate, maxRepeateRate);
        spawnHeight = Random.Range(minSpawnHeight, maxSpawnHeight);
    }
    
    private void Update()
    {
        timer += Time.deltaTime;
        if(timer > repeateRate)
        {
            SpawnObjects();
            repeateRate = Random.Range(minRepeateRate, maxRepeateRate);
            spawnHeight = Random.Range(minSpawnHeight, maxSpawnHeight);
            timer = 0;
        }
    }

    // Spawn obstacles
    void SpawnObjects ()
    {
        if (PlayerControllerX.gameOver == false)
        {
            // Set random spawn location and random object index
            Vector3 spawnLocation = new Vector3(30, spawnHeight, 0);
            int index = Random.Range(0, objectPrefabs.Length);
            Instantiate(objectPrefabs[index], spawnLocation, objectPrefabs[index].transform.rotation);
        }

    }
}
