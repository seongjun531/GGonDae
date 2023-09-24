using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningSpawn : MonoBehaviour
{
    public GameObject lightn;
    public float spawnInterval = 1.5f;
    public int MaxrandX, MinrandX = 0;
    public int MaxrandY, MinrandY = 0;
    private float timer = 0f;

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0f){
            SpawnLightning();
            timer = spawnInterval;
        }

    }
    void SpawnLightning()
    {
        float randX = Random.Range(MinrandX, MaxrandX);
        float randY = Random.Range(MinrandY, MaxrandY);
        Vector2 spawnPoint = new Vector2(randX, randY);
        Instantiate(lightn, spawnPoint, Quaternion.identity);
    }
}
