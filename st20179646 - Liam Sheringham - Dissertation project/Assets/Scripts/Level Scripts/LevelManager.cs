using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public string menuScene;
    public string levelScene;
    public string bossScene;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MenuScene()
    {
        SceneManager.LoadScene(menuScene);
    }

    public void LevelScene()
    {
        SceneManager.LoadScene(levelScene);
    }

    public void BossScene()
    {
        SceneManager.LoadScene(bossScene);
    }

}
