using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chiRefill : MonoBehaviour
{
    public int maxChi = 100; //The starting chi value
    private int currentChi; //The current chi value
    public energyBar chiBar; //The chi bar

    void Start()
    {
        currentChi = maxChi; //the starting chi bar is set to the maximum energy bar
        chiBar.SetMaxEnergy(maxChi);
    }

    void OnTriggerEnter(Collider collision) //A collision is detected 
    {
        currentChi = maxChi; //The players health at the start 
        chiBar.SetMaxEnergy(maxChi);
        chiBar.SetEnergy(maxChi); //The bar is set to maximum health  

        GameObject otherObject = collision.gameObject;
        Destroy(gameObject); //the resource is destroyed when collided with
    }
}
