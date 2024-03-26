using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class healthRefill : MonoBehaviour
{
    public int maxHealth = 100; //The players maximum health
    private int currentHealth; //The players current health
    public healthBar healthBar; //The health bar itself


    void OnTriggerEnter(Collider collision) //A collision is detected 
    {
        currentHealth = maxHealth; //The players health at the start 
        healthBar.SetMaxHealth(maxHealth);
        healthBar.SetHealth(maxHealth); //The bar is set to maximum health  

        GameObject otherObject = collision.gameObject;
        Destroy(gameObject); //the resource is destroyed when collided with
    }
}
