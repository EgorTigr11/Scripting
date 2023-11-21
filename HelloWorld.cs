using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public int health = 5;
    public int level = 2;
    public float speed = 5;

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
        if (transform.position.z >= 3)
        {
            speed = -5;
        }
        speed += 0.03f;

        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
