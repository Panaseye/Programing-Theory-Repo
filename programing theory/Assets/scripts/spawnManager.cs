using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class spawnManager : MonoBehaviour
{
    
    
    [SerializeField] GameObject[] colorPrefabs;
    [SerializeField] float spawnRangeX = 15f;
    [SerializeField] float spawnPosZ = 20f;
    [SerializeField] float startDelay = 2;
    [SerializeField] float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("SpawnRandomColor", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomColor()
    {
        int colorIndex = Random.Range(0, colorPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(colorPrefabs[colorIndex], spawnPos, colorPrefabs[colorIndex].transform.rotation);
    }
}
