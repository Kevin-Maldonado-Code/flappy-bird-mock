using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BongCloudSpawnerScript : MonoBehaviour
{
    public GameObject bongCloud;
    public float spawnRate = 4;
    private float timer = 0;
    public float heightOffset = 4;

    // Start is called before the first frame update
    void Start()
    {
        initialBongClouds();
        spawnBongClouds();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        } else
        {
            spawnBongClouds();
            timer = 0;
        }
    }

    void initialBongClouds()
    {
        Instantiate(bongCloud, new Vector3(-9, 2, 0), transform.rotation);
    }

    void spawnBongClouds()
    {
        //float highestPoint = transform.position.y + heightOffset;
        //float lowestPoint = transform.position.y - heightOffset;

        //Instantiate(bongCloud, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);

        Instantiate(bongCloud, transform.position, transform.rotation);
    }
}
