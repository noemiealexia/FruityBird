using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

    public float speed = 10;

    public Transform[] fruitObject;
    static public bool spawned = false;
    static public Vector2 birdPosition;

    void Start()
    {
        
    }

    void Update()
    {

        SpawnFruit();

        Vector3 pos = transform.position;

        if (Input.GetKey("w"))
        {
            pos.y += speed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            pos.y -= speed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            pos.x += speed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            pos.x -= speed * Time.deltaTime;
        }

        if (pos.y > 5)
        {

            pos.y = 5;

        }

        if (pos.y < 2)
        {

            pos.y = 2;

        }


        if (pos.x > 9)
        {

            pos.x = 9;

        }

        if (pos.x < -9)
        {

            pos.x = -9;

        }




        transform.position = pos;

        birdPosition = transform.position;

    }

    void SpawnFruit()
    {

        if (spawned == false)
        {

            Instantiate(fruitObject[Random.Range(0, 3)], transform.position, fruitObject[0].rotation);
            spawned = true;

        }

    }




}
