using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float speed = 9000.0f;
    public bool IsGrounded;

    private float resetCounter;

    // Start is called before the first frame update
    void Start()
    {
        speed = 9000.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-1 * Vector3.left * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(1 * Vector3.left * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-1 * Vector3.forward * Time.deltaTime * speed);
            //Rotate(0, -20, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(1 * Vector3.forward * Time.deltaTime * speed);
            //Rotate(0, 20, 0);
        }
    }
}