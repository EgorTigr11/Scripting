using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public int health = 5;
    public int level = 2;
    public float speed = 4;

    // Start is called before the first frame update
    void Start()
    {
        // Printing text to the console
        print("Welcome to the game!");

        // Add the health
        health += level;
        print("Health: " + health);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z >= 10)
        {
            speed = -5;
        }
        else if (transform.position.z <= 0)
        {
            speed = 5;
        }

        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
