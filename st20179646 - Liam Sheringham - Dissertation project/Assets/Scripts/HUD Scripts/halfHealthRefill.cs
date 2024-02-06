using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class halfHealthRefill : MonoBehaviour
{
    public int maxHealth = 100; //The players maximum health
    public int currentHealth; //The players current health
    public healthBar healthBar; //The health bar itself

    void Start()
    {
        currentHealth = maxHealth; //The players health at the start 
        healthBar.SetMaxHealth(maxHealth);
        healthBar.SetHealth(maxHealth); //The bar is set to maximum health  
    }

    void OnTriggerEnter(Collider collision) //A collision is detected 
    {
        GameObject otherObject = collision.gameObject;
        Destroy(gameObject); //the resource is destroyed when collided with

        currentHealth = currentHealth + 50; //The health is reset to maximum
        healthBar.SetMaxHealth(currentHealth); //The bar is reset to reflect the players health
    }

}