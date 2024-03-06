using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SassyScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public LogicScript logic;
    public bool isAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        // alows this script to find and talk to LogicScript.cs
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -6.4)
        {
            if (isAlive)
            {
                logic.gameOver();
                isAlive = false;
            }
        }

        if (Input.GetKeyDown(KeyCode.Space) == true && isAlive)
        {
            myRigidbody.velocity = Vector2.up * 5;
        }
    }

    public bool isSassyAlive()
    {
        return isAlive;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (isAlive) {
            logic.gameOver();
            isAlive = false;
        }
    }
}
