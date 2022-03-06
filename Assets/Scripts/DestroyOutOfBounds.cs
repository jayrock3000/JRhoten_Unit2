using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topOfScene = 30.0f;
    private float bottomOfScene = -10.0f;

    void Update()
    {
        if (transform.position.z > topOfScene)
        {
            Destroy(gameObject);
        }

        else if (transform.position.z < bottomOfScene)
        {
            Destroy(gameObject);
            Debug.Log("Game Over!");
            //Debug.Log("You Suck!");
            //Debug.Log("Stop playing video games and go read a book or something!");
        }
    }
}
