using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] blocks;
    public GameObject[] coins;  

    private Vector2 spawnPositionBlock;
    private Vector3 spawnPositionCoin;

    private int blockIndex;
    private int coinIndex;

    private float startDelayB = 1.5f;
    private float startDelayC = 5f;

    private PlayerControllerX playerController;

    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerControllerX>();

        float repeatWidthC = Random.Range(8, 15);
        float repeatWidthB = 1.6f;

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
        spawnPositionBlock = new Vector2(14,1);
        Instantiate(blocks[blockIndex], spawnPositionBlock, blocks[blockIndex].transform.rotation);
    }

    void spawnCoin()
    {
        coinIndex = Random.Range(0, 5);
        float randomX = Random.Range(2,13);
        float randomY = Random.Range(-1,4);
        spawnPositionCoin = new Vector3(randomX, randomY, -0.1f);
        Instantiate(coins[coinIndex], spawnPositionCoin, coins[coinIndex].transform.rotation);
    }
}
