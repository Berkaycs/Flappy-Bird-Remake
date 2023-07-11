using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] spawnList;
    private int spawnIndex;
    private Vector2 spawnPos;
    // parameters of block
    private float startDelayB = 1;
    private float repeatRateB = 2f;
    // parameters of coin
    private float startDelayC = 3;
    private float repeatRateC;

    // Start is called before the first frame update
    void Start()
    {
        float repeatRateC = Random.Range(10, 20);
        InvokeRepeating("RandomSpawnBlock", startDelayB, repeatRateB);
        InvokeRepeating("RandomSpawnCoin", startDelayC, repeatRateC);
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    void RandomSpawnBlock()
    {
        spawnIndex = Random.Range(0, 4);
        spawnPos = new Vector2(8, 1);
        Instantiate(spawnList[spawnIndex], spawnPos, spawnList[spawnIndex].transform.rotation);
    }

    void RandomSpawnCoin()
    {
        float randomX = Random.Range(0, 12);
        float randomY = Random.Range(-1, 4);
        spawnIndex = Random.Range(4,9);
        spawnPos = new Vector2(randomX, randomY);
        Instantiate(spawnList[spawnIndex], spawnPos, spawnList[spawnIndex].transform.rotation);
    }

    /*
    void RandomSpawnPoint()
    {
        float randomX = Random.Range(18, 30);
        spawnPos = new Vector3(randomX, spawnList[spawnIndex].transform.position.y);
    }
    */
}
