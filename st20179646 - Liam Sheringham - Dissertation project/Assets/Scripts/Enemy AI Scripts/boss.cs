using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class boss : MonoBehaviour
{
    public int maxBossHealth = 100; // The players starting health
    public int currentBossHealth; //the players current health
    public bossHealth bossHealthBar; //The health bar within the HUD
    public AudioSource BGM;

    public static bool GameIsCompleted = false; //The game over conditions
    public GameObject gameCompletionCutscene; //the game over screen
    public GameObject hudUI; //The HUD 

    // Start is called before the first frame update
    void Start()
    {
        currentBossHealth = maxBossHealth; //Health is set to maximum at the start
        bossHealthBar.SetMaxBossHealth(maxBossHealth); //Health bar fill is also set to maximum
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N)) //The space button is pressed
        {
            takeDamage(5); //Health is lost (testing purposes)

        }

        if (currentBossHealth <= 0) //Health reaches zero
        {
            GameCompleted(); //The game is lost
        }

    }


    void takeDamage(int damage) //Function for taking damage
    {
        currentBossHealth -= damage; //The health is decreased by the amount of damage taken
        bossHealthBar.SetBossHealth(currentBossHealth); //The healthbar also decreases
    }

    void GameCompleted() //The function for when the game over conditions are set
    {
        gameCompletionCutscene.SetActive(true); //The game over screen is displayed
        hudUI.SetActive(false); // The HUD is disabled
        BGM.Stop();
        GameIsCompleted = true; //The game is lost
    }

}
