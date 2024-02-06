using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chiRefill : MonoBehaviour
{
    public int maxChi = 100; //The starting chi value
    public int currentChi; //The current chi value
    public energyBar chiBar; //The chi bar

    void Start()
    {
        currentChi = maxChi; //the starting chi bar is set to the maximum energy bar
        chiBar.SetMaxEnergy(maxChi);
    }

    void OnTriggerEnter(Collider collision) //Collision with a energy resource
    {
        GameObject otherObject = collision.gameObject; //The collision is detected 
        Destroy(gameObject); //The resource is destroyed when collided with

        currentChi = maxChi; //The chi is reset to maximum
        chiBar.SetMaxEnergy(maxChi); //The bar is reset to maximum
    
    }
}
