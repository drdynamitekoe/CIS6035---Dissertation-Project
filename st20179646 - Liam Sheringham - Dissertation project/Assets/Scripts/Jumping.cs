using UnityEngine;
using System.Collections;

public class Jumping : MonoBehaviour
{
    
   public Rigidbody rb;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            rb.AddForce(Vector3.up * 50000);
        }
    }
}
