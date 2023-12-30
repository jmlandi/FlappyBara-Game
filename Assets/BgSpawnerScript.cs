using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class BgSpawnerScript : MonoBehaviour
{

    public GameObject background;
    public float spawnRate = 2;
    public float spawnPositionX = 30;
    private float timer = 0;


    void Start()
    {
        SpawnBackground(0, 0, 0);
        SpawnBackground(spawnPositionX, 0, 0);
    }

    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        } else
        {
            SpawnBackground(spawnPositionX, 0, 0);
        }
        
    }

    void SpawnBackground(float x, float y, float z)
    {
            Instantiate(background, new Vector3(x, y, z), transform.rotation);
            timer = 0;
    }
}
