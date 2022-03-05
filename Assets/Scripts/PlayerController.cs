using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float
        horizontalInput,
        speed,
        xRange;

    public GameObject projectilePrefab;

    private void Start()
    {
        speed = 20.0f;
        xRange = 20.0f;
    }

    void Update()
    {
        // Control player movement
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);


        // Enforce boundary for player movement
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        else if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        // Create projectile
        if  (Input.GetKeyDown(KeyCode.Space))
        {
            //Debug.Log("nice");
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

    }
}
