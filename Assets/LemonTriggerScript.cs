using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LemonTriggerScript : MonoBehaviour
{
    public LogicScript logic;
    public AudioManagerScript audioManager;

    // Start is called before the first frame update
    void Start()
    {

        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            logic.addScore();
            audioManager.Success();
        }

        else if (collision.gameObject.layer == 6 || collision.gameObject.layer == 7)
        {
            audioManager.Failure();
        }

    }
}
