using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class halfHealthRefill : MonoBehaviour
{
    public int maxHealth = 50; //The players maximum health
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
        currentHealth = maxHealth / 2; //The players health at the start 
        healthBar.SetMaxHealth(maxHealth / 2);
        healthBar.SetHealth(maxHealth / 2); //The bar is set to maximum health  


        GameObject otherObject = collision.gameObject;
        Destroy(gameObject); //the resource is destroyed when collided with

    }

}