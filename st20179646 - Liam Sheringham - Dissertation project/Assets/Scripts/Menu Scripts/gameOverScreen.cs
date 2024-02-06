using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOverScreen : MonoBehaviour
{
    public GameObject gameOverScreenUI; //The game over screen

    public void RestartGame() //The game is restarted
    {
        SceneManager.LoadScene("Level One"); //Level One is reloaded
    }

}
