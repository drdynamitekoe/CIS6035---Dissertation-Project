using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelBegin: MonoBehaviour
{
    public GameObject videoScreen; 
    public GameObject hudUI; //the HUD
    public GameObject BGM;
 public GameObject player; //The player object
    public GameObject camera; //The first person camera for the first vehicle

    void Start()
    {
        Time.timeScale = 0f; // The scene is paused
    }

    public void GameStart() //The first vehicle is chosen
    {
        videoScreen.SetActive(false); 
        hudUI.SetActive(true); //the HUD is displayed
        BGM.SetActive(true);
        player.SetActive(true); //The player object
        Time.timeScale = 1f; //The scene starts

        camera.SetActive(true);

    }

    public void LoadMenu() //The menu is loaded
    {
        Time.timeScale = 1f; //The scene is unpaused
        SceneManager.LoadScene("Main Menu"); //The main menu is loaded
    }

}
