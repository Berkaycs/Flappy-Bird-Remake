using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] blocks;
    public GameObject[] coins;  

    private Vector2 spawnPositionBlock;
    private Vector2 spawnPositionCoin;

    private int blockIndex;
    private int coinIndex;

    private float startDelayB = 1.5f;
    private float repeatWidthB = 1.5f;

    private float startDelayC = 5f;

    // Start is called before the first frame update
    void Start()
    {
        float repeatWidthC = Random.Range(8,15);
        InvokeRepeating("spawnBlock", startDelayB, repeatWidthB);
        InvokeRepeating("spawnCoin", startDelayC, repeatWidthC);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnBlock()
    {
        blockIndex = Random.Range(0, 4);
        spawnPositionBlock = new Vector2(5.5f,1);
        Instantiate(blocks[blockIndex], spawnPositionBlock, blocks[blockIndex].transform.rotation);
    }

    void spawnCoin()
    {
        coinIndex = Random.Range(0, 5);
        float randomX = Random.Range(-2,13);
        float randomY = Random.Range(-1,4);
        spawnPositionCoin = new Vector2();
        Instantiate(coins[coinIndex], spawnPositionCoin, coins[coinIndex].transform.rotation);
    }
}
