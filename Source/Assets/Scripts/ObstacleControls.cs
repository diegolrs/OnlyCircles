using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ObstacleControls : MonoBehaviour {
    private Rigidbody rb;
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        speed = Random.Range(4,12);
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(new Vector3(0, 0, -speed));
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("FloorDeath"))
        {
            Debug.Log("detroyed");
            Destroy(gameObject);
        }

        if (collision.transform.CompareTag("Player"))
        {
            GameObject.Find("Player").GetComponent<RestartGame>().setRestart(true);
        }
    }
}
