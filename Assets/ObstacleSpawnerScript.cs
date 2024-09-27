using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawnerScript : MonoBehaviour
{

    public GameObject heart;
    public float spawnRate = 1;
    private float timer = 0;
    public float heightOffset = 2;

    // Start is called before the first frame update
    void Start()
    {
        spawnHeart();
        
    }

    // Update is called once per frame
    void Update()
    {

        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnHeart();
        }

        
        
    }

    void spawnHeart()
    {

        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(heart, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
        timer = 0;

    }

}
