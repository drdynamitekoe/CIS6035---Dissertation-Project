using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionDetection : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other) //A collision is detected
    {

        if (other.gameObject.CompareTag("Bamboo"))
        {
            Destroy(other.gameObject);
        }
    }
}