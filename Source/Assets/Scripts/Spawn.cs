using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject obstacles;
    private float curTime, maxTime;
    private Vector3 initialPosition;
    private float offset;
    // Start is called before the first frame update
    void Start()
    {
        curTime = 0;
        maxTime = Random.Range(1, 2);
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        curTime += Time.deltaTime;

        if (curTime >= maxTime)
        {
            offset = Random.Range(-0.5f, 1.5f);
            transform.position = initialPosition + new Vector3(offset, 0, 0);
            GameObject.Instantiate(obstacles, transform.position, Quaternion.identity);
            curTime = 0;
            maxTime = Random.Range(1, 2);
        }

    }
}
