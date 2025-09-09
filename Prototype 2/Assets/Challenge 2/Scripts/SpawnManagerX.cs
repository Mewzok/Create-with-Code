using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float spawnInterval = 4.0f;

    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        spawnInterval = Random.Range(3.0f, 5.0f);
        timer = spawnInterval;
    }

    void Update() {
        timer -= Time.deltaTime;
        if(timer <= 0f) {
            SpawnRandomBall();
            spawnInterval = Random.Range(3.0f, 5.0f);
            timer = spawnInterval;
        }
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // randomly generate ball type
        int ballIndex = Random.Range(0, ballPrefabs.Length);

        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
    }

}
