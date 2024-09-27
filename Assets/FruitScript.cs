using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitScript : MonoBehaviour
{

    private bool onBird = true;
    public float deadZone = -10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (onBird == true)
        {

            GetComponent<Transform>().position = BirdScript.birdPosition;


        }

        if (Input.GetKeyDown("space"))
        {
            GetComponent<Rigidbody2D>().gravityScale = 1;
            onBird = false;
            BirdScript.spawned = false;
        }

        if (transform.position.y < deadZone)
        {
            Destroy(gameObject);
        }

    }
}
