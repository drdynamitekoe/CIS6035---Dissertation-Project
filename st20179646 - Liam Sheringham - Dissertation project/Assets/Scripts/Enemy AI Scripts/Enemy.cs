using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Enemy : MonoBehaviour
{
    public int maxEnemyHealth = 100; // The players starting health
    public int currentEnemyHealth; //the players current health
    public enemyHealth enemyHealthBar; //The health bar within the HUD

    // Start is called before the first frame update
    void Start()
    {
        currentEnemyHealth = maxEnemyHealth; //Health is set to maximum at the start
        enemyHealthBar.SetMaxEnemyHealth(maxEnemyHealth); //Health bar fill is also set to maximum
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L)) //The space button is pressed
        {
            takeDamage(10); //Health is lost (testing purposes)

        }

        if (currentEnemyHealth <= 0) //Health reaches zero
        {
            Destroy(gameObject); //The game is lost
        }

    }


    void takeDamage(int damage) //Function for taking damage
    {
        currentEnemyHealth -= damage; //The health is decreased by the amount of damage taken
        enemyHealthBar.SetEnemyHealth(currentEnemyHealth); //The healthbar also decreases
    }

}