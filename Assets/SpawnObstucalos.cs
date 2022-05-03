using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstucalos : MonoBehaviour
{
    public GameObject obstucalo;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float timebetweenSpawn;
    private float spawnTime;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if(Time.time> spawnTime)
        {
            Spawn();
            spawnTime = Time.time + timebetweenSpawn;
        }
    }
    void Spawn()
    {
        float ramdomX = Random.Range(minX, maxX);
        float ramdomY = Random.Range(minY, maxY);

        Instantiate(obstucalo, transform.position + new Vector3(ramdomX, ramdomY, 0), transform.rotation);
    }

}
