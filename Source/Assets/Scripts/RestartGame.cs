using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using UnityEngine;

public class RestartGame : MonoBehaviour
{
    private bool restart;
    private Vector3 initialPosition;
    // Start is called before the first frame update
    void Start()
    {
        restart = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (restart)
        {
            Debug.Log("The game was restarted");
            GameObject player = GameObject.Find("Player");
            player.GetComponent<Movement>().Reset();
            player.GetComponent<Score>().Reset();

            GameObject[] obstacles = GameObject.FindGameObjectsWithTag("Obstacle");

            for(int i = 0; i < obstacles.Length; i++)
            {
                Destroy(obstacles[i]);
            }

            restart = false;
        }
    }

    public void setRestart(bool newValue)
    {
        restart = newValue;
    }

    void OnCollisionEnter(Collision obj)
    {
        if (obj.gameObject.CompareTag("FloorDeath"))
        {
           restart = true;
        }
    }
}
